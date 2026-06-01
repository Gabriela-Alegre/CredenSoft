using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboardAgente : Form
    {
        public FrmDashboardAgente()
        {
            InitializeComponent();
        }

        // =====================================================
        // MI CREDENCIAL
        // =====================================================

        private void btnMiCredencial_Click(object sender, EventArgs e)
        {
            FrmMiCredencial frm = new FrmMiCredencial();
            frm.ShowDialog();
        }

        // =====================================================
        // SOLICITUDES
        // =====================================================

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.ShowDialog();
        }

        // =====================================================
        // PERFIL
        // =====================================================

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.ShowDialog();
        }

        // =====================================================
        // CONFIGURACIÓN
        // =====================================================

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();
            frm.ShowDialog();
        }

        // =====================================================
        // CERRAR SESIÓN
        // =====================================================

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "CredenSoft",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();

                this.Hide();
            }
        }

        // =====================================================
        // VER CREDENCIAL
        // =====================================================

        private void btnVerCredencial_Click(object sender, EventArgs e)
        {
            FrmMiCredencial frm = new FrmMiCredencial();
            frm.ShowDialog();
        }

        // =====================================================
        // NUEVA SOLICITUD
        // =====================================================

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.ShowDialog();
        }

        // =====================================================
        // ACTUALIZAR PERFIL
        // =====================================================

        private void btnActualizarPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.ShowDialog();
        }

        // =====================================================
        // EVENTOS VACÍOS
        // =====================================================

        private void lblMiPaneldeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}