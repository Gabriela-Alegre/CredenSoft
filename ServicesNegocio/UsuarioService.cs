using DataEF;
using ModelsEntidades;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
namespace ServicesNegocio
{
    public class UsuarioService
    {
        private readonly CredenSoftContext _context;

        public UsuarioService()
        {
            _context = new CredenSoftContext();
        }

        public Usuario? Login(string nombreUsuario, string passwordIngresada)
        {
            // 1. Buscamos al usuario por su nombre en la base de datos
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Nombre == nombreUsuario);

            // 2. Si el usuario existe, verificamos la contraseña con BCrypt
            if (usuario != null)
            {
                // Comparamos la clave ingresada con la clave encriptada de la base de datos
                bool esValida = BCrypt.Net.BCrypt.Verify(passwordIngresada, usuario.Contrasenia);

                if (esValida)
                {
                    return usuario; // ¡Login exitoso!
                }
            }

            return null; // Si algo falló, devolvemos null
        }
    }
}