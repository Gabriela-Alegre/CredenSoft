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
        // SERVICIO
        // =====================================================
        private SolicitudService _solicitudService = new SolicitudService();

        private int idSolicitudEditando = 0; // Si es 0, es nuevo. Si tiene valor, es edición.

        // 1. Constructor normal (para cuando das de alta desde cero)
        public FrmAltaSolicitud()
        {
            InitializeComponent();
        }

        // 2. Constructor para cuando quieres EDITAR (recibe el ID)
        public FrmAltaSolicitud(int idSolicitud)
        {
            InitializeComponent();
            idSolicitudEditando = idSolicitud;

            // Cambiar el título del formulario para que el usuario sepa que está editando
            this.Text = "Modificar Solicitud y Anexo C";
            btnGuardar.Text = "Actualizar Cambios"; // Cambias el texto del botón si quieres
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

            ConfigurarEventosSectores();
            // Ocultar ambos paneles al arrancar el formulario
            panelAnexoC.Visible = false;
            panelAnexoE.Visible = false;

            // Llamamos también al método de los sectores que armamos antes
            ConfigurarEventosSectores();


            // ==========================================
            // AQUÍ AGREGAS LA LÓGICA DE EDICIÓN
            // ==========================================
            if (idSolicitudEditando > 0)
            {
                using (var context = new CredenSoftContext())
                {
                    // Buscamos la solicitud y su detalle de Anexo C asociado
                    var solicitud = context.Solicitudes
                        .Include(s => s.DetalleAnexoC) // Asegúrate de tener la relación mapeada
                        .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                    if (solicitud != null)
                    {
                        // 1. Datos generales de la solicitud
                        txtDescripcion.Text = solicitud.Descripcion;
                        dateTimeFecha.Value = solicitud.FechaSolicitud;
                        cmbTipoDeSolicitud.Text = solicitud.TipoSolicitud;

                        // 2. Si es Anexo C, mostramos el panel y rellenamos cada control
                        if (solicitud.TipoSolicitud.Contains("Anexo C") && solicitud.DetalleAnexoC != null)
                        {
                            panelAnexoC.Visible = true;

                            // Datos principales del Anexo C
                            txtAnexoCAeropuerto.Text = solicitud.DetalleAnexoC.Aeropuerto;
                            txtAnexoCNotaPermiso.Text = solicitud.DetalleAnexoC.NumeroNotaPermiso;
                            txtAnexoCApellidos.Text = solicitud.DetalleAnexoC.Apellido;
                            txtAnexoCNombres.Text = solicitud.DetalleAnexoC.Nombres;
                            txtAnexoCDniPasaporte.Text = solicitud.DetalleAnexoC.DniPasaporte;
                            cmbAnexoCEstadoCivil.Text = solicitud.DetalleAnexoC.EstadoCivil;
                            txtAnexoCLugarNac.Text = solicitud.DetalleAnexoC.LugarNacimiento;
                            dtpAnexoCFechaNac.Value = solicitud.DetalleAnexoC.FechaNacimiento;
                            txtAnexoCCargo.Text = solicitud.DetalleAnexoC.CargoFuncion;

                            // Domicilio
                            txtAnexoCCalle.Text = solicitud.DetalleAnexoC.Calle;
                            txtAnexoCNro.Text = solicitud.DetalleAnexoC.Nro;
                            txtAnexoCDepto.Text = solicitud.DetalleAnexoC.Depto;
                            txtAnexoCCP.Text = solicitud.DetalleAnexoC.Cp;
                            txtAnexoCLocalidad.Text = solicitud.DetalleAnexoC.Localidad;

                            // Contacto
                            txtAnexoCTelPart.Text = solicitud.DetalleAnexoC.TelParticular;
                            txtAnexoCTelLab.Text = solicitud.DetalleAnexoC.TelLaboral;
                            txtAnexoCMail.Text = solicitud.DetalleAnexoC.Mail;

                            // Grupo Sanguíneo
                            if (solicitud.DetalleAnexoC.GrupoSanguineo == "A") rbtnGrupoA.Checked = true;
                            else if (solicitud.DetalleAnexoC.GrupoSanguineo == "B") rbtnGrupoB.Checked = true;
                            else if (solicitud.DetalleAnexoC.GrupoSanguineo == "AB") rbtnGrupoAB.Checked = true;
                            else if (solicitud.DetalleAnexoC.GrupoSanguineo == "O") rbtnGrupoO.Checked = true;

                            // Factor RH
                            if (solicitud.DetalleAnexoC.FactorRh == "Positivo") rbtnFactorPositivo.Checked = true;
                            else if (solicitud.DetalleAnexoC.FactorRh == "Negativo") rbtnFactorNegativo.Checked = true;

                            // Enfermedades y Alergias
                            txtAnexoCEnfermedades.Text = solicitud.DetalleAnexoC.EnfermedadesAlergias;

                            // Roles (Conductor / Socorrista)
                            rbtnConductorSi.Checked = solicitud.DetalleAnexoC.Conductor;
                            rbtnConductorNo.Checked = !solicitud.DetalleAnexoC.Conductor;
                            rbtnSocorristaSi.Checked = solicitud.DetalleAnexoC.Socorrista;
                            rbtnSocorristaNo.Checked = !solicitud.DetalleAnexoC.Socorrista;

                            // Sectores (1 al 7) y sus justificaciones
                            chkSectorC1.Checked = solicitud.DetalleAnexoC.Sector1;
                            txtSector1CJustif.Text = solicitud.DetalleAnexoC.Sector1Justif;

                            chkSector2.Checked = solicitud.DetalleAnexoC.Sector2;
                            txtSector2CJustif.Text = solicitud.DetalleAnexoC.Sector2Justif;

                            chkSector3.Checked = solicitud.DetalleAnexoC.Sector3;
                            txtSector3CJustif.Text = solicitud.DetalleAnexoC.Sector3Justif;

                            chkSector4.Checked = solicitud.DetalleAnexoC.Sector4;
                            txtSector4CJustif.Text = solicitud.DetalleAnexoC.Sector4Justif;

                            chkSector5.Checked = solicitud.DetalleAnexoC.Sector5;
                            txtSector5CJustif.Text = solicitud.DetalleAnexoC.Sector5Justif;

                            chkSector6.Checked = solicitud.DetalleAnexoC.Sector6;
                            txtSector6CJustif.Text = solicitud.DetalleAnexoC.Sector6Justif;

                            chkSector7.Checked = solicitud.DetalleAnexoC.Sector7;
                            txtSector7CJustif.Text = solicitud.DetalleAnexoC.Sector7Justif;

                            txtAnexoCJustifSna.Text = solicitud.DetalleAnexoC.JustifSnaRegionales;
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
                            .FirstOrDefault(s => s.IdSolicitud == idSolicitudEditando);

                        if (solicitudExistente != null)
                        {
                            // Actualizamos datos principales de la solicitud
                            solicitudExistente.Descripcion = txtDescripcion.Text.Trim();
                            solicitudExistente.FechaSolicitud = dateTimeFecha.Value;

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

        private void cmbTipoDeSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenemos el texto de lo que el usuario seleccionó en el ComboBox
            string seleccion = cmbTipoDeSolicitud.Text.Trim();

            // Validamos qué texto contiene para mostrar el panel correcto
            if (seleccion.Contains("Anexo C"))
            {
                panelAnexoC.Visible = true;
                panelAnexoE.Visible = false;
                panelAnexoC.BringToFront();
            }
            else if (seleccion.Contains("Anexo E"))
            {
                panelAnexoC.Visible = false;
                panelAnexoE.Visible = true;
                panelAnexoE.BringToFront();
            }
            else
            {
                // Si no selecciona nada válido, se ocultan ambos
                panelAnexoC.Visible = false;
                panelAnexoE.Visible = false;
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
    }
}