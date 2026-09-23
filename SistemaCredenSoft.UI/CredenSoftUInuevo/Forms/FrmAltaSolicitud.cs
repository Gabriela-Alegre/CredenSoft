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

                cmbUsuario.Items.Clear();
                string nombreCompleto = SesionActual.UsuarioLogueado.Nombre + " " + SesionActual.UsuarioLogueado.Apellido;
                cmbUsuario.Items.Add(nombreCompleto);
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
                        .Include(s => s.ArchivosAdjuntos) // Importante para traer los archivos
                        .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                    if (solicitud != null)
                    {
                        // 1. Datos generales de la solicitud
                        txtDescripcion.Text = solicitud.Descripcion;
                        dateTimeFecha.Value = solicitud.FechaSolicitud;
                        cmbTipoDeSolicitud.Text = solicitud.TipoSolicitud;

                        // Bloquear usuario y DNI en edición también por seguridad
                        cmbUsuario.Items.Clear();
                        cmbUsuario.Items.Add("Usuario del sistema");
                        cmbUsuario.SelectedIndex = 0;
                        cmbUsuario.Enabled = false;
                        txtDni.Enabled = false;

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

        // =====================================================
        // GUARDAR
        // =====================================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación inicial del tipo de solicitud
                if (cmbTipoDeSolicitud.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de solicitud.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return;
                }

                string tipoSeleccionado = cmbTipoDeSolicitud.Text.Trim();

                // =========================================================
                // MODO EDICIÓN (UPDATE)
                // =========================================================
                if (idSolicitudEditando > 0)
                {
                    using (var context = new CredenSoftContext())
                    {
                        // Buscamos la solicitud existente con su detalle
                        var solicitudExistente = context.Solicitudes
                            .Include(s => s.DetalleAnexoC) // Ajusta si es DetalleAnexoC o DetalleAnexoE según corresponda
                            .Include(s => s.ArchivosAdjuntos)
                            .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);
                            
                        if (solicitudExistente != null)
                        {
                            // Actualizamos datos principales de la solicitud
                            solicitudExistente.Descripcion = txtDescripcion.Text.Trim();
                            solicitudExistente.FechaSolicitud = dateTimeFecha.Value;

                            // 2. Gestionar el archivo adjunto en la edición
                            if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                            {
                                bool archivoYaExiste = solicitudExistente.ArchivosAdjuntos.Any(a => a.RutaArchivo == rutaArchivoSeleccionado);

                                if (!archivoYaExiste)
                                {
                                    // Si ya tenía archivos anteriores y querés que se reemplacen por el nuevo:
                                    if (solicitudExistente.ArchivosAdjuntos != null && solicitudExistente.ArchivosAdjuntos.Any())
                                    {
                                        context.Set<DocumentoAdjunto>().RemoveRange(solicitudExistente.ArchivosAdjuntos);
                                    }

                                    var nuevoAdjunto = new DocumentoAdjunto
                                    {
                                        IdSolicitud = solicitudExistente.IdSolicitud,
                                        NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado),
                                        RutaArchivo = rutaArchivoSeleccionado,
                                        TipoDocumento = "Respaldo"
                                    };

                                    context.Set<DocumentoAdjunto>().Add(nuevoAdjunto);
                                }
                            }

                            // Si es Anexo C, actualizamos sus campos
                            if (tipoSeleccionado.Contains("Anexo C") && solicitudExistente.DetalleAnexoC != null)
                            {
                                // Validaciones obligatorias
                                if (string.IsNullOrWhiteSpace(txtAnexoCAeropuerto.Text) ||
                                    string.IsNullOrWhiteSpace(txtAnexoCApellidos.Text) ||
                                    string.IsNullOrWhiteSpace(txtAnexoCDniPasaporte.Text))
                                {
                                    MessageBox.Show("Por favor, completa los campos obligatorios del Anexo C (*).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                // Extracción de RadioButtons
                                string grupoSanguineoSeleccionado = "";
                                if (rbtnGrupoA.Checked) grupoSanguineoSeleccionado = "A";
                                else if (rbtnGrupoB.Checked) grupoSanguineoSeleccionado = "B";
                                else if (rbtnGrupoAB.Checked) grupoSanguineoSeleccionado = "AB";
                                else if (rbtnGrupoO.Checked) grupoSanguineoSeleccionado = "O";

                                string factorRhSeleccionado = "";
                                if (rbtnFactorPositivo.Checked) factorRhSeleccionado = "Positivo";
                                else if (rbtnFactorNegativo.Checked) factorRhSeleccionado = "Negativo";

                                // Actualizar propiedades del detalle existente
                                solicitudExistente.DetalleAnexoC.Aeropuerto = txtAnexoCAeropuerto.Text.Trim();
                                solicitudExistente.DetalleAnexoC.NumeroNotaPermiso = txtAnexoCNotaPermiso.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Apellido = txtAnexoCApellidos.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Nombres = txtAnexoCNombres.Text.Trim();
                                solicitudExistente.DetalleAnexoC.DniPasaporte = txtAnexoCDniPasaporte.Text.Trim();
                                solicitudExistente.DetalleAnexoC.EstadoCivil = cmbAnexoCEstadoCivil.SelectedItem?.ToString() ?? "";
                                solicitudExistente.DetalleAnexoC.LugarNacimiento = txtAnexoCLugarNac.Text.Trim();
                                solicitudExistente.DetalleAnexoC.FechaNacimiento = dtpAnexoCFechaNac.Value;
                                solicitudExistente.DetalleAnexoC.CargoFuncion = txtAnexoCCargo.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Calle = txtAnexoCCalle.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Nro = txtAnexoCNro.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Depto = txtAnexoCDepto.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Cp = txtAnexoCCP.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Localidad = txtAnexoCLocalidad.Text.Trim();
                                solicitudExistente.DetalleAnexoC.TelParticular = txtAnexoCTelPart.Text.Trim();
                                solicitudExistente.DetalleAnexoC.TelLaboral = txtAnexoCTelLab.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Mail = txtAnexoCMail.Text.Trim();
                                solicitudExistente.DetalleAnexoC.GrupoSanguineo = grupoSanguineoSeleccionado;
                                solicitudExistente.DetalleAnexoC.FactorRh = factorRhSeleccionado;
                                solicitudExistente.DetalleAnexoC.EnfermedadesAlergias = txtAnexoCEnfermedades.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Socorrista = rbtnSocorristaSi.Checked;
                                solicitudExistente.DetalleAnexoC.Conductor = rbtnConductorSi.Checked;
                                solicitudExistente.DetalleAnexoC.Sector1 = chkSectorC1.Checked;
                                solicitudExistente.DetalleAnexoC.Sector1Justif = txtSector1CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector2 = chkSector2.Checked;
                                solicitudExistente.DetalleAnexoC.Sector2Justif = txtSector2CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector3 = chkSector3.Checked;
                                solicitudExistente.DetalleAnexoC.Sector3Justif = txtSector3CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector4 = chkSector4.Checked;
                                solicitudExistente.DetalleAnexoC.Sector4Justif = txtSector4CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector5 = chkSector5.Checked;
                                solicitudExistente.DetalleAnexoC.Sector5Justif = txtSector5CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector6 = chkSector6.Checked;
                                solicitudExistente.DetalleAnexoC.Sector6Justif = txtSector6CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.Sector7 = chkSector7.Checked;
                                solicitudExistente.DetalleAnexoC.Sector7Justif = txtSector7CJustif.Text.Trim();
                                solicitudExistente.DetalleAnexoC.JustifSnaRegionales = txtAnexoCJustifSna.Text.Trim();
                            }

                            // Guardamos los cambios del Update en Entity Framework
                            context.SaveChanges();
                        }
                    }

                    MessageBox.Show(
                        "¡Solicitud y Anexo actualizados correctamente!",
                        "CredenSoft",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // =========================================================
                    // MODO NUEVO (INSERT - EL CÓDIGO QUE YA TENÍAS)
                    // =========================================================
                    Solicitud nueva = new Solicitud
                    {
                        IdUsuario = SesionActual.UsuarioLogueado.IdUsuario,
                        TipoSolicitud = tipoSeleccionado,
                        Descripcion = txtDescripcion.Text.Trim(),
                        FechaSolicitud = dateTimeFecha.Value,
                        ArchivosAdjuntos = new List<DocumentoAdjunto>()
                    };

                    if (!string.IsNullOrEmpty(rutaArchivoSeleccionado))
                    {
                        var adjunto = new DocumentoAdjunto
                        {
                            NombreArchivo = System.IO.Path.GetFileName(rutaArchivoSeleccionado),
                            RutaArchivo = rutaArchivoSeleccionado,
                            TipoDocumento = "Respaldo"
                        };
                        nueva.ArchivosAdjuntos.Add(adjunto);
                    }

                    _solicitudService.CrearSolicitud(nueva);

                    using (var context = new CredenSoftContext())
                    {
                        if (tipoSeleccionado.Contains("Anexo C"))
                        {
                            if (string.IsNullOrWhiteSpace(txtAnexoCAeropuerto.Text) ||
                                string.IsNullOrWhiteSpace(txtAnexoCApellidos.Text) ||
                                string.IsNullOrWhiteSpace(txtAnexoCDniPasaporte.Text))
                            {
                                MessageBox.Show("Por favor, completa los campos obligatorios del Anexo C (*).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            string grupoSanguineoSeleccionado = "";
                            if (rbtnGrupoA.Checked) grupoSanguineoSeleccionado = "A";
                            else if (rbtnGrupoB.Checked) grupoSanguineoSeleccionado = "B";
                            else if (rbtnGrupoAB.Checked) grupoSanguineoSeleccionado = "AB";
                            else if (rbtnGrupoO.Checked) grupoSanguineoSeleccionado = "O";

                            string factorRhSeleccionado = "";
                            if (rbtnFactorPositivo.Checked) factorRhSeleccionado = "Positivo";
                            else if (rbtnFactorNegativo.Checked) factorRhSeleccionado = "Negativo";

                            DetalleAnexoC nuevoDetalleC = new DetalleAnexoC()
                            {
                                IdSolicitud = nueva.IdSolicitud,
                                Aeropuerto = txtAnexoCAeropuerto.Text.Trim(),
                                NumeroNotaPermiso = txtAnexoCNotaPermiso.Text.Trim(),
                                Apellido = txtAnexoCApellidos.Text.Trim(),
                                Nombres = txtAnexoCNombres.Text.Trim(),
                                DniPasaporte = txtAnexoCDniPasaporte.Text.Trim(),
                                EstadoCivil = cmbAnexoCEstadoCivil.SelectedItem?.ToString() ?? "",
                                LugarNacimiento = txtAnexoCLugarNac.Text.Trim(),
                                FechaNacimiento = dtpAnexoCFechaNac.Value,
                                CargoFuncion = txtAnexoCCargo.Text.Trim(),
                                Calle = txtAnexoCCalle.Text.Trim(),
                                Nro = txtAnexoCNro.Text.Trim(),
                                Depto = txtAnexoCDepto.Text.Trim(),
                                Cp = txtAnexoCCP.Text.Trim(),
                                Localidad = txtAnexoCLocalidad.Text.Trim(),
                                TelParticular = txtAnexoCTelPart.Text.Trim(),
                                TelLaboral = txtAnexoCTelLab.Text.Trim(),
                                Mail = txtAnexoCMail.Text.Trim(),
                                GrupoSanguineo = grupoSanguineoSeleccionado,
                                FactorRh = factorRhSeleccionado,
                                EnfermedadesAlergias = txtAnexoCEnfermedades.Text.Trim(),
                                Socorrista = rbtnSocorristaSi.Checked,
                                Conductor = rbtnConductorSi.Checked,
                                Sector1 = chkSectorC1.Checked,
                                Sector1Justif = txtSector1CJustif.Text.Trim(),
                                Sector2 = chkSector2.Checked,
                                Sector2Justif = txtSector2CJustif.Text.Trim(),
                                Sector3 = chkSector3.Checked,
                                Sector3Justif = txtSector3CJustif.Text.Trim(),
                                Sector4 = chkSector4.Checked,
                                Sector4Justif = txtSector4CJustif.Text.Trim(),
                                Sector5 = chkSector5.Checked,
                                Sector5Justif = txtSector5CJustif.Text.Trim(),
                                Sector6 = chkSector6.Checked,
                                Sector6Justif = txtSector6CJustif.Text.Trim(),
                                Sector7 = chkSector7.Checked,
                                Sector7Justif = txtSector7CJustif.Text.Trim(),
                                JustifSnaRegionales = txtAnexoCJustifSna.Text.Trim()
                            };

                            context.Set<DetalleAnexoC>().Add(nuevoDetalleC);
                            context.SaveChanges();
                        }
                        // (Aquí puedes dejar también tu lógica de Anexo E si la usas para insertar)
                    }

                    MessageBox.Show(
                        "¡Solicitud y Anexo guardados correctamente!",
                        "CredenSoft",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string errorReal = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(
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