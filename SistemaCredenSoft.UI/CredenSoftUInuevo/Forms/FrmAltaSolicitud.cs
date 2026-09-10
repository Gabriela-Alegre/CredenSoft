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
            new SolicitudService();

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

            // 1. Primero definimos y armamos la variable correctamente
            string nombreCompleto = SesionActual.UsuarioLogueado.Nombre + " " + SesionActual.UsuarioLogueado.Apellido;

            // 2. Agregamos esa variable al ComboBox (una sola vez)
            cmbUsuario.Items.Add(nombreCompleto);

            cmbUsuario.SelectedIndex = 0;

            // Bloqueamos edición
            cmbUsuario.Enabled = false;


            // Mostrar DNI del usuario logueado automáticamente
            txtDni.Text = SesionActual.UsuarioLogueado.Dni; // (Ajustá 'Dni' si tu propiedad se llama diferente, ej: Documento)

            // Bloqueamos la edición para que el usuario no pueda alterar su propio DNI
            txtDni.Enabled = false;

            lblArchivoSeleccionado.Text = "Ningún archivo seleccionado";
            lblArchivoSeleccionado.ForeColor = System.Drawing.Color.Gray;
        }

        // =====================================================
        // TIPOS DE SOLICITUD
        // =====================================================

        private void CargarTiposSolicitud()
        {
            try
            {
                cmbTipoDeSolicitud.Items.Clear();

                cmbTipoDeSolicitud.Items.Add("Anexo C");
                cmbTipoDeSolicitud.Items.Add("Anexo E");


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
                // 1. Validación de campos obligatorios
                if (cmbTipoDeSolicitud.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de solicitud.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // 2. Armamos el objeto Solicitud con sus datos principales
                Solicitud nueva = new Solicitud
                {
                    IdUsuario = SesionActual.UsuarioLogueado.IdUsuario,
                    TipoSolicitud = cmbTipoDeSolicitud.Text,
                    Descripcion = txtDescripcion.Text,
                    FechaSolicitud = dateTimeFecha.Value,
                    ArchivosAdjuntos = new List<DocumentoAdjunto>() // Inicializamos la lista vacía
                };

                // 3. AQUÍ VA EL CÓDIGO: Si el usuario seleccionó un archivo, lo agregamos a la lista
                if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                {
                    var adjunto = new DocumentoAdjunto
                    {
                        NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado),
                        RutaArchivo = rutaArchivoSeleccionado, // Guardamos la ruta en la propiedad correspondiente
                        TipoDocumento = "Respaldo" // O el tipo que corresponda
                    };

                    nueva.ArchivosAdjuntos.Add(adjunto);
                }

                // 4. Llamada al servicio para persistir todo (Solicitud y su archivo relacionado por FK)
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
                string errorReal = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(
                   // ex.Message,
                   errorReal,
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

        // =====================================================
        // ADJUNTAR ARCHIVO
        // =====================================================


        // 1. Variable global para almacenar la ruta completa del archivo seleccionado en la PC
        private string rutaArchivoSeleccionado = string.Empty;
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar Documentación de Respaldo";
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. Guardamos la ruta absoluta del archivo elegido en la variable global
                    rutaArchivoSeleccionado = openFileDialog.FileName;

                    // 2. Actualizamos el Label (lo que marqué en azul) para que muestre solo el nombre del archivo
                    lblArchivoSeleccionado.Text = System.IO.Path.GetFileName(rutaArchivoSeleccionado);
                    lblArchivoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen; // Opcional para que se vea verdecito de éxito
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoDeSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblArchivoSeleccionado_Click(object sender, EventArgs e)
        {
            
        }
    }
}