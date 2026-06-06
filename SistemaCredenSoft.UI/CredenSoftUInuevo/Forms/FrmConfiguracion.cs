using ModelsEntidades;
using System;
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

                // Cerrar inmediatamente y volver al Dashboard
                this.DialogResult = DialogResult.Cancel;
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

            // Cerrar el formulario inmediatamente después del mensaje
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
