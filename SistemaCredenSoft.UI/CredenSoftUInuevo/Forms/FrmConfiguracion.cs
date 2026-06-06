using ModelsEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();

            // Validar rol antes de mostrar el formulario
            if (SesionActual.UsuarioLogueado.IdRol != 2) // 2 = Administrador Local
            {
                MessageBox.Show(
                    "Acceso denegado: su rol no tiene permisos para ingresar al módulo de Configuración.",
                    "Permiso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close(); // Cierra el formulario inmediatamente
                return;
            }

        }
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El módulo de Configuración está en mantenimiento y no disponible en este sprint.",
                "Mantenimiento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close(); // se cierra después del mensaje
        }




    }
}
