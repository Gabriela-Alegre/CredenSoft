using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitudes frm = new FrmSolicitudes();
            frm.ShowDialog();
        }

        private void btnCredenciales_Click(object sender, EventArgs e)
        {
            FrmCredenciales frm = new FrmCredenciales();
            frm.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo en desarrollo");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}