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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 500);   // tamaño inicial
            this.MinimumSize = new Size(900, 650); // tamaño mínimo

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
            dgvSolicitudes.CellFormatting += dgvSolicitudes_CellFormatting;

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
                // Gaby agregue estas líneas aca abajo para cambiar los nombres de las columnas como las queria la profe "de id a codigo de..":
                if (dgvSolicitudes.Columns["IdSolicitud"] != null)
                    dgvSolicitudes.Columns["IdSolicitud"].HeaderText = "Código de Solicitud";

                if (dgvSolicitudes.Columns["IdUsuario"] != null)
                    dgvSolicitudes.Columns["IdUsuario"].HeaderText = "Código de Usuario";
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

        private void dgvSolicitudes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos si estamos en la columna "Usuario" y si la celda tiene datos
            if (dgvSolicitudes.Columns[e.ColumnIndex].Name == "Usuario" && e.Value != null)
            {
                // Convertimos el objeto al tipo de tu entidad de usuario
                var usuarioObj = e.Value as ModelsEntidades.Usuario;

                if (usuarioObj != null)
                {
                    // Mostramos el Nombre y el Apellido concatenados
                    e.Value = usuarioObj.Nombre + " " + usuarioObj.Apellido;
                    e.FormattingApplied = true;
                }
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
                string valorCelda = "";

                // Si es la columna "Usuario", extraemos el nombre y apellido del objeto
                if (dgvSolicitudes.Columns[celda.ColumnIndex].Name == "Usuario" && celda.Value != null)
                {
                    var usuarioObj = celda.Value as ModelsEntidades.Usuario;
                    if (usuarioObj != null)
                    {
                        valorCelda = usuarioObj.Nombre + " " + usuarioObj.Apellido;
                    }
                    else
                    {
                        valorCelda = celda.Value.ToString();
                    }
                }
                else
                {
                    valorCelda = celda.Value?.ToString() ?? "";
                }

                datos += valorCelda + " | ";
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