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
        // =====================================================
        // SERVICIO DE SOLICITUDES
        // =====================================================

        SolicitudService _solicitudService = new SolicitudService(new CredenSoftContext());

        public FrmSolicitud()
        {
            InitializeComponent();

            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSolicitudes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSolicitudes.MultiSelect = false;
        }

        // =====================================================
        // CARGA DEL FORMULARIO
        // =====================================================

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // =====================================================
        // CARGAR GRILLA
        // =====================================================

        private void CargarGrilla()
        {
            try
            {
                dgvSolicitudes.DataSource = null;
                dgvSolicitudes.DataSource = _solicitudService.ObtenerTodas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar solicitudes: " + ex.Message,
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // NUEVA SOLICITUD
        // =====================================================

        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmAltaSolicitud frmAlta = new FrmAltaSolicitud();

            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                CargarGrilla();
            }
        }

        // =====================================================
        // VER DETALLE DE SOLICITUD
        // =====================================================

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una solicitud.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string datos = "";

            foreach (DataGridViewCell celda in dgvSolicitudes.CurrentRow.Cells)
            {
                datos += celda.Value?.ToString() + " | ";
            }

            MessageBox.Show(
                "Detalle de Solicitud:\n\n" + datos,
                "Detalle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // ELIMINAR SOLICITUD
        // =====================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una solicitud.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar la solicitud seleccionada?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Funcionalidad pendiente de integración con Backend.\n\nLa solicitud sería eliminada correctamente.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarGrilla();
            }
        }

        // =====================================================
        // SALIR
        // =====================================================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}