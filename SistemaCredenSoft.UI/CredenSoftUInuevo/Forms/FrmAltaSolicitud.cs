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

            ConfigurarEventosSectores();
            // Ocultar ambos paneles al arrancar el formulario
            panelAnexoC.Visible = false;
            panelAnexoE.Visible = false;

            // Llamamos también al método de los sectores que armamos antes
            ConfigurarEventosSectores();
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
            try
            {
                // 1. Validación rápida de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtAnexoCAeropuerto.Text) ||
                    string.IsNullOrWhiteSpace(txtAnexoCApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtAnexoCDniPasaporte.Text))
                {
                    MessageBox.Show("Por favor, completa los campos obligatorios (*).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Validar y extraer el Grupo Sanguíneo de forma segura
                string grupoSanguineoSeleccionado = "";
                if (rbtnGrupoA.Checked) grupoSanguineoSeleccionado = "A";
                else if (rbtnGrupoB.Checked) grupoSanguineoSeleccionado = "B";
                else if (rbtnGrupoAB.Checked) grupoSanguineoSeleccionado = "AB";
                else if (rbtnGrupoO.Checked) grupoSanguineoSeleccionado = "O"; // (Asegúrate de que el radio de la O se llame así)

                // 2. Validar y extraer el Factor RH de forma segura
                string factorRhSeleccionado = "";
                if (rbtnFactorPositivo.Checked) factorRhSeleccionado = "Positivo";
                else if (rbtnFactorNegativo.Checked) factorRhSeleccionado = "Negativo"; // (Asegúrate de que el radio negativo se llame así)
 

                // =====================================================
                // OBJETO NUEVO DETALLE ANEXO C
                // =====================================================


                // 2. Mapeo con los nombres exactos de tu clase DetalleAnexoC
                DetalleAnexoC nuevoDetalle = new DetalleAnexoC()
                {
                    IdSolicitud = 1, // Reemplaza esto con el ID de la solicitud activa de tu cabecera
                    Aeropuerto = txtAnexoCAeropuerto.Text.Trim(),
                    NumeroNotaPermiso = txtAnexoCNotaPermiso.Text.Trim(),
                    Apellido = txtAnexoCApellidos.Text.Trim(),
                    Nombres = txtAnexoCNombres.Text.Trim(),
                    DniPasaporte = txtAnexoCDniPasaporte.Text.Trim(),
                    EstadoCivil = cmbAnexoCEstadoCivil.SelectedItem?.ToString() ?? "",
                    LugarNacimiento = txtAnexoCLugarNac.Text.Trim(),
                    FechaNacimiento = dtpAnexoCFechaNac.Value,
                    CargoFuncion = txtAnexoCCargo.Text.Trim(),

                    // Domicilio
                    Calle = txtAnexoCCalle.Text.Trim(),
                    Nro = txtAnexoCNro.Text.Trim(),
                    Depto = txtAnexoCDepto.Text.Trim(),
                    Cp = txtAnexoCCP.Text.Trim(),
                    Localidad = txtAnexoCLocalidad.Text.Trim(),

                    // Contacto
                    TelParticular = txtAnexoCTelPart.Text.Trim(),
                    TelLaboral = txtAnexoCTelLab.Text.Trim(),
                    Mail = txtAnexoCMail.Text.Trim(),

                    // Emergencia (OACI Doc. 8973)

                    GrupoSanguineo = grupoSanguineoSeleccionado,
                    FactorRh = factorRhSeleccionado,
                    EnfermedadesAlergias = txtAnexoCEnfermedades.Text.Trim(),


                    // Roles
                    Socorrista = rbtnSocorristaSi.Checked,
                    Conductor = rbtnConductorSi.Checked,

                    // Sectores
                    Sector1 = chkSectorC1.Checked,
                    Sector1Justif = txtSector1CJustif.Text.Trim(),
                    Sector2 = chkSectorC2.Checked,
                    Sector2Justif = txtSector2CJustif.Text.Trim(),
                    Sector3 = chkSectorC3.Checked,
                    Sector3Justif = txtSector3CJustif.Text.Trim(),
                    Sector4 = chkSectorC4.Checked,
                    Sector4Justif = txtSector4CJustif.Text.Trim(),
                    Sector5 = chkSectorC5.Checked,
                    Sector5Justif = txtSector5CJustif.Text.Trim(),
                    Sector6 = chkSectorC6.Checked,
                    Sector6Justif = txtSector6CJustif.Text.Trim(),
                    Sector7 = chkSectorC7.Checked,
                    Sector7Justif = txtSector7CJustif.Text.Trim(),
                    JustifSnaRegionales = txtAnexoCJustifSna.Text.Trim()
                };

                // 3. Persistencia con Entity Framework Core
                using (var context = new CredenSoftContext()) // Reemplaza "TuDbContext" por el nombre de tu contexto de BD
                {
                    context.Set<DetalleAnexoC>().Add(nuevoDetalle);
                    context.SaveChanges();
                }

                MessageBox.Show("¡Los datos del Anexo C se guardaron con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //GUARDAR ANEXO E
            try
            {
                // 1. Validación de campos obligatorios generales
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

                // 3. Si el usuario seleccionó un archivo, lo agregamos a la lista
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

                // 4. Llamada al servicio para persistir la Solicitud principal
                // (Al hacer esto, Entity Framework genera automáticamente el ID y se lo asigna a "nueva.IdSolicitud")
                _solicitudService.CrearSolicitud(nueva);

                // 5. Ahora guardamos el DETALLE correspondiente (Anexo C o Anexo E) usando ese ID generado
                string tipoSeleccionado = cmbTipoDeSolicitud.Text.Trim();

                using (var context = new CredenSoftContext())
                {
                    if (tipoSeleccionado.Contains("Anexo C"))
                    {
                        // Validaciones previas para Anexo C si las necesitas...

                        DetalleAnexoC nuevoDetalleC = new DetalleAnexoC()
                        {
                            IdSolicitud = nueva.IdSolicitud, // <-- ¡Acá usamos el ID real!
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
                            // ... (Agrega aquí el resto de campos de tu Anexo C tal como los tenías)
                        };

                        context.Set<DetalleAnexoC>().Add(nuevoDetalleC);
                        context.SaveChanges();
                    }
                    else if (tipoSeleccionado.Contains("Anexo E"))
                    {
                        // Validación rápida para Anexo E (puedes agregar las que necesites)
                        if (string.IsNullOrWhiteSpace(txtAnexoEDias.Text))
                        {
                            MessageBox.Show("Por favor, completa los días autorizados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Extracción de datos para Anexo E
                        DetalleAnexoE nuevoDetalleE = new DetalleAnexoE()
                        {
                            IdSolicitud = nueva.IdSolicitud, // <-- ¡Acá usamos el ID real de la solicitud recién creada!

                            DiasAutorizados = txtAnexoEDias.Text.Trim(),
                            HorariosDesde = txtAnexoEHoraDesde.Text.Trim(),
                            HorariosHasta = txtAnexoEHoraHasta.Text.Trim(),
                            Tareas = txtAnexoETareas.Text.Trim(),

                            // --- SOLICITANTE 1 ---
                            Sol1ApeNom = txtAnexoESol1ApeNom.Text.Trim(),
                            Sol1TipoDoc = cmbAnexoESol1TipoDoc.Text.Trim(),
                            Sol1DocNro = txtAnexoESol1DocNro.Text.Trim(),
                            Sol1Cargo = txtAnexoESol1Cargo.Text.Trim(),

                            // --- SOLICITANTE 2 ---
                            Sol2ApeNom = txtAnexoESol2ApeNom.Text.Trim(),
                            Sol2TipoDoc = cmbAnexoESol2TipoDoc.Text.Trim(),
                            Sol2DocNro = txtAnexoESol2DocNro.Text.Trim(),
                            Sol2Cargo = txtAnexoESol2Cargo.Text.Trim(),

                            // --- SOLICITANTE 3 ---
                            Sol3ApeNom = txtAnexoESol3ApeNom.Text.Trim(),
                            Sol3TipoDoc = cmbAnexoESol3TipoDoc.Text.Trim(),
                            Sol3DocNro = textBox1.Text.Trim(),
                            Sol3Cargo = txtAnexoESol3Cargo.Text.Trim(),

                            // --- SOLICITANTE 4 ---
                            Sol4ApeNom = txtAnexoESol4ApeNom.Text.Trim(),
                            Sol4TipoDoc = cmbAnexoESol4TipoDoc.Text.Trim(),
                            Sol4DocNro = txtAnexoESol4DocNro.Text.Trim(),
                            Sol4Cargo = txtAnexoESol4Cargo.Text.Trim(),

                            // --- SOLICITANTE 5 ---
                            Sol5ApeNom = txtAnexoESol5ApeNom.Text.Trim(),
                            Sol5TipoDoc = comboBox1.Text.Trim(),
                            Sol5DocNro = txtAnexoESol5DocNro.Text.Trim(),
                            Sol5Cargo = txtAnexoESol5Cargo.Text.Trim(),

                            // --- SECTORES (1 al 7) ---
                            Sector1 = chkSector1.Checked,
                            JustificacionSector1 = txtSector1Justif.Text.Trim(),
                            Sector2 = chkSector2.Checked,
                            JustificacionSector2 = txtSector2Justif.Text.Trim(),
                            Sector3 = chkSector3.Checked,
                            JustificacionSector3 = txtSector3Justif.Text.Trim(),
                            Sector4 = chkSector4.Checked,
                            JustificacionSector4 = txtSector4Justif.Text.Trim(),
                            Sector5 = chkSector5.Checked,
                            JustificacionSector5 = txtSector5Justif.Text.Trim(),
                            Sector6 = chkSector6.Checked,
                            JustificacionSector6 = txtSector6Justif.Text.Trim(),
                            Sector7 = chkSector7.Checked,
                            JustificacionSector7 = txtSector7Justif.Text.Trim(),

                            // --- ACOMPAÑANTES / RESPONSABLES ---
                            ResponsableApNombre = txtAnexoEResp1ApeNom.Text.Trim(),
                            ResponsableNroPermiso = txtAnexoEResp1Permiso.Text.Trim(),
                            ResponsableCargo = txtAnexoEResp1Cargo.Text.Trim(),

                            Resp2ApeNom = txtAnexoEResp2ApeNom.Text.Trim(),
                            Resp2NroPermiso = txtAnexoEResp2Permiso.Text.Trim(),
                            Resp2Cargo = txtAnexoEResp2Cargo.Text.Trim()
                        };

                        context.Set<DetalleAnexoE>().Add(nuevoDetalleE);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show(
                    "¡Solicitud y Anexo guardados correctamente!",
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
            }
            else if (seleccion.Contains("Anexo E"))
            {
                panelAnexoC.Visible = false;
                panelAnexoE.Visible = true;
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