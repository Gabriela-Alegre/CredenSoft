using System;
using System.Windows.Forms;
using ModelsEntidades;
using ServicesNegocio;
using DataEF;
using System.Linq;

namespace CredenSoftUInuevo.Forms
{
   
    public partial class FrmEditarSolicitud : Form
    {
        private Solicitud _solicitud;
        private SolicitudService _solicitudService;
        private UsuarioService _usuarioService;
        private string _estadoOriginal;

        public FrmEditarSolicitud(Solicitud solicitud)
        {
            InitializeComponent();

            _solicitud = solicitud;
            _solicitudService = new SolicitudService();
            _usuarioService = new UsuarioService(new CredenSoftContext());
            // 1. Guardamos el estado original por si querés validarlo después
            if (_solicitud != null)
            {
                _estadoOriginal = _solicitud.Estado;
            }

            // 2. ¡IMPORTANTE! Llamamos al método que rellena los controles de la pantalla
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            if (_solicitud != null)
            {
                // 1. Cargamos el ComboBox de Nombre y Apellido con todos los usuarios disponibles
                var listaUsuarios = _usuarioService.ObtenerTodos(); // Asegurate de usar el método que trae tu UsuarioService para listar
                cmbNombreApellido.DataSource = listaUsuarios;
                cmbNombreApellido.DisplayMember = "Nombre"; // O la propiedad que tengas en Usuario para mostrar el nombre
                cmbNombreApellido.ValueMember = "IdUsuario"; // El ID interno del usuario

                // Seleccionamos el usuario correspondiente a esta solicitud usando su ID (¡Idea profesional!)
                cmbNombreApellido.SelectedValue = _solicitud.IdUsuario;

                // 2. Cargamos los demás campos
                cmbTipoSolicitud.Text = _solicitud.TipoSolicitud;
                txtDni.Text = _solicitud.Usuario != null ? _solicitud.Usuario.Dni : string.Empty;
                cmbEstado.Text = _solicitud.Estado;
                txtDescripcion.Text = _solicitud.Descripcion;

                // 3. Cargamos la ruta del documento adjunto si ya posee uno
                if (_solicitud.ArchivosAdjuntos != null && _solicitud.ArchivosAdjuntos.Count > 0)
                {
                    txtRutaArchivo.Text = _solicitud.ArchivosAdjuntos.First().RutaArchivo;
                }
            }
        }



        private void FrmEditarSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Cargar ComboBox de Tipo de Solicitud (Asegurar que coincidan con los textos de la BD)
                cmbTipoSolicitud.Items.Clear();
                cmbTipoSolicitud.Items.Add("Anexo C");
                cmbTipoSolicitud.Items.Add("Anexo E");
                cmbTipoSolicitud.Items.Add("Credencial Permanente"); // Por si hay registros viejos

                // 2. Cargar ComboBox de Estado
                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("Pendiente");
                cmbEstado.Items.Add("Aprobado");
                cmbEstado.Items.Add("Inactivo");

                // 3. Mostrar el código de solicitud fijo
                lblCodigoSolicitud.Text = _solicitud.IdSolicitud.ToString();

                // 4. Cargar el ComboBox de Usuarios
                var listaUsuarios = _usuarioService.ObtenerTodos();

                cmbNombreApellido.SelectedIndexChanged -= cmbNombreApellido_SelectedIndexChanged;

                cmbNombreApellido.DataSource = listaUsuarios;
                cmbNombreApellido.DisplayMember = "NombreCompleto";
                cmbNombreApellido.ValueMember = "IdUsuario";

                // Seleccionar el usuario actual
                cmbNombreApellido.SelectedValue = _solicitud.IdUsuario;

                cmbNombreApellido.SelectedIndexChanged += cmbNombreApellido_SelectedIndexChanged;

                // 5. Cargar los datos en los controles
                cmbTipoSolicitud.Text = _solicitud.TipoSolicitud?.Trim();
                cmbEstado.Text = _solicitud.Estado?.Trim();
                _estadoOriginal = _solicitud.Estado;

                txtDescripcion.Text = _solicitud.Descripcion;

                // Mostrar DNI (si la propiedad Usuario vino nula, lo buscamos de la lista cargada)
                if (_solicitud.Usuario != null)
                {
                    txtDni.Text = _solicitud.Usuario.Dni;
                }
                else if (cmbNombreApellido.SelectedItem is Usuario usuarioSeleccionado)
                {
                    txtDni.Text = usuarioSeleccionado.Dni;
                }

                // Cargar archivo adjunto si existe
                if (_solicitud.ArchivosAdjuntos != null && _solicitud.ArchivosAdjuntos.Any())
                {
                    var primerArchivo = _solicitud.ArchivosAdjuntos.First();
                    txtRutaArchivo.Text = primerArchivo.RutaArchivo;
                }

                if (_solicitud.FechaSolicitud != default(DateTime))
                {
                    dateTimePicker1.Value = _solicitud.FechaSolicitud;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los datos de la solicitud: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cmbNombreApellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombreApellido.SelectedItem is Usuario usuarioSeleccionado)
            {
                txtDni.Text = usuarioSeleccionado.Dni;
            }
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar documento adjunto";
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostramos la ruta seleccionada en el TextBox en azul
                    txtRutaArchivo.Text = openFileDialog.FileName;

                    // Aseguramos que la lista de archivos adjuntos esté inicializada
                    if (_solicitud.ArchivosAdjuntos == null)
                    {
                        _solicitud.ArchivosAdjuntos = new List<DocumentoAdjunto>();
                    }

                    DocumentoAdjunto documentoAdjunto;

                    // Si ya tiene un archivo cargado, lo actualizamos; si no, creamos uno nuevo
                    if (_solicitud.ArchivosAdjuntos.Count > 0)
                    {
                        documentoAdjunto = _solicitud.ArchivosAdjuntos.First();
                    }
                    else
                    {
                        documentoAdjunto = new DocumentoAdjunto();
                        documentoAdjunto.IdSolicitud = _solicitud.IdSolicitud;
                        _solicitud.ArchivosAdjuntos.Add(documentoAdjunto);
                    }

                    // Asignamos los valores correspondientes según tu entidad
                    documentoAdjunto.RutaArchivo = openFileDialog.FileName;
                    documentoAdjunto.NombreArchivo = System.IO.Path.GetFileName(openFileDialog.FileName);
                    documentoAdjunto.TipoDocumento = "Adjunto Principal"; // O el valor que manejes
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtenemos el ID del usuario seleccionado en el ComboBox mediante el ValueMember
            if (cmbNombreApellido.SelectedValue != null)
            {
                _solicitud.IdUsuario = Convert.ToInt32(cmbNombreApellido.SelectedValue);
            }

            _solicitud.TipoSolicitud = cmbTipoSolicitud.Text;
            _solicitud.Estado = cmbEstado.Text;
            _solicitud.Descripcion = txtDescripcion.Text;

            try
            {
                _solicitudService.Actualizar(_solicitud);
                MessageBox.Show("Solicitud actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}