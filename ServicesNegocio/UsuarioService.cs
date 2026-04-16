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
            // Importante: usamos el contexto que se pasa por parámetro
            _context = context;
        }

        
        // Valida las credenciales y devuelve el usuario con su Rol cargado.
       
        public Usuario Login(string nombreUsuario, string passwordIngresada)
        {
            // Buscamos al usuario incluyendo la tabla de Roles
            var usuario = _context.Usuarios
                .Include(u => u.Rol)
                .FirstOrDefault(u => u.Nombre == nombreUsuario);

            if (usuario == null)
            {
                throw new Exception("El nombre de usuario no existe en el sistema.");
            }

            // Verificamos el hash de la contraseña
            bool esValida = BCrypt.Net.BCrypt.Verify(passwordIngresada, usuario.Contrasenia);

            if (!esValida)
            {
                throw new Exception("La contraseña ingresada es incorrecta.");
            }

            return usuario;
        }

        
        // Registra un nuevo oficial en la base de datos con validaciones de seguridad.
        
        public void RegistrarUsuario(Usuario nuevoUsuario, string passwordPlana)
        {
            // 1. Validación de DNI único (Fundamental para PSA)
            if (_context.Usuarios.Any(u => u.Dni == nuevoUsuario.Dni))
            {
                throw new Exception($"Error: Ya existe un registro con el DNI {nuevoUsuario.Dni}.");
            }

            // 2. Validación de Nombre de Usuario único
            if (_context.Usuarios.Any(u => u.Nombre == nuevoUsuario.Nombre))
            {
                throw new Exception("Error: El nombre de usuario ya está en uso.");
            }

            // 3. Hasheo de contraseña antes de guardar
            nuevoUsuario.Contrasenia = BCrypt.Net.BCrypt.HashPassword(passwordPlana);

            // 4. Guardado en BD
            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();
        }

        
        // Retorna todos los roles disponibles (para llenar ComboBox de Gaby).
        
        public List<Rol> ObtenerRoles()
        {
            return _context.Roles.ToList();
        }

        
        // Retorna la lista de todos los usuarios (para la grilla de Gaby).
        
        public List<Usuario> ObtenerTodos()
        {
            return _context.Usuarios
                .Include(u => u.Rol)
                .ToList();
        }

       
        // Método rápido para verificar si un DNI ya existe (uso preventivo en UI).
        
        public bool ExisteDni(string dni)
        {
            return _context.Usuarios.Any(u => u.Dni == dni);
        }
    }
}