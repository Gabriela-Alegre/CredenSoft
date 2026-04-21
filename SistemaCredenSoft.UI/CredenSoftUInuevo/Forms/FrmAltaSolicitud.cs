using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaSolicitud : Form
    {
        SolicitudService _solicitudService =
            new SolicitudService(new CredenSoftContext());

        public FrmAltaSolicitud()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Solicitud nueva = new Solicitud
                {
                    IdUsuario = SesionActual.UsuarioLogueado.IdUsuario,
                    TipoSolicitud = cmbTipoDeSolicitud.Text,
                    Descripcion = txtDescripcion.Text
                };

                _solicitudService.CrearSolicitud(nueva);

                MessageBox.Show("Solicitud enviada correctamente.");
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
