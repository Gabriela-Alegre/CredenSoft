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
        }

        /// <summary>
        /// HU01 y HU02: Registra un usuario validando que no existan duplicados.
        /// </summary>
        /// <summary>
        /// HU01 y HU02: Registra un usuario validando que no existan duplicados.
        /// Mensajes de error personalizados en español.
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
       
    }
}