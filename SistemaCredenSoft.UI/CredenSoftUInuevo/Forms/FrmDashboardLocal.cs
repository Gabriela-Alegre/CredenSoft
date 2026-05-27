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
    public partial class FrmDashboardLocal : Form
    {
        public FrmDashboardLocal()
        {
            InitializeComponent();
        }

        // =====================================================
        // CERRAR SESIÓN
        // PASO 4 - Navegación del Sistema
        // =====================================================

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Volvemos al formulario Login
            FrmLogin frm = new FrmLogin();
            frm.Show();

            // Ocultamos el Dashboard Local
            this.Hide();
        }

        // =====================================================
        // BOTÓN TEMPORAL DE PRUEBA
        // PASO 3.3 - Validación de Restricción por Rol
        // =====================================================

        private void btnProbarAcceso_Click(object sender, EventArgs e)
        {
            // Intentamos abrir el Dashboard Administrador Central
            FrmDashboardAdmin frm = new FrmDashboardAdmin();
            frm.Show();
        }

        // =====================================================
        // VALIDACIONES
        // PASO 3.5 - Navegación a Validaciones
        // =====================================================

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de Validaciones
            FrmValidaciones frm = new FrmValidaciones();
            frm.Show();

            // Ocultamos el Dashboard Local
            this.Hide();
        }

        // =====================================================
        // SEGUNDO BOTÓN VALIDACIONES
        // (si duplicaste el botón desde diseño)
        // =====================================================

        private void btnValidaciones2_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de Validaciones
            FrmValidaciones frm = new FrmValidaciones();
            frm.Show();

            // Ocultamos el Dashboard Local
            this.Hide();
        }
    }
}