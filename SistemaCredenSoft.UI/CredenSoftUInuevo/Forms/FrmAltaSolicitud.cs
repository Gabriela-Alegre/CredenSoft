using DataEF;
using Microsoft.EntityFrameworkCore;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaSolicitud : Form
    {

        // =====================================================
        // SERVICIO Y VARIABLES
        // =====================================================
        private SolicitudService _solicitudService = new SolicitudService();
        private int idSolicitudEditando = 0;
        private bool esSoloLectura = false;
        private List<string> rutasArchivosSeleccionados = new List<string>();

        // --- ÚNICO CONSTRUCTOR MULTIPROPÓSITO ---
        // Sirve para:
        // - Alta: FrmAltaSolicitud()
        // - Edición: FrmAltaSolicitud(id)
        // - Solo Lectura (Ver): FrmAltaSolicitud(id, true)
        public FrmAltaSolicitud(int idSolicitud = 0, bool soloLectura = false)
        {
            InitializeComponent();

            idSolicitudEditando = idSolicitud;
            esSoloLectura = soloLectura;

            // Si se pasa un ID mayor a 0, cargamos los datos
            if (idSolicitudEditando > 0)
            {
                // Cambiar título si es edición o lectura
                if (esSoloLectura)
                {
                    this.Text = "Detalle de Solicitud (Solo Lectura)";
                    AplicarModoSoloLectura();
                }
                else
                {
                    this.Text = "Modificar Solicitud y Anexo C";
                    btnGuardar.Text = "Actualizar Cambios";
                }

                CargarDatosParaEdicion();
            }
        }


        // --- MÉTODO AUXILIAR PARA BLOQUEAR CONTROLES ---
        private void AplicarModoSoloLectura()
        {
            // Ocultamos el botón de guardar
            btnGuardar.Visible = false;

            // Llamamos a la función que recorre todo de forma recursiva
            BloquearControlesRecursivo(this);
        }

        private void BloquearControlesRecursivo(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.ReadOnly = true;
                }
                else if (c is ComboBox || c is DateTimePicker || c is CheckBox || c is NumericUpDown || c is RadioButton)
                {
                    c.Enabled = false; // Desactiva combos, fechas, checks, números y los radio buttons
                }
                else if (c is Button btn && btn != btnCancelar)
                {
                    // Desactiva los botones de acción dentro del formulario (como "Seleccionar Archivo"), 
                    // pero puedes dejar activo el botón de Cancelar/Salir si lo deseas.
                    btn.Enabled = false;
                }

                // Si el control actual tiene otros controles adentro (paneles, groupbox), entra a recorrerlos
                if (c.HasChildren)
                {
                    BloquearControlesRecursivo(c);
                }
            }
        }



        private void CargarDatosParaEdicion()
        {
            {
                try
                {
                    // Usamos Entity Framework directamente o a través del servicio trayendo el Anexo C relacionado
                    using (var context = new CredenSoftContext())
                    {
                        var solicitud = context.Solicitudes
                            .Include(s => s.DetalleAnexoC) // Vital para traer los datos del anexo
                            .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                        if (solicitud != null)
                        {
                            // 1. Cargar campos generales de la solicitud (ejemplo)
                            txtDescripcion.Text = solicitud.Descripcion;
                            dateTimeFecha.Value = solicitud.FechaSolicitud;

                            // Si tienes un ComboBox para el tipo de solicitud:
                            // cmbTipoSolicitud.Text = solicitud.TipoSolicitud;

                            // 2. Cargar los datos específicos del Anexo C si corresponde
                            if (solicitud.DetalleAnexoC != null)
                            {
                                MapearAnexoAControles(solicitud.DetalleAnexoC);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos para editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // =====================================================
        // LOAD
        // =====================================================

        private void FrmAltaSolicitud_Load(object sender, EventArgs e)
        {
            CargarTiposSolicitud();
            ConfigurarEventosSectores();


            // Ocultar paneles al arrancar
            panelContenedorAnexoE.Visible = false;

            // Si es una solicitud NUEVA (id 0)
            if (idSolicitudEditando == 0)
            {
                dateTimeFecha.Value = DateTime.Now;

                // Cargamos el usuario logueado asegurando su ID
                var listaUnica = new List<Usuario> { SesionActual.UsuarioLogueado };

                cmbUsuario.DataSource = listaUnica;
                cmbUsuario.DisplayMember = "NombreCompleto"; // O concatenar Nombre + Apellido en tu modelo
                cmbUsuario.ValueMember = "IdUsuario";       // ESTO GUARDA EL ID REAL
                cmbUsuario.SelectedIndex = 0;
                cmbUsuario.Enabled = false;

                txtDni.Text = SesionActual.UsuarioLogueado.Dni;
                txtDni.Enabled = false;

                lblArchivoSeleccionado.Text = "Ningún archivo seleccionado";
                lblArchivoSeleccionado.ForeColor = System.Drawing.Color.Gray;
            }
            else // ==========================================
                 // MODO EDICIÓN O SOLO LECTURA (id > 0)
                 // ==========================================
            {
                using (var context = new CredenSoftContext())
                {
                    var solicitud = context.Solicitudes
                        .Include(s => s.DetalleAnexoC)
                        .Include(s => s.ArchivosAdjuntos)
                        .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                    if (solicitud != null)
                    {
                        // 1. Datos generales de la solicitud
                        txtDescripcion.Text = solicitud.Descripcion;
                        dateTimeFecha.Value = solicitud.FechaSolicitud;
                        cmbTipoDeSolicitud.Text = solicitud.TipoSolicitud;

                        // 2. CORREGIDO: Cargar todos los usuarios y seleccionar el correcto de la solicitud
                        var listaUsuarios = context.Usuarios.ToList(); // Traemos todos los usuarios de la BD
                        cmbUsuario.DataSource = listaUsuarios;
                        cmbUsuario.DisplayMember = "Nombre"; // Ajustá esto según la propiedad de tu clase Usuario (ej. NombreCompleto, Apellido, etc.)
                        cmbUsuario.ValueMember = "IdUsuario";   // Esto vincula el ID oculto necesario para que no rompa

                        // Seleccionamos el usuario que hizo esta solicitud (ej. Carla o Juan)
                        cmbUsuario.SelectedValue = solicitud.IdUsuario;

                        cmbUsuario.Enabled = false; // Bloqueado para que no lo cambien por error
                        txtDni.Enabled = false;

                        // Si necesitás mostrar el DNI del usuario correspondiente:
                        var usuarioAsociado = listaUsuarios.FirstOrDefault(u => u.IdUsuario == solicitud.IdUsuario);
                        if (usuarioAsociado != null)
                        {
                            txtDni.Text = usuarioAsociado.Dni;
                        }

                        // 2. Cargar el archivo adjunto si existe
                        var listaAdjuntos = solicitud.ArchivosAdjuntos.ToList();
                        if (listaAdjuntos.Any())
                        {
                            rutasArchivosSeleccionados = listaAdjuntos.Select(a => a.RutaArchivo).ToList();
                            int total = rutasArchivosSeleccionados.Count;

                            if (total == 1)
                            {
                                lblArchivoSeleccionado.Text = listaAdjuntos.First().NombreArchivo;
                            }
                            else
                            {
                                lblArchivoSeleccionado.Text = $"{total} archivos seleccionados";
                            }

                            lblArchivoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
                            txtRutaArchivo.Text = string.Join("; ", rutasArchivosSeleccionados); // <--- Llena el TextBox para que no quede vacío al editar
                        }
                        else
                        {
                            lblArchivoSeleccionado.Text = "Ningún archivo seleccionado";
                            lblArchivoSeleccionado.ForeColor = System.Drawing.Color.Gray;
                            txtRutaArchivo.Clear();
                        }
                        // Si la solicitud ya tiene un archivo cargado, habilitamos el botón "Ver".
                        // Si no tiene archivo, lo dejamos deshabilitado para que no den clic en vano.
                        btnVerDoc.Enabled = !string.IsNullOrWhiteSpace(txtRutaArchivo.Text);

                        // 3. Si es Anexo C, rellenamos los controles
                        if (solicitud.TipoSolicitud != null && solicitud.TipoSolicitud.Contains("Anexo C") && solicitud.DetalleAnexoC != null)
                        {
                            panelContenedorAnexoE.Visible = true;

                            // Rellenamos los campos llamando a tu método de mapeo
                            MapearAnexoAControles(solicitud.DetalleAnexoC);


                        }
                    }
                }
            }
            // Para que los eventos seactiven SOLO DESPUÉS de que el formulario ya cargó los datos:
            txtAnexoCApellidos.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCApellidos, "");
            txtAnexoCNombres.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCNombres, "");
            cmbTipoDocumento.SelectedIndexChanged += (s, e) => errorProvider1.SetError(cmbTipoDocumento, "");
            txtAnexoCDniPasaporte.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCDniPasaporte, "");
            cmbAnexoCEstadoCivil.SelectedIndexChanged += (s, e) => errorProvider1.SetError(cmbAnexoCEstadoCivil, "");
            txtAnexoCCalle.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCCalle, "");
            txtAnexoCNro.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCNro, "");
            txtAnexoCLocalidad.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCLocalidad, "");
            txtAnexoCAeropuerto.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCAeropuerto, "");
            txtAnexoCNotaPermiso.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCNotaPermiso, "");
            txtAnexoCCargo.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCCargo, "");
            txtRutaArchivo.TextChanged += (s, e) => errorProvider1.SetError(txtRutaArchivo, "");

            txtSector1CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector1CJustif, "");
            txtSector2CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector2CJustif, "");
            txtSector3CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector3CJustif, "");
            txtSector4CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector4CJustif, "");
            txtSector5CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector5CJustif, "");
            txtSector6CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector6CJustif, "");
            txtSector7CJustif.TextChanged += (s, e) => errorProvider1.SetError(txtSector7CJustif, "");
            txtAnexoCTelPart.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCTelPart, "");
            txtAnexoCMail.TextChanged += (s, e) => errorProvider1.SetError(txtAnexoCMail, "");
            foreach (RadioButton rb in gbGrupoSanguineo.Controls.OfType<RadioButton>())
                rb.CheckedChanged += (s, e) => { if (rb.Checked) errorProvider1.SetError(gbGrupoSanguineo, ""); };

            foreach (RadioButton rb in gbFactorRh.Controls.OfType<RadioButton>())
                rb.CheckedChanged += (s, e) => { if (rb.Checked) errorProvider1.SetError(gbFactorRh, ""); };

            foreach (RadioButton rb in gbConductor.Controls.OfType<RadioButton>())
                rb.CheckedChanged += (s, e) => { if (rb.Checked) errorProvider1.SetError(gbConductor, ""); };

            foreach (RadioButton rb in gbSocorrista.Controls.OfType<RadioButton>())
                rb.CheckedChanged += (s, e) => { if (rb.Checked) errorProvider1.SetError(gbSocorrista, ""); };
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
        // CONFIGURAR EVENTOS DE SECTORES
        // =====================================================

        private void ConfigurarEventosSectores()
        {
            chkSectorC1.CheckedChanged += (s, e) => { txtSector1CJustif.Enabled = chkSectorC1.Checked; if (!chkSectorC1.Checked) txtSector1CJustif.Clear(); };
            chkSectorC2.CheckedChanged += (s, e) => { txtSector2CJustif.Enabled = chkSectorC2.Checked; if (!chkSectorC2.Checked) txtSector2CJustif.Clear(); };
            chkSectorC3.CheckedChanged += (s, e) => { txtSector3CJustif.Enabled = chkSectorC3.Checked; if (!chkSectorC3.Checked) txtSector3CJustif.Clear(); };
            chkSectorC4.CheckedChanged += (s, e) => { txtSector4CJustif.Enabled = chkSectorC4.Checked; if (!chkSectorC4.Checked) txtSector4CJustif.Clear(); };
            chkSectorC5.CheckedChanged += (s, e) => { txtSector5CJustif.Enabled = chkSectorC5.Checked; if (!chkSectorC5.Checked) txtSector5CJustif.Clear(); };
            chkSectorC6.CheckedChanged += (s, e) => { txtSector6CJustif.Enabled = chkSectorC6.Checked; if (!chkSectorC6.Checked) txtSector6CJustif.Clear(); };
            chkSectorC7.CheckedChanged += (s, e) => { txtSector7CJustif.Enabled = chkSectorC7.Checked; if (!chkSectorC7.Checked) txtSector7CJustif.Clear(); };
        }

        // =====================================================
        // VALIDAR FORMULARIO
        // =====================================================
        private bool ValidarFormulario()
        {
            // 1. Apellido y Nombre
            if (string.IsNullOrWhiteSpace(txtAnexoCApellidos.Text))
            {
                errorProvider1.SetError(txtAnexoCApellidos, "Complete este campo");
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCApellidos.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCApellidos, "");
            }

            if (string.IsNullOrWhiteSpace(txtAnexoCNombres.Text))
            {
                errorProvider1.SetError(txtAnexoCNombres, "Complete este campo");
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCNombres.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCNombres, "");
            }

            // 2. DNI / PASAPORTE
            if (cmbTipoDocumento.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbTipoDocumento.Text))
            {
                errorProvider1.SetError(cmbTipoDocumento, "Complete este campo");
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoDocumento.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbTipoDocumento, "");
            }

            if (string.IsNullOrWhiteSpace(txtAnexoCDniPasaporte.Text))
            {
                errorProvider1.SetError(txtAnexoCDniPasaporte, "Complete este campo");
                MessageBox.Show("Debe colocar su numero de DNI o Pasaporte.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCDniPasaporte.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCDniPasaporte, "");
            }

            // 3. Estado Civil
            if (cmbAnexoCEstadoCivil.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbAnexoCEstadoCivil.Text))
            {
                errorProvider1.SetError(cmbAnexoCEstadoCivil, "Complete este campo");
                MessageBox.Show("Debe seleccionar un Estado Civil.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAnexoCEstadoCivil.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(cmbAnexoCEstadoCivil, "");
            }

            // 4. Domicilio
            if (string.IsNullOrWhiteSpace(txtAnexoCCalle.Text) ||
                string.IsNullOrWhiteSpace(txtAnexoCNro.Text) ||
                string.IsNullOrWhiteSpace(txtAnexoCLocalidad.Text))
            {
                // Marcamos los campos de domicilio individualmente si están vacíos
                errorProvider1.SetError(txtAnexoCCalle, string.IsNullOrWhiteSpace(txtAnexoCCalle.Text) ? "Complete este campo" : "");
                errorProvider1.SetError(txtAnexoCNro, string.IsNullOrWhiteSpace(txtAnexoCNro.Text) ? "Complete este campo" : "");
                errorProvider1.SetError(txtAnexoCLocalidad, string.IsNullOrWhiteSpace(txtAnexoCLocalidad.Text) ? "Complete este campo" : "");

                MessageBox.Show("Los campos Calle, Número y Localidad del domicilio son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCCalle.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCCalle, "");
                errorProvider1.SetError(txtAnexoCNro, "");
                errorProvider1.SetError(txtAnexoCLocalidad, "");
            }
            //Telefono particular
            if (string.IsNullOrWhiteSpace(txtAnexoCTelPart.Text))
            {
                errorProvider1.SetError(txtAnexoCTelPart, "Complete este campo");
                MessageBox.Show("El campo Teléfono Particular es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCTelPart.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCTelPart, "");
            }

            // Mail
            if (string.IsNullOrWhiteSpace(txtAnexoCMail.Text))
            {
                errorProvider1.SetError(txtAnexoCMail, "Complete este campo");
                MessageBox.Show("El campo Mail es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCMail.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCMail, "");
            }

            // Grupo Sanguíneo (Verifica si hay algún RadioButton marcado dentro del GroupBox)
            bool grupoSanguineoSeleccionado = gbGrupoSanguineo.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!grupoSanguineoSeleccionado)
            {
                errorProvider1.SetError(gbGrupoSanguineo, "Seleccione una opción");
                MessageBox.Show("Debe seleccionar un Grupo Sanguíneo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbGrupoSanguineo.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(gbGrupoSanguineo, "");
            }

            // Factor RH
            bool factorRhSeleccionado = gbFactorRh.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!factorRhSeleccionado)
            {
                errorProvider1.SetError(gbFactorRh, "Seleccione una opción");
                MessageBox.Show("Debe seleccionar un Factor RH.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbFactorRh.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(gbFactorRh, "");
            }

            // Conductor
            bool conductorSeleccionado = gbConductor.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!conductorSeleccionado)
            {
                errorProvider1.SetError(gbConductor, "Seleccione una opción");
                MessageBox.Show("Debe indicar si es Conductor (Sí o No).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbConductor.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(gbConductor, "");
            }

            // Socorrista
            bool socorristaSeleccionado = gbSocorrista.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!socorristaSeleccionado)
            {
                errorProvider1.SetError(gbSocorrista, "Seleccione una opción");
                MessageBox.Show("Debe indicar si es Socorrista (Sí o No).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbSocorrista.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(gbSocorrista, "");
            }

            // 5. Aeropuerto
            if (string.IsNullOrWhiteSpace(txtAnexoCAeropuerto.Text))
            {
                errorProvider1.SetError(txtAnexoCAeropuerto, "Complete este campo");
                MessageBox.Show("El campo Aeropuerto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCAeropuerto.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCAeropuerto, "");
            }

            // 6. Anual / Nro permiso / Nota
            if (string.IsNullOrWhiteSpace(txtAnexoCNotaPermiso.Text))
            {
                errorProvider1.SetError(txtAnexoCNotaPermiso, "Complete este campo");
                MessageBox.Show("El campo Anual/Nota/nro Permiso es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCNotaPermiso.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCNotaPermiso, "");
            }

            // 7. Cargo y Función
            if (string.IsNullOrWhiteSpace(txtAnexoCCargo.Text))
            {
                errorProvider1.SetError(txtAnexoCCargo, "Complete este campo");
                MessageBox.Show("El campo Cargo/Función es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCCargo.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtAnexoCCargo, "");
            }

            // 8. Justificaciones de Sectores
            if (chkSectorC1.Checked && string.IsNullOrWhiteSpace(txtSector1CJustif.Text))
            {
                errorProvider1.SetError(txtSector1CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 1.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector1CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector1CJustif, ""); }

            if (chkSectorC2.Checked && string.IsNullOrWhiteSpace(txtSector2CJustif.Text))
            {
                errorProvider1.SetError(txtSector2CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 2.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector2CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector2CJustif, ""); }

            if (chkSectorC3.Checked && string.IsNullOrWhiteSpace(txtSector3CJustif.Text))
            {
                errorProvider1.SetError(txtSector3CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 3.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector3CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector3CJustif, ""); }

            if (chkSectorC4.Checked && string.IsNullOrWhiteSpace(txtSector4CJustif.Text))
            {
                errorProvider1.SetError(txtSector4CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 4.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector4CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector4CJustif, ""); }

            if (chkSectorC5.Checked && string.IsNullOrWhiteSpace(txtSector5CJustif.Text))
            {
                errorProvider1.SetError(txtSector5CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 5.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector5CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector5CJustif, ""); }

            if (chkSectorC6.Checked && string.IsNullOrWhiteSpace(txtSector6CJustif.Text))
            {
                errorProvider1.SetError(txtSector6CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 6.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector6CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector6CJustif, ""); }

            if (chkSectorC7.Checked && string.IsNullOrWhiteSpace(txtSector7CJustif.Text))
            {
                errorProvider1.SetError(txtSector7CJustif, "Complete este campo");
                MessageBox.Show("Debe ingresar la justificación para el Sector 7.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector7CJustif.Focus();
                return false;
            }
            else { errorProvider1.SetError(txtSector7CJustif, ""); }

            // 9. Archivo / Foto
            if (string.IsNullOrWhiteSpace(txtRutaArchivo.Text))
            {
                errorProvider1.SetError(txtRutaArchivo, "Complete este campo");
                MessageBox.Show("Debe adjuntar su foto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRutaArchivo.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtRutaArchivo, "");
            }

            return true; // Si pasa todas las validaciones
        }

        // =====================================================
        // GUARDAR
        // =====================================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            try
            {
                using (var context = new CredenSoftContext())
                {
                    if (idSolicitudEditando > 0)
                    {
                        // ==========================================
                        // MODO EDICIÓN (UPDATE)
                        // ==========================================
                        string tipoDocAlta = cmbTipoDocumento.SelectedItem?.ToString() ?? "";
                        string numeroDocAlta = txtAnexoCDniPasaporte.Text.Trim();

                        var solicitudExistente = context.Solicitudes
                            .Include(s => s.DetalleAnexoC)
                            .Include(s => s.ArchivosAdjuntos)
                            .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                        if (solicitudExistente != null)
                        {
                            // 1. Actualizar datos generales
                            solicitudExistente.Descripcion = txtDescripcion.Text.Trim();
                            solicitudExistente.FechaSolicitud = dateTimeFecha.Value;
                            solicitudExistente.TipoSolicitud = cmbTipoDeSolicitud.Text.Trim();

                            // 2. Actualizar Detalle Anexo C
                            if (solicitudExistente.DetalleAnexoC != null)
                            {
                                MapearControlesAAnexoC(solicitudExistente.DetalleAnexoC);
                            }
                            else
                            {
                                var nuevoDetalleC = new DetalleAnexoC();
                                MapearControlesAAnexoC(nuevoDetalleC);
                                solicitudExistente.DetalleAnexoC = nuevoDetalleC;
                            }

                            // 3. Actualizar archivo adjunto si se seleccionó uno nuevo
                            if (rutasArchivosSeleccionados.Any())
                            {
                                if (solicitudExistente.ArchivosAdjuntos == null)
                                {
                                    solicitudExistente.ArchivosAdjuntos = new List<DocumentoAdjunto>();
                                }

                                context.Set<DocumentoAdjunto>().RemoveRange(solicitudExistente.ArchivosAdjuntos);

                                foreach (var ruta in rutasArchivosSeleccionados)
                                {
                                    solicitudExistente.ArchivosAdjuntos.Add(new DocumentoAdjunto
                                    {
                                        IdSolicitud = solicitudExistente.IdSolicitud,
                                        NombreArchivo = System.IO.Path.GetFileName(ruta),
                                        RutaArchivo = ruta
                                    });
                                }
                            }
                        }
                    }
                    else
                    {
                        // ==========================================
                        // MODO ALTA (INSERT)
                        // ==========================================
                        int idUsuarioParaGuardar = 0;
                        if (cmbUsuario.SelectedValue != null && int.TryParse(cmbUsuario.SelectedValue.ToString(), out int idVal))
                        {
                            idUsuarioParaGuardar = idVal;
                        }
                        else
                        {
                            idUsuarioParaGuardar = SesionActual.UsuarioLogueado.IdUsuario;
                        }

                        var nuevaSolicitud = new Solicitud
                        {
                            IdUsuario = idUsuarioParaGuardar,
                            Descripcion = txtDescripcion.Text.Trim(),
                            FechaSolicitud = dateTimeFecha.Value,
                            TipoSolicitud = cmbTipoDeSolicitud.Text.Trim(),

                            ArchivosAdjuntos = new List<DocumentoAdjunto>()

                        };

                        var nuevoDetalleC = new DetalleAnexoC();
                        MapearControlesAAnexoC(nuevoDetalleC);
                        nuevaSolicitud.DetalleAnexoC = nuevoDetalleC;

                        // Agregar archivo adjunto si existe

                        if (rutasArchivosSeleccionados.Any())
                        {
                            foreach (var ruta in rutasArchivosSeleccionados)
                            {
                                nuevaSolicitud.ArchivosAdjuntos.Add(new DocumentoAdjunto
                                {
                                    NombreArchivo = System.IO.Path.GetFileName(ruta),
                                    RutaArchivo = ruta
                                });
                            }
                        }

                        context.Solicitudes.Add(nuevaSolicitud);
                    }

                    // Guardado final unificado para ambos casos
                    context.SaveChanges();

                    MessageBox.Show("¡Guardado exitosamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Vital para que el listado principal se entere y actualice la grilla
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar Documentación de Respaldo";
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.png";
                openFileDialog.Multiselect = false; // <--- ESTO PERMITE SELECCIONAR MÁS DE UNO

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutasArchivosSeleccionados.Clear();
                    txtRutaArchivo.Clear();
                    rutasArchivosSeleccionados.AddRange(openFileDialog.FileNames);

                    int total = rutasArchivosSeleccionados.Count;
                    if (total == 1)
                    {
                        lblArchivoSeleccionado.Text = System.IO.Path.GetFileName(rutasArchivosSeleccionados[0]);
                    }
                    else
                    {
                        lblArchivoSeleccionado.Text = $"{total} archivos seleccionados";
                    }

                    lblArchivoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
                    txtRutaArchivo.Text = string.Join("; ", rutasArchivosSeleccionados); // <--- Llena el TextBox visualmente
                }
            }
        }
        // =====================================================
        // TIPO DE SOLICITUD
        // =====================================================
        private void cmbTipoDeSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenemos el texto de lo que el usuario seleccionó en el ComboBox
            string seleccion = cmbTipoDeSolicitud.Text.Trim();

            // Validamos qué texto contiene para mostrar el panel correcto
            if (seleccion.Contains("Anexo C"))
            {
                panelContenedorAnexoE.Visible = true;
                panelContenedorAnexoE.BringToFront();
            }
            else if (seleccion.Contains("Anexo E"))
            {
                // Si el Anexo E ahora se maneja dentro del mismo contenedor o flujo unificado:
                panelContenedorAnexoE.Visible = true;
                panelContenedorAnexoE.BringToFront();
            }
            else
            {
                // Si no selecciona nada válido, se oculta
                panelContenedorAnexoE.Visible = false;
            }


        }

        // =====================================================
        // MAPEO DE CONTROLES A ENTIDAD DETALLES DE ANECO C 
        // =====================================================
        private void MapearControlesAAnexoC(DetalleAnexoC detalle)
        {
            // Extracción de RadioButtons de Grupo Sanguíneo
            string grupoSanguineoSeleccionado = "";
            if (rbtnGrupoA.Checked) grupoSanguineoSeleccionado = "A";
            else if (rbtnGrupoB.Checked) grupoSanguineoSeleccionado = "B";
            else if (rbtnGrupoAB.Checked) grupoSanguineoSeleccionado = "AB";
            else if (rbtnGrupoO.Checked) grupoSanguineoSeleccionado = "O";

            // Extracción de RadioButtons de Factor RH
            string factorRhSeleccionado = "";
            if (rbtnFactorPositivo.Checked) factorRhSeleccionado = "Positivo";
            else if (rbtnFactorNegativo.Checked) factorRhSeleccionado = "Negativo";

            // Mapeo de propiedades
            detalle.Aeropuerto = txtAnexoCAeropuerto.Text.Trim();
            detalle.NumeroNotaPermiso = txtAnexoCNotaPermiso.Text.Trim();
            detalle.Apellido = txtAnexoCApellidos.Text.Trim();
            detalle.Nombres = txtAnexoCNombres.Text.Trim();
            detalle.DniPasaporte = txtAnexoCDniPasaporte.Text.Trim();
            detalle.EstadoCivil = cmbAnexoCEstadoCivil.SelectedItem?.ToString() ?? "";
            detalle.LugarNacimiento = txtAnexoCLugarNac.Text.Trim();
            detalle.FechaNacimiento = dtpAnexoCFechaNac.Value;
            detalle.CargoFuncion = txtAnexoCCargo.Text.Trim();
            detalle.Calle = txtAnexoCCalle.Text.Trim();
            detalle.Nro = txtAnexoCNro.Text.Trim();
            detalle.Depto = txtAnexoCDepto.Text.Trim();
            detalle.Cp = txtAnexoCCP.Text.Trim();
            detalle.Localidad = txtAnexoCLocalidad.Text.Trim();
            detalle.TelParticular = txtAnexoCTelPart.Text.Trim();
            detalle.TelLaboral = txtAnexoCTelLab.Text.Trim();
            detalle.Mail = txtAnexoCMail.Text.Trim();
            detalle.GrupoSanguineo = grupoSanguineoSeleccionado;
            detalle.FactorRh = factorRhSeleccionado;
            detalle.EnfermedadesAlergias = txtAnexoCEnfermedades.Text.Trim();
            detalle.Socorrista = rbtnSocorristaSi.Checked;
            detalle.Conductor = rbtnConductorSi.Checked;
            detalle.Sector1 = chkSectorC1.Checked;
            detalle.Sector1Justif = txtSector1CJustif.Text.Trim();
            detalle.Sector2 = chkSector2.Checked;
            detalle.Sector2Justif = txtSector2CJustif.Text.Trim();
            detalle.Sector3 = chkSector3.Checked;
            detalle.Sector3Justif = txtSector3CJustif.Text.Trim();
            detalle.Sector4 = chkSector4.Checked;
            detalle.Sector4Justif = txtSector4CJustif.Text.Trim();
            detalle.Sector5 = chkSector5.Checked;
            detalle.Sector5Justif = txtSector5CJustif.Text.Trim();
            detalle.Sector6 = chkSector6.Checked;
            detalle.Sector6Justif = txtSector6CJustif.Text.Trim();
            detalle.Sector7 = chkSector7.Checked;
            detalle.Sector7Justif = txtSector7CJustif.Text.Trim();
            detalle.JustifSnaRegionales = txtAnexoCJustifSna.Text.Trim();

            string tipo = cmbTipoDocumento.Text.Trim();          // Ejemplo: "DNI"
            string numero = txtAnexoCDniPasaporte.Text.Trim();   // Ejemplo: "38222222"

            // Esto une ambos textos con un espacio para guardarlos en la única columna de la base de datos
            detalle.DniPasaporte = $"{tipo} {numero}";

        }

        // =====================================================
        // MAPEO DE ANEXO  A CONTROLES DETALLES DE ANEXO C 
        // =====================================================
        private void MapearAnexoAControles(DetalleAnexoC detalle)
        {
            // Textos generales
            txtAnexoCAeropuerto.Text = detalle.Aeropuerto;
            txtAnexoCNotaPermiso.Text = detalle.NumeroNotaPermiso;
            txtAnexoCApellidos.Text = detalle.Apellido;
            txtAnexoCNombres.Text = detalle.Nombres;
            txtAnexoCDniPasaporte.Text = detalle.DniPasaporte;
            cmbAnexoCEstadoCivil.SelectedItem = detalle.EstadoCivil;
            txtAnexoCLugarNac.Text = detalle.LugarNacimiento;
            dtpAnexoCFechaNac.Value = detalle.FechaNacimiento != default ? detalle.FechaNacimiento : DateTime.Now;
            txtAnexoCCargo.Text = detalle.CargoFuncion;

            // Domicilio y Contacto
            txtAnexoCCalle.Text = detalle.Calle;
            txtAnexoCNro.Text = detalle.Nro;
            txtAnexoCDepto.Text = detalle.Depto;
            txtAnexoCCP.Text = detalle.Cp;
            txtAnexoCLocalidad.Text = detalle.Localidad;
            txtAnexoCTelPart.Text = detalle.TelParticular;
            txtAnexoCTelLab.Text = detalle.TelLaboral;
            txtAnexoCMail.Text = detalle.Mail;

            // RadioButtons de Grupo Sanguíneo
            rbtnGrupoA.Checked = (detalle.GrupoSanguineo == "A");
            rbtnGrupoB.Checked = (detalle.GrupoSanguineo == "B");
            rbtnGrupoAB.Checked = (detalle.GrupoSanguineo == "AB");
            rbtnGrupoO.Checked = (detalle.GrupoSanguineo == "O");

            // RadioButtons de Factor RH
            rbtnFactorPositivo.Checked = (detalle.FactorRh == "Positivo");
            rbtnFactorNegativo.Checked = (detalle.FactorRh == "Negativo");

            // Datos médicos y roles específicos
            txtAnexoCEnfermedades.Text = detalle.EnfermedadesAlergias;
            rbtnSocorristaSi.Checked = detalle.Socorrista;
            rbtnSocorristaNo.Checked = !detalle.Socorrista; // Asumiendo que tenés el "No"
            rbtnConductorSi.Checked = detalle.Conductor;
            rbtnConductorNo.Checked = !detalle.Conductor;   // Asumiendo que tenés el "No"

            // Sectores y Justificaciones
            chkSectorC1.Checked = detalle.Sector1;
            txtSector1CJustif.Text = detalle.Sector1Justif;
            chkSector2.Checked = detalle.Sector2;
            txtSector2CJustif.Text = detalle.Sector2Justif;
            chkSector3.Checked = detalle.Sector3;
            txtSector3CJustif.Text = detalle.Sector3Justif;
            chkSector4.Checked = detalle.Sector4;
            txtSector4CJustif.Text = detalle.Sector4Justif;
            chkSector5.Checked = detalle.Sector5;
            txtSector5CJustif.Text = detalle.Sector5Justif;
            chkSector6.Checked = detalle.Sector6;
            txtSector6CJustif.Text = detalle.Sector6Justif;
            chkSector7.Checked = detalle.Sector7;
            txtSector7CJustif.Text = detalle.Sector7Justif;

            txtAnexoCJustifSna.Text = detalle.JustifSnaRegionales;

            if (detalle != null && !string.IsNullOrEmpty(detalle.DniPasaporte))
            {
                // Separamos lo que está unido en la base de datos (Ej: "DNI 38222222")
                string[] partes = detalle.DniPasaporte.Split(' ');

                if (partes.Length >= 2)
                {
                    // La primera parte selecciona el ComboBox (ej: "DNI")
                    cmbTipoDocumento.SelectedItem = partes[0];

                    // La segunda parte va al TextBox (ej: "38222222")
                    txtAnexoCDniPasaporte.Text = partes[1];
                }
                else
                {
                    // Por si acaso hay algún registro viejo que solo guardó el número
                    txtAnexoCDniPasaporte.Text = detalle.DniPasaporte;
                }
            }


        }
        private void btnVerDoc_Click(object sender, EventArgs e)
        {
            // Verificamos que la ruta no esté vacía y que el archivo exista físicamente en la PC
            if (!string.IsNullOrWhiteSpace(txtRutaArchivo.Text) && System.IO.File.Exists(txtRutaArchivo.Text))
            {
                try
                {
                    // Abre la foto o PDF con el programa predeterminado de Windows
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = txtRutaArchivo.Text,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay ningún archivo válido seleccionado o la ruta no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void label4_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarAnexoE_Click(object sender, EventArgs e)
        {
        }

        private void panelSeccion3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRutaArchivo_TextChanged(object sender, EventArgs e)
        {


        }

        
    }
}
