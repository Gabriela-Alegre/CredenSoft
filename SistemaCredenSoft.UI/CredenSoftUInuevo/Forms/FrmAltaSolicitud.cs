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
        private string rutaArchivoSeleccionado = string.Empty;

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

            // Bloqueamos los campos principales
            txtDescripcion.ReadOnly = true;
            dateTimeFecha.Enabled = false;
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
                        var archivoExistente = solicitud.ArchivosAdjuntos.FirstOrDefault();
                        if (archivoExistente != null)
                        {
                            lblArchivoSeleccionado.Text = archivoExistente.NombreArchivo;
                            lblArchivoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
                            rutaArchivoSeleccionado = archivoExistente.RutaArchivo; // <--- Acá guardamos la ruta correctamente
                        }
                        else
                        {
                            lblArchivoSeleccionado.Text = "Ningún archivo seleccionado";
                            lblArchivoSeleccionado.ForeColor = System.Drawing.Color.Gray;
                        }

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
        private bool ValidarFormulario()
        {
            // 1. Apellido y Nombre
            if (string.IsNullOrWhiteSpace(txtAnexoCApellidos.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCApellidos.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAnexoCNombres.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCNombres.Focus();
                return false;
            }

            // 2. Estado Civil (Validar que se haya seleccionado un elemento en el ComboBox)
            if (cmbAnexoCEstadoCivil.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbAnexoCEstadoCivil.Text))
            {
                MessageBox.Show("Debe seleccionar un Estado Civil.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAnexoCEstadoCivil.Focus();
                return false;
            }

            // 3. Domicilio (Validar los campos principales: Calle, Número, Localidad, etc., si son obligatorios)
            if (string.IsNullOrWhiteSpace(txtAnexoCCalle.Text) ||
                string.IsNullOrWhiteSpace(txtAnexoCNro.Text) ||
                string.IsNullOrWhiteSpace(txtAnexoCLocalidad.Text))
            {
                MessageBox.Show("Los campos Calle, Número y Localidad del domicilio son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCCalle.Focus();
                return false;
            }
            //4. Cargo y Función 
            if (string.IsNullOrWhiteSpace(txtAnexoCCargo.Text))
            {
                MessageBox.Show("El campo Cargo/Función es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCCargo.Focus();
                return false;
            }

            //5.Anual/nro permiso/nota
            if (string.IsNullOrWhiteSpace(txtAnexoCNotaPermiso.Text))
            {
                MessageBox.Show("El campo Anual/Nota/nro Permiso es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCNotaPermiso.Focus();
                return false;
            }
            //6 Aeropuerto
            if (string.IsNullOrWhiteSpace(txtAnexoCAeropuerto.Text))
            {
                MessageBox.Show("El campo Aeropuerto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnexoCAeropuerto.Focus();
                return false;
            }

            // 4. Justificaciones de Sectores (Si el checkbox está marcado, la justificación NO debe estar vacía)
            if (chkSectorC1.Checked && string.IsNullOrWhiteSpace(txtSector1CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 1.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector1CJustif.Focus();
                return false;
            }
            if (chkSectorC2.Checked && string.IsNullOrWhiteSpace(txtSector2CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 2.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector2CJustif.Focus();
                return false;
            }
            if (chkSectorC3.Checked && string.IsNullOrWhiteSpace(txtSector3CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 3.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector3CJustif.Focus();
                return false;
            }
            if (chkSectorC4.Checked && string.IsNullOrWhiteSpace(txtSector4CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 4.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector4CJustif.Focus();
                return false;
            }
            if (chkSectorC5.Checked && string.IsNullOrWhiteSpace(txtSector5CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 5.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector5CJustif.Focus();
                return false;
            }
            if (chkSectorC6.Checked && string.IsNullOrWhiteSpace(txtSector6CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 6.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector6CJustif.Focus();
                return false;
            }
            if (chkSectorC7.Checked && string.IsNullOrWhiteSpace(txtSector7CJustif.Text))
            {
                MessageBox.Show("Debe ingresar la justificación para el Sector 7.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSector7CJustif.Focus();
                return false;
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
                            if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                            {
                                if (solicitudExistente.ArchivosAdjuntos == null)
                                {
                                    solicitudExistente.ArchivosAdjuntos = new List<DocumentoAdjunto>();
                                }

                                var archivoExistente = solicitudExistente.ArchivosAdjuntos.FirstOrDefault();

                                if (archivoExistente != null)
                                {
                                    archivoExistente.NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado);
                                    archivoExistente.RutaArchivo = rutaArchivoSeleccionado;
                                    context.Entry(archivoExistente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                }
                                else
                                {
                                    context.Set<DocumentoAdjunto>().Add(new DocumentoAdjunto
                                    {
                                        IdSolicitud = solicitudExistente.IdSolicitud,
                                        NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado),
                                        RutaArchivo = rutaArchivoSeleccionado
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
                        if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                        {
                            nuevaSolicitud.ArchivosAdjuntos.Add(new DocumentoAdjunto
                            {
                                NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado),
                                RutaArchivo = rutaArchivoSeleccionado
                            });
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

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. Guardamos la ruta absoluta del archivo elegido en la variable global
                    rutaArchivoSeleccionado = openFileDialog.FileName;

                    // 2. Actualizamos el Label (lo que marqué en azul) para que muestre solo el nombre del archivo
                    lblArchivoSeleccionado.Text = System.IO.Path.GetFileName(rutaArchivoSeleccionado);
                    lblArchivoSeleccionado.ForeColor = System.Drawing.Color.DarkGreen; // Opcional para que se vea verdecito de éxito
                    txtRutaArchivo.Text = rutaArchivoSeleccionado;
                }
            }
        }

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
    }
}