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
        /// HU03 y HU04: Valida credenciales y estado del usuario.
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

            // 2. HU04: Validación de Estado del Usuario
            // Verificamos que no esté "Inactivo" (ignorando mayúsculas/minúsculas)
            if (usuario.Estado.Trim().Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Acceso denegado: Su cuenta de la PSA se encuentra inactiva.");
            }

            // 3. Verificación de Contraseña (HU03)
            bool esValida = BCrypt.Net.BCrypt.Verify(passwordIngresada, usuario.Contrasenia);

            if (!esValida)
            {
                throw new Exception("Credenciales inválidas: La contraseña es incorrecta.");
            }

            return usuario;

            var usuario = _context.Usuarios
        .Include(u => u.Rol)
        .FirstOrDefault(u => u.NombreUsuario == username && u.Password == password);

            if (usuario == null)
            {
                throw new Exception("Usuario o contraseña incorrectos.");
            }

            //  LO QUE FALTA DE LA HU10: Bloqueo por baja lógica
            if (usuario.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("Acceso denegado: Esta cuenta ha sido suspendida por seguridad.");
            }

            // Si está activo, guardamos la sesión
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
                // BCrypt genera una cadena de 60 caracteres.
                nuevoUsuario.Contrasenia = BCrypt.Net.BCrypt.HashPassword(passwordPlana);

                // 5. Guardado
                _context.Usuarios.Add(nuevoUsuario);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Extraemos el error técnico de SQL Server
                var errorSql = ex.InnerException != null ? ex.InnerException.Message : ex.Message;

                // Traducimos los errores más comunes de la base de datos
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
                // Errores generales
                throw new Exception($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
        public void RecuperarContrasenia(string email, string dni, string nuevaClave)
        {
            // 1. Buscamos al usuario que coincida con mail Y dni
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Dni == dni);

            if (usuario == null)
            {
                throw new Exception("Los datos ingresados no coinciden con nuestros registros.");
            }

            // 2. Hasheamos la nueva clave antes de guardarla
            string claveHasheada = BCrypt.Net.BCrypt.HashPassword(nuevaClave);
            usuario.Contrasenia = claveHasheada;

            // 3. Guardamos los cambios
            _context.SaveChanges();
        }

        public List<Rol> ObtenerRoles()
        {
            return _context.Roles.ToList();
        }

        public List<Usuario> ObtenerTodos()
        {
            return _context.Usuarios.Include(u => u.Rol).ToList();
        }
        /// <summary>
        /// HU06: Cambiar el nivel de acceso (Rol) de un usuario en la Base de Datos.
        /// </summary>
        public void ActualizarRol(int idUsuario, int idRol)
        {
            // 1. Validar que el rol exista en el sistema
            var rolExiste = _context.Roles.Any(r => r.IdRol == idRol);
            if (!rolExiste)
            {
                throw new Exception("El rol seleccionado no es válido o no existe.");
            }

            // 2. Buscar al usuario
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            // 3. Asignar el nuevo IdRol (usando ValueMember desde la UI)
            usuario.IdRol = idRol;

            // 4. Guardar cambios en SQL Server
            _context.SaveChanges();
        }

        /// <summary>
        /// HU08 y HU09: Permite modificar datos personales controlando la unicidad del Email.
        /// Campos críticos como DNI o Legajo no se exponen aquí para proteger la identidad oficial.
        /// </summary>
        public void ActualizarPerfilPersonal(int idUsuario, string nombre, string apellido, string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            // HU09: Validación de Unicidad de Correo (que no lo use OTRO usuario)
            if (_context.Usuarios.Any(u => u.Email == email && u.IdUsuario != idUsuario))
            {
                throw new Exception("El correo electrónico ya se encuentra registrado por otro agente.");
            }

            // HU08: Actualizar solo campos permitidos
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

            // En lugar de hacer _context.Usuarios.Remove(), hacemos la baja lógica
            usuario.Estado = "Inactivo";

            _context.SaveChanges();
        }
        /// <summary>
        /// HU09: Valida si un Nombre de Usuario o DNI ya existen en el sistema antes de registrar.
        /// </summary>
        public void ValidarUsuarioNuevo(string nombreUsuario, string dni)
        {
            // Verificar si el Nombre de Usuario ya existe
            var existeUsername = _context.Usuarios.Any(u => u.NombreUsuario == nombreUsuario);
            if (existeUsername)
            {
                throw new Exception("El nombre de usuario ya está asignado a otro agente.");
            }

            // Verificar si el DNI ya existe
            var existeDni = _context.Usuarios.Any(u => u.Dni == dni);
            if (existeDni)
            {
                throw new Exception("Ya existe un usuario registrado con ese número de DNI.");
            }
        }
        /// <summary>
        /// HU06: Trae todos los roles disponibles en la base de datos para cargar los ComboBox de la interfaz.
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
            return _context.Usuarios
                .Include(u => u.Rol)
                .ToList();
        }

    }
}