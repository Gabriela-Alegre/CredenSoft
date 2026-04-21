using DataEF;
using System;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaCredencial : Form
    {
        private readonly CredencialService _credencialService;

        public FrmAltaCredencial()
        {
            InitializeComponent();
            _credencialService = new CredencialService(new CredenSoftContext());
        }

        private void FrmCredencial_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSolicitud.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una solicitud.");
                    return;
                }

                int idSolicitud = Convert.ToInt32(cmbSolicitud.SelectedValue);
                _credencialService.GenerarCredencial(idSolicitud);

                MessageBox.Show("Credencial generada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}