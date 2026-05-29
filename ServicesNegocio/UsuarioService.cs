using DataEF;
using ModelsEntidades;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesNegocio
{
    public class UsuarioService
    {
        private readonly CredenSoftContext _context;

        public UsuarioService(CredenSoftContext context)
        {
            _context = context;
        }

        /// <summary>
        /// HU03, HU04 y HU10: Valida credenciales, estado del usuario y gestiona la sesión.
        /// </summary>
        public Usuario Login(string email, string passwordIngresada)
        {
            // 1. Buscamos al usuario por Email (HU03) incluyendo su Rol
            var usuario = _context.Usuarios
                .Include(u => u.Rol)
                .FirstOrDefault(u => u.Email == email);

            // Validación: ¿Existe el correo?
            if (usuario == null)
            {
                throw new Exception("El correo electrónico no se encuentra registrado.");
            }

            // 2. HU04 y HU10: Validación de Estado del Usuario (Baja lógica / Suspensión)
            if (usuario.Estado.Trim().Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Acceso denegado: Esta cuenta se encuentra inactiva o suspendida por seguridad.");
            }

            // 3. Verificación de Contraseña Hasheada (HU03)
            bool esValida = BCrypt.Net.BCrypt.Verify(passwordIngresada, usuario.Contrasenia);

            if (!esValida)
            {
                throw new Exception("Credenciales inválidas: La contraseña es incorrecta.");
            }

            // 4. Si las credenciales son válidas y está activo, guardamos la sesión
            SesionActual.UsuarioLogueado = usuario;

            return usuario;
        }

        /// <summary>
        /// HU01 y HU02: Registra un usuario validando que no existan duplicados.
        /// </summary>
        public void RegistrarUsuario(Usuario nuevoUsuario, string passwordPlana)
        {
            try
            {
                // 1. HU02: Validación de DNI único
                if (_context.Usuarios.Any(u => u.Dni == nuevoUsuario.Dni))
                {
                    throw new Exception($"Error: Ya existe un oficial registrado con el DNI {nuevoUsuario.Dni}.");
                }

                // 2. HU02: Validación de Email único
                if (_context.Usuarios.Any(u => u.Email == nuevoUsuario.Email))
                {
                    throw new Exception("Error: El correo electrónico ya está en uso por otro usuario.");
                }

                // 3. Asegurar Estado Inicial (HU01)
                if (string.IsNullOrEmpty(nuevoUsuario.Estado))
                {
                    nuevoUsuario.Estado = "Activo";
                }

                // 4. Seguridad: Hasheo de contraseña
                nuevoUsuario.Contrasenia = BCrypt.Net.BCrypt.HashPassword(passwordPlana);

                // 5. Guardado
                _context.Usuarios.Add(nuevoUsuario);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var errorSql = ex.InnerException != null ? ex.InnerException.Message : ex.Message;

                if (errorSql.Contains("FOREIGN KEY") || errorSql.Contains("id_rol"))
                {
                    throw new Exception("Error de base de datos: El Rol seleccionado no es válido o no existe en la tabla de roles.");
                }
                else if (errorSql.Contains("String or binary data would be truncated") || errorSql.Contains("truncados"))
                {
                    throw new Exception("Error de base de datos: Uno de los campos es demasiado largo (revisa que la contraseña en la BD sea VARCHAR(255)).");
                }
                else
                {
                    throw new Exception($"Error técnico al guardar: {errorSql}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        public void RecuperarContrasenia(string email, string dni, string nuevaClave)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Dni == dni);

            if (usuario == null)
            {
                throw new Exception("Los datos ingresados no coinciden con nuestros registros.");
            }

            string claveHasheada = BCrypt.Net.BCrypt.HashPassword(nuevaClave);
            usuario.Contrasenia = claveHasheada;

            _context.SaveChanges();
        }

        /// <summary>
        /// HU06: Cambiar el nivel de acceso (Rol) de un usuario en la Base de Datos.
        /// </summary>
        public void ActualizarRol(int idUsuario, int idRol)
        {
            var rolExiste = _context.Roles.Any(r => r.IdRol == idRol);
            if (!rolExiste)
            {
                throw new Exception("El rol seleccionado no es válido o no existe.");
            }

            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            usuario.IdRol = idRol;
            _context.SaveChanges();
        }

        /// <summary>
        /// HU08 y HU09: Permite modificar datos personales controlando la unicidad del Email.
        /// </summary>
        public void ActualizarPerfilPersonal(int idUsuario, string nombre, string apellido, string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            if (_context.Usuarios.Any(u => u.Email == email && u.IdUsuario != idUsuario))
            {
                throw new Exception("El correo electrónico ya se encuentra registrado por otro agente.");
            }

            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Email = email;

            _context.SaveChanges();
        }

        /// <summary>
        /// HU10: Cambia el estado del usuario a "Inactivo" (Baja lógica).
        /// </summary>
        public void BajaLogicaUsuario(int idUsuario)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            usuario.Estado = "Inactivo";
            _context.SaveChanges();
        }

        /// <summary>
        /// HU09: Valida si un Nombre de Usuario o DNI ya existen en el sistema antes de registrar.
        /// </summary>
        public void ValidarUsuarioNuevo(string nombreUsuario, string dni)
        {
            if (_context.Usuarios.Any(u => u.Nombre == nombreUsuario))
            {
                throw new Exception("El nombre de usuario ya está asignado a otro agente.");
            }

            if (_context.Usuarios.Any(u => u.Dni == dni))
            {
                throw new Exception("Ya existe un usuario registrado con ese número de DNI.");
            }
        }

        /// <summary>
        /// HU06: Trae todos los roles disponibles para cargar los ComboBox.
        /// </summary>
        public List<Rol> ObtenerTodosLosRoles()
        {
            return _context.Roles.ToList();
        }

        /// <summary>
        /// Consulta general de usuarios para la grilla de administración, incluyendo su rol.
        /// </summary>
        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return _context.Usuarios.Include(u => u.Rol).ToList();
        }
    }
}