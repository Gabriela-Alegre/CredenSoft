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
    public partial class FrmMiCredencial : Form
    {
        public FrmMiCredencial()
        {
            InitializeComponent();
        }

        private void FrmMiCredencial_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El módulo Mi Credencial está en mantenimiento y no disponible en este sprint.",
                "Mantenimiento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close(); // Cierra el formulario inmediatamente después del mensaje
        }


    }
}
