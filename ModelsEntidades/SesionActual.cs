using System;
using ModelsEntidades;

namespace ModelsEntidades
{
    public static class SesionActual
    {
        // Propiedad estática con los datos del usuario que inició sesión (HU03)
        public static Usuario? UsuarioLogueado { get; set; }

        /// <summary>
        /// HU07: Retorna si el usuario logueado es Administrador Central.
        /// </summary>
        public static bool EsAdministradorCentral()
        {
            if (UsuarioLogueado == null || UsuarioLogueado.Rol == null) return false;

            // Evaluamos por el nombre del rol que viene de la base de datos
            return UsuarioLogueado.Rol.NombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase) ||
                   UsuarioLogueado.Rol.NombreRol.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// HU07: Retorna si el usuario logueado es Administrador Local (Rol 2).
        /// </summary>
        public static bool EsAdministradorLocal()
        {
            if (UsuarioLogueado == null || UsuarioLogueado.Rol == null) return false;

            return UsuarioLogueado.Rol.NombreRol.Equals("Administrador Local", StringComparison.OrdinalIgnoreCase) ||
                   UsuarioLogueado.Rol.NombreRol.Equals("Admin Local", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// HU07: Retorna si el usuario logueado es un Agente/Operador (Rol 3).
        /// </summary>
        public static bool EsAgente()
        {
            if (UsuarioLogueado == null || UsuarioLogueado.Rol == null) return false;

            return UsuarioLogueado.Rol.NombreRol.Equals("Agente", StringComparison.OrdinalIgnoreCase) ||
                   UsuarioLogueado.Rol.NombreRol.Equals("Operador", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Método para cerrar sesión limpia
        /// </summary>
        public static void Logout()
        {
            UsuarioLogueado = null;
        }
    }
}