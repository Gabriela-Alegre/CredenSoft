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
    public partial class FrmDashboardAgente : Form
    {
        public FrmDashboardAgente()
        {
            InitializeComponent();
        }

        private void lblMiPaneldeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // =====================================================
        // MI CREDENCIAL
        // =====================================================

        private void btnMiCredencial_Click(object sender, EventArgs e)
        {
            FrmMiCredencial frm = new FrmMiCredencial();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // SOLICITUDES
        // =====================================================

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // PERFIL
        // =====================================================

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // CONFIGURACIÓN
        // =====================================================

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // CERRAR SESIÓN
        // =====================================================

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // VER CREDENCIAL
        // =====================================================

        private void btnVerCredencial_Click(object sender, EventArgs e)
        {
            FrmMiCredencial frm = new FrmMiCredencial();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // NUEVA SOLICITUD
        // =====================================================

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.Show();
            this.Hide();
        }

        // =====================================================
        // ACTUALIZAR PERFIL
        // =====================================================

        private void btnActualizarPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.Show();
            this.Hide();
        }

        private void lblAccionesRápidas_Click(object sender, EventArgs e)
        {

        }

        private void groupCredencial_Enter(object sender, EventArgs e)
        {

        }

        private void lblFechaVencimiento_Click(object sender, EventArgs e)
        {

        }

        // =====================================================
        // BOTÓN TEMPORAL DE PRUEBA
        // VALIDACIÓN DE SEGURIDAD POR ROL
        // =====================================================

        private void btnProbarValidaciones_Click(object sender, EventArgs e)
        {
            // Intentamos abrir el formulario Validaciones
            FrmValidaciones frm = new FrmValidaciones();
            frm.Show();
        }
    }
}