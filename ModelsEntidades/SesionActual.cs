using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsEntidades; // Para que reconozca la clase Usuario

namespace ModelsEntidades
{
    public static class SesionActual
    {
        // Esta propiedad es estática para que se pueda acceder desde 
        // cualquier formulario sin necesidad de crear un "new SesionActual()"
        public static Usuario? UsuarioLogueado { get; set; }

        // Método para cuando Gaby necesite el botón de "Salir"
        public static void Logout()
        {
            UsuarioLogueado = null;
        }
    }
}
