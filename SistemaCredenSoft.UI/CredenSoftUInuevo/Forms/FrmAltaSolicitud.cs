using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaSolicitud : Form
    {
        // Instanciamos los servicios
        SolicitudService _solicitudService = new SolicitudService(new CredenSoftContext());

        public FrmAltaSolicitud()
        {
            InitializeComponent();
        }

        // AGREGADO: Este método carga los datos apenas abrís la ventana
        private void FrmAltaSolicitud_Load(object sender, EventArgs e)
        {
            CargarTiposSolicitud();
            dateTimeFecha.Value = DateTime.Now; // Setea fecha actual
        }

        private void CargarTiposSolicitud()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar tipos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica
                if (cmbTipoDeSolicitud.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de solicitud.");
                    return;
                }

                Solicitud nueva = new Solicitud
                {
                    // Usamos la sesión actual para saber quién es el usuario
                    IdUsuario = SesionActual.UsuarioLogueado.IdUsuario,

                    

                    Descripcion = txtDescripcion.Text,
                    FechaSolicitud = dateTimeFecha.Value,
                   // EstadoSolicitud = "Pendiente"
                };

                _solicitudService.CrearSolicitud(nueva);

                MessageBox.Show("Solicitud enviada correctamente.", "Éxito");

                this.DialogResult = DialogResult.OK; // Avisa a la grilla principal que se actualice
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