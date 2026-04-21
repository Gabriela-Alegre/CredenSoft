using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmCredenciales : Form
    {
        public FrmCredenciales()
        {
            InitializeComponent();
        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            FrmAltaCredencial frm = new FrmAltaCredencial();
            frm.ShowDialog();
        }
    }
}