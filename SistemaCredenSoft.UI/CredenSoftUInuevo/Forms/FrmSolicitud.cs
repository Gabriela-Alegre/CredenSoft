using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmSolicitud : Form
    {
        // Instanciamos el servicio para cargar la grilla
        SolicitudService _solicitudService = new SolicitudService(new CredenSoftContext());

        public FrmSolicitud()
        {
            InitializeComponent();
        }

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                // Este método trae las solicitudes de la base de datos
                dgvSolicitudes.DataSource = _solicitudService.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes: " + ex.Message);
            }
        }

        

        private void btnNueva_Click(object sender, EventArgs e)
        {
            // Abre el formulario para crear una nueva solicitud
            FrmAltaSolicitud frmAlta = new FrmAltaSolicitud();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                CargarGrilla();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar o cancelar una solicitud
            MessageBox.Show("Función para eliminar en desarrollo.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}