using System;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaSolicitud : Form
    {
        // =====================================================
        // SERVICIO
        // =====================================================

        SolicitudService _solicitudService =
            new SolicitudService(new CredenSoftContext());

        public FrmAltaSolicitud()
        {
            InitializeComponent();
        }

        // =====================================================
        // LOAD
        // =====================================================

        private void FrmAltaSolicitud_Load(object sender, EventArgs e)
        {
            CargarTiposSolicitud();

            // Fecha automática
            dateTimeFecha.Value = DateTime.Now;

            // Mostrar usuario logueado
            cmbUsuario.Items.Clear();

            cmbUsuario.Items.Add(
                SesionActual.UsuarioLogueado.Nombre
            );

            cmbUsuario.SelectedIndex = 0;

            // Bloqueamos edición
            cmbUsuario.Enabled = false;
        }

        // =====================================================
        // TIPOS DE SOLICITUD
        // =====================================================

        private void CargarTiposSolicitud()
        {
            try
            {
                cmbTipoDeSolicitud.Items.Clear();

                cmbTipoDeSolicitud.Items.Add("Credencial Permanente");
                cmbTipoDeSolicitud.Items.Add("Credencial Temporal");
                cmbTipoDeSolicitud.Items.Add("Renovación");
                cmbTipoDeSolicitud.Items.Add("Reimpresión");

                cmbTipoDeSolicitud.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar tipos: " + ex.Message
                );
            }
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación
                if (cmbTipoDeSolicitud.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de solicitud."
                    );

                    return;
                }

                Solicitud nueva = new Solicitud
                {
                    IdUsuario = SesionActual.UsuarioLogueado.IdUsuario,

                    TipoSolicitud = cmbTipoDeSolicitud.Text,

                    Descripcion = txtDescripcion.Text,

                    FechaSolicitud = dateTimeFecha.Value
                };

                _solicitudService.CrearSolicitud(nueva);

                MessageBox.Show(
                    "Solicitud enviada correctamente.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CANCELAR
        // =====================================================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}