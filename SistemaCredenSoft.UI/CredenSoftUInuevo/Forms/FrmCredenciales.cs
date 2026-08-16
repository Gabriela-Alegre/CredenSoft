using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmCredenciales : Form
    {
        public FrmCredenciales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 500);   // tamaño inicial
            this.MinimumSize = new Size(900, 650); // tamaño mínimo
        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            FrmAltaCredencial frm = new FrmAltaCredencial();
            frm.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }
}