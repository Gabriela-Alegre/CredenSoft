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
    public partial class FrmSolicitudes : Form
    {
        public FrmSolicitudes()
        {
            InitializeComponent();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario de alta de solicitudes
            FrmAltaSolicitud frm = new FrmAltaSolicitud();

            // Lo mostramos como cuadro de diálogo
            frm.ShowDialog();
        }
    }
}
