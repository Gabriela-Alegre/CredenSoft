using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// IMPORTANTE:
// Agregamos esta referencia para acceder a la sesión actual
using ModelsEntidades;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboardAdmin : Form
    {
        public FrmDashboardAdmin()
        {
            InitializeComponent();
        }

        // =====================================================
        // VALIDACIÓN DE ACCESO POR ROL
        // PASO 3.3 - Restricción de Funcionalidades
        // =====================================================

        private void FrmDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Verificamos si el usuario logueado NO es Administrador Central
            if (SesionActual.UsuarioLogueado.IdRol != 1)
            {
                MessageBox.Show(
                    "ACCESO DENEGADO.\nNo posee permisos para ingresar a este panel.",
                    "Seguridad del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                // Cerramos el formulario
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // =====================================================
        // GESTIÓN DE USUARIOS
        // =====================================================

        private void btnGestiónDeUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }
    }
}