using DataEF;
using Microsoft.EntityFrameworkCore;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmSolicitud : Form
    {
        // =====================================================
        // SERVICIO DE SOLICITUDES
        // =====================================================

        SolicitudService _solicitudService = new SolicitudService();
        // NUEVAS VARIABLES DE SESIÓN
        private string _rolUsuario;
        private int _idUsuarioLogueado;


        public FrmSolicitud(string rolUsuario, int idUsuarioLogueado)
        {
            InitializeComponent();
            _rolUsuario = rolUsuario;
            _idUsuarioLogueado = idUsuarioLogueado;
            dgvSolicitudes.CellPainting += dgvSolicitudes_CellPainting;

            ConfigurarPropiedadesIniciales();
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

            this.Activated += FrmSolicitud_Activated;
        }
        // (Opcional) Constructor vacio por si en alguna parte vieja se llama sin parámetros
        public FrmSolicitud() : this("Agente", 1) { }


        private void ConfigurarPropiedadesIniciales()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 500);
            this.MinimumSize = new Size(900, 650);

            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.MultiSelect = false;

            dgvSolicitudes.RowTemplate.Height = 32;
            dgvSolicitudes.ColumnHeadersHeight = 38;
            dgvSolicitudes.RowTemplate.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            this.Activated += FrmSolicitud_Activated;
        }


        // =====================================================
        // CARGA DEL FORMULARIO
        // =====================================================

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            dgvSolicitudes.CellFormatting += dgvSolicitudes_CellFormatting;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;

            // APLICAR RESTRICCIONES VISUALES SEGÚN EL ROL
            ConfigurarInterfazSegunRol();

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            CargarGrilla();
            // Conectamos el evento TextChanged por código para asegurarnos de que funcione al instante
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged; // <--- ¡Acá lo conectás!

        }

        // =====================================================
        // CONFIGURAR INTERFAZ SEGUN ROL
        // =====================================================
        private void ConfigurarInterfazSegunRol()
        {
            if (_rolUsuario == "Agente")
            {
                btnEliminar.Visible = false;
                txtBuscarDni.Visible = false;
                lblBuscarDni.Visible = false;
                btnBuscarDni.Visible = false;

                if (label3 != null && lblBuscarDni != null)
                {
                    label3.Top = lblBuscarDni.Top;
                }
                if (cmbEstado != null && txtBuscarDni != null)
                {
                    cmbEstado.Top = txtBuscarDni.Top;
                }
            }
            else if (_rolUsuario == "Administrador Central")
            {
                btnNueva.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                if (btnVer != null && btnNueva != null)
                {
                    btnVer.Left = btnNueva.Left;
                }

                // =====================================================
                // 👉 PASO 1: LIMITAR LAS OPCIONES DEL COMBOBOX AQUÍ
                // =====================================================
                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("Todos");
                cmbEstado.Items.Add("Pendiente de revisión");
                cmbEstado.Items.Add("Aprobado");
                cmbEstado.Items.Add("Rechazado");
                cmbEstado.SelectedIndex = 0;
            }
            else if (_rolUsuario == "Administrador Local")
            {
                btnNueva.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
            }
        }

        private void FrmSolicitud_Activated(object sender, EventArgs e)
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
                // 1. Limpiamos el origen de datos para evitar duplicación de columnas
                dgvSolicitudes.DataSource = null;
                // FILTRO SEGÚN EL ROL:
                if (_rolUsuario == "Agente")
                {
                    // El agente solo ve sus propias solicitudes activas por defecto
                    var misSolicitudes = _solicitudService.ObtenerSolicitudesPorUsuario(_idUsuarioLogueado);
                    dgvSolicitudes.DataSource = misSolicitudes
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                else
                {
                    // Lógica para administradores
                    var todas = _solicitudService.ObtenerTodas();

                    if (_rolUsuario == "Administrador Central")
                    {
                        // El Admin Central SOLO ve: Pendiente de revisión, Aprobado y Rechazado (Excluye Pendiente e Inactivo)
                        dgvSolicitudes.DataSource = todas
                            .Where(s => s.Estado != null &&
                                        (s.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase) ||
                                         s.Estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                                         s.Estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase)))
                            .ToList();
                    }
                    else
                    {
                        // Administrador Local ve todas excepto las inactivas
                        dgvSolicitudes.DataSource = todas
                            .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                }

                // APLICAR RESTRICCIONES VISUALES SEGÚN EL ROL
                ConfigurarInterfazSegunRol();

                if (cmbEstado.Items.Count > 0)
                {
                    cmbEstado.SelectedIndex = 0;
                }

                // 2. Ocultar columnas técnicas que no deben verse
                if (dgvSolicitudes.Columns["IdSolicitud"] != null)
                    dgvSolicitudes.Columns["IdSolicitud"].Visible = false;

                if (dgvSolicitudes.Columns["IdUsuario"] != null)
                    dgvSolicitudes.Columns["IdUsuario"].Visible = false;

                if (dgvSolicitudes.Columns["DetalleAnexoC"] != null)
                    dgvSolicitudes.Columns["DetalleAnexoC"].Visible = false;

                if (dgvSolicitudes.Columns["DetalleAnexoE"] != null)
                    dgvSolicitudes.Columns["DetalleAnexoE"].Visible = false;

                if (dgvSolicitudes.Columns["ArchivosAdjuntos"] != null)
                    dgvSolicitudes.Columns["ArchivosAdjuntos"].Visible = false;

                if (dgvSolicitudes.Columns["MotivoRechazo"] != null)
                    dgvSolicitudes.Columns["MotivoRechazo"].Visible = true;
                

                // 3. Crear la columna DNI personalizada solo si no existe previamente
                if (!dgvSolicitudes.Columns.Contains("DniUsuario"))
                {
                    DataGridViewTextBoxColumn colDni = new DataGridViewTextBoxColumn();
                    colDni.Name = "DniUsuario";
                    colDni.HeaderText = "DNI";
                    dgvSolicitudes.Columns.Add(colDni);
                }

                // NUEVO: Crear la columna para la ruta del archivo adjunto
                if (!dgvSolicitudes.Columns.Contains("RutaArchivoColumna"))
                {
                    DataGridViewTextBoxColumn colArchivo = new DataGridViewTextBoxColumn();
                    colArchivo.Name = "RutaArchivoColumna";
                    colArchivo.HeaderText = "Archivo Adjunto";
                    dgvSolicitudes.Columns.Add(colArchivo);
                }

                // 4. Configurar Títulos de las columnas visibles
                if (dgvSolicitudes.Columns["Usuario"] != null)
                    dgvSolicitudes.Columns["Usuario"].HeaderText = "Titular";

                if (dgvSolicitudes.Columns["TipoSolicitud"] != null)
                    dgvSolicitudes.Columns["TipoSolicitud"].HeaderText = "Tipo de Trámite";

                if (dgvSolicitudes.Columns["FechaSolicitud"] != null)
                    dgvSolicitudes.Columns["FechaSolicitud"].HeaderText = "Fecha de Solicitud";

                if (dgvSolicitudes.Columns["Descripcion"] != null)
                    dgvSolicitudes.Columns["Descripcion"].HeaderText = "Motivo / Descripción";

                if (dgvSolicitudes.Columns["Estado"] != null)
                    dgvSolicitudes.Columns["Estado"].HeaderText = "Estado";

                if (dgvSolicitudes.Columns["RutaArchivoColumna"] != null)
                    dgvSolicitudes.Columns["RutaArchivoColumna"].HeaderText = "Documento Adjunto";

                if (dgvSolicitudes.Columns["MotivoRechazo"] != null)
                    dgvSolicitudes.Columns["MotivoRechazo"].HeaderText = "Motivo Rechazo";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar solicitudes: " + ex.Message,
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // =====================================================
            // BOTÓN "ENVIAR A REVISIÓN" (EXCLUSIVO ADMIN LOCAL)
            // =====================================================
            if (_rolUsuario == "Administrador Local")
            {
                if (!dgvSolicitudes.Columns.Contains("btnEnviarRevisionCol"))
                {
                    DataGridViewButtonColumn btnEnviar = new DataGridViewButtonColumn();
                    btnEnviar.Name = "btnEnviarRevisionCol";
                    btnEnviar.HeaderText = "Pases / Revisiones";
                    btnEnviar.Text = "Enviar a Revisión";
                    btnEnviar.UseColumnTextForButtonValue = true;
                    btnEnviar.FlatStyle = FlatStyle.Flat;

                    dgvSolicitudes.Columns.Add(btnEnviar);
                }
            }
            else
            {
                if (dgvSolicitudes.Columns.Contains("btnEnviarRevisionCol"))
                {
                    dgvSolicitudes.Columns["btnEnviarRevisionCol"].Visible = false;
                }
            }

            // =====================================================
            // BOTONES "APROBAR" Y "RECHAZAR" (EXCLUSIVO ADMIN CENTRAL)
            // =====================================================
            if (_rolUsuario == "Administrador Central")
            {
                if (!dgvSolicitudes.Columns.Contains("btnAprobarCol"))
                {
                    DataGridViewButtonColumn btnAprobar = new DataGridViewButtonColumn();
                    btnAprobar.Name = "btnAprobarCol";
                    btnAprobar.HeaderText = "Acciones Centrales";
                    btnAprobar.Text = "Aprobar";
                    btnAprobar.UseColumnTextForButtonValue = true;
                    dgvSolicitudes.Columns.Add(btnAprobar);
                }

                if (!dgvSolicitudes.Columns.Contains("btnRechazarCol"))
                {
                    DataGridViewButtonColumn btnRechazar = new DataGridViewButtonColumn();
                    btnRechazar.Name = "btnRechazarCol";
                    btnRechazar.HeaderText = "Acciones Centrales";
                    btnRechazar.Text = "Rechazar";
                    btnRechazar.UseColumnTextForButtonValue = true;
                    dgvSolicitudes.Columns.Add(btnRechazar);
                }
            }
            else
            {
                if (dgvSolicitudes.Columns.Contains("btnAprobarCol"))
                    dgvSolicitudes.Columns["btnAprobarCol"].Visible = false;
                if (dgvSolicitudes.Columns.Contains("btnRechazarCol"))
                    dgvSolicitudes.Columns["btnRechazarCol"].Visible = false;
            }

            // =====================================================
            // 👉 LLAMADA ÚNICA AL MÉTODO DE ORDENAMIENTO
            // =====================================================
            OrdenarColumnas();
        }

        private void dgvSolicitudes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var solicitud = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as ModelsEntidades.Solicitud;
            if (solicitud == null) return;

            string nombreColumna = dgvSolicitudes.Columns[e.ColumnIndex].Name; // Asegúrate de mantener tu nombre de grilla 'dgvSolicitudes'

            // 1. Validaciones exclusivas donde interviene el Usuario (con su propia protección de nulos)
            if (solicitud.Usuario != null)
            {
                // Muestra Nombre y Apellido en la columna Titular
                if (nombreColumna == "Usuario")
                {
                    e.Value = solicitud.Usuario.Nombre + " " + solicitud.Usuario.Apellido;
                    e.FormattingApplied = true;
                }

                // Muestra el DNI de la base de datos en la columna creada
                if (nombreColumna == "DniUsuario")
                {
                    e.Value = solicitud.Usuario.Dni?.ToString();
                    e.FormattingApplied = true;
                }
            }
            else
            {
                // Si no tiene usuario, evitamos que la celda quede en blanco o explote
                if (nombreColumna == "Usuario" || nombreColumna == "DniUsuario")
                {
                    e.Value = "Sin Asignar";
                    e.FormattingApplied = true;
                }
            }

            // 2. Columna de Archivo Adjunto (Independiente del usuario)
            if (nombreColumna == "RutaArchivoColumna")
            {
                var primerArchivo = solicitud.ArchivosAdjuntos?.FirstOrDefault();

                if (primerArchivo != null)
                {
                    e.Value = primerArchivo.RutaArchivo;
                }
                else
                {
                    e.Value = "Sin adjunto";
                }
                e.FormattingApplied = true;
            }
            if (nombreColumna == "Estado" && e.Value != null)
            {
                string estado = e.Value.ToString().Trim();

                // APROBADO / APROBADA -> VERDE
                if (estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                    estado.Equals("Aprobada", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(212, 237, 218);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(21, 87, 36);
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(195, 230, 203);
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(21, 87, 36);
                }
                // 👉 RECHAZADO / RECHAZADA -> ROJO ALERTA
                else if (estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase) ||
                         estado.Equals("Rechazada", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(248, 215, 218);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(114, 28, 36);
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 198, 203);
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(114, 28, 36);
                }
                // 👉 INACTIVO -> GRIS / ROJO APAGADO (Diferente del rechazado)
                else if (estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(226, 227, 229); // Gris suave institucional
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(56, 61, 65);   // Texto gris oscuro
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(208, 212, 215);
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(56, 61, 65);
                }
                // PENDIENTE (Simple) -> AMARILLO CLARO
                else if (estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 100, 4);
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 238, 186);
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(133, 100, 4);
                }
                // PENDIENTE DE REVISIÓN -> NARANJA / ÁMBAR
                else if (estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 224, 178);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(186, 104, 20);
                    e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 204, 128);
                    e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(186, 104, 20);
                }

                e.CellStyle.Font = new System.Drawing.Font(dgvSolicitudes.Font, System.Drawing.FontStyle.Bold);
            }

        }

        private void dgvSolicitudes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string nombreColumna = dgvSolicitudes.Columns[e.ColumnIndex].Name;

                // Verificamos si es cualquiera de los tres botones de acción
                if (nombreColumna == "btnAprobarCol" || nombreColumna == "btnRechazarCol" || nombreColumna == "btnEnviarRevisionCol")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var solicitud = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as ModelsEntidades.Solicitud;
                    if (solicitud != null)
                    {
                        string estadoActual = solicitud.Estado != null ? solicitud.Estado.Trim() : string.Empty;

                        // 👉 Inicializamos colorFondo para evitar la advertencia
                        System.Drawing.Color colorFondo = System.Drawing.Color.FromArgb(208, 212, 215);
                        System.Drawing.Color colorTexto = System.Drawing.Color.White;
                        string textoBoton = string.Empty;

                        if (nombreColumna == "btnAprobarCol")
                        {
                            textoBoton = "Aprobar";
                            bool esPendienteRevision = estadoActual.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase);
                            colorFondo = esPendienteRevision ? System.Drawing.Color.FromArgb(40, 167, 69) : System.Drawing.Color.FromArgb(208, 212, 215);
                            if (!esPendienteRevision) colorTexto = System.Drawing.Color.FromArgb(108, 117, 125);
                        }
                        else if (nombreColumna == "btnRechazarCol")
                        {
                            textoBoton = "Rechazar";
                            bool esPendienteRevision = estadoActual.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase);
                            colorFondo = esPendienteRevision ? System.Drawing.Color.FromArgb(220, 53, 69) : System.Drawing.Color.FromArgb(208, 212, 215);
                            if (!esPendienteRevision) colorTexto = System.Drawing.Color.FromArgb(108, 117, 125);
                        }
                        else if (nombreColumna == "btnEnviarRevisionCol")
                        {
                            textoBoton = "Enviar a Revisión";
                            bool esPendiente = estadoActual.Equals("Pendiente", StringComparison.OrdinalIgnoreCase);

                            if (esPendiente)
                            {
                                colorFondo = System.Drawing.Color.FromArgb(53, 162, 227); // Celeste claro sólido
                                colorTexto = System.Drawing.Color.White;    // Texto azul oscuro
                            }
                            else
                            {
                                colorFondo = System.Drawing.Color.FromArgb(208, 212, 215); // Gris inhabilitado
                                colorTexto = System.Drawing.Color.FromArgb(108, 117, 125);
                            }
                        }

                        // Dibujar el fondo sólido del botón
                        using (System.Drawing.Brush brushFondo = new System.Drawing.SolidBrush(colorFondo))
                        {
                            System.Drawing.Rectangle rectBoton = e.CellBounds;
                            rectBoton.Inflate(-2, -2);
                            e.Graphics.FillRectangle(brushFondo, rectBoton);
                        }

                        // Dibujar el texto centrado del botón
                        using (System.Drawing.Brush brushTexto = new System.Drawing.SolidBrush(colorTexto))
                        {
                            System.Drawing.StringFormat formatoTexto = new System.Drawing.StringFormat()
                            {
                                Alignment = System.Drawing.StringAlignment.Center,
                                LineAlignment = System.Drawing.StringAlignment.Center
                            };
                            e.Graphics.DrawString(textoBoton, e.CellStyle.Font, brushTexto, e.CellBounds, formatoTexto);
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en los encabezados de la tabla
            if (e.RowIndex < 0) return;

            // ACCIÓN PARA EL ADMINISTRADOR LOCAL: ENVIAR A REVISIÓN
            if (_rolUsuario == "Administrador Local" && dgvSolicitudes.Columns[e.ColumnIndex].Name == "btnEnviarRevisionCol")
            {
                var solicitudSeleccionada = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as ModelsEntidades.Solicitud;
                if (solicitudSeleccionada == null) return;

                // Validar que la solicitud esté en estado 'Pendiente' para poder enviarla
                if (!solicitudSeleccionada.Estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"La solicitud ya se encuentra en estado '{solicitudSeleccionada.Estado}'. Solo se pueden enviar a revisión las solicitudes 'Pendientes'.",
                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación del operador
                DialogResult confirm = MessageBox.Show($"¿Desea enviar la solicitud N° {solicitudSeleccionada.IdSolicitud} a la Bandeja Central de Revisión?",
                                                     "Confirmar Pase a Central", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        // Llamamos al servicio
                        _solicitudService.EnviarARevision(solicitudSeleccionada.IdSolicitud);

                        MessageBox.Show("¡La solicitud fue enviada exitosamente a la Bandeja del Administrador Central!",
                                        "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescamos la grilla para que se actualice el estado en pantalla
                        CargarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar a revisión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // ACCIÓN PARA EL ADMINISTRADOR CENTRAL: APROBAR O RECHAZAR
            if (_rolUsuario == "Administrador Central" && (dgvSolicitudes.Columns[e.ColumnIndex].Name == "btnAprobarCol" || dgvSolicitudes.Columns[e.ColumnIndex].Name == "btnRechazarCol"))
            {
                var solicitudSeleccionada = dgvSolicitudes.Rows[e.RowIndex].DataBoundItem as ModelsEntidades.Solicitud;
                if (solicitudSeleccionada == null) return;

                // Restricción: Validar que la solicitud esté en estado 'Pendiente de revisión'
                if (!solicitudSeleccionada.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("La solicitud ya se encuentra resuelta (Aprobada o Rechazada). No se pueden modificar decisiones previas.",
                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Botón Aprobar
                if (dgvSolicitudes.Columns[e.ColumnIndex].Name == "btnAprobarCol")
                {
                    DialogResult confirm = MessageBox.Show($"¿Está seguro de aprobar la solicitud seleccionada N° {solicitudSeleccionada.IdSolicitud}?",
                                                         "Confirmar Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            _solicitudService.AprobarSolicitud(solicitudSeleccionada.IdSolicitud);
                            MessageBox.Show("¡Solicitud aprobada exitosamente!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrilla();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al aprobar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Botón Rechazar
                else if (dgvSolicitudes.Columns[e.ColumnIndex].Name == "btnRechazarCol")
                {
                    string motivo = MostrarVentanaMotivoRechazo();
                    if (!string.IsNullOrEmpty(motivo))
                    {
                        try
                        {
                            _solicitudService.RechazarSolicitud(solicitudSeleccionada.IdSolicitud, motivo);
                            MessageBox.Show("La solicitud fue rechazada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrilla();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al rechazar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
            // 1. Validar que haya una fila seleccionada
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una solicitud.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el ID de la solicitud seleccionada desde la celda correspondiente
            // (Asegurate de que el nombre de la columna sea exactamente "IdSolicitud" o el que uses en tu grilla)
            int idSeleccionado = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["IdSolicitud"].Value);

            // 3. Abrir el formulario reutilizable pasando el ID y 'true' para el modo solo lectura
            FrmAltaSolicitud frm = new FrmAltaSolicitud(idSeleccionado, true);
            frm.ShowDialog();
        }

        // =====================================================
        // ELIMINAR SOLICITUD
        // =====================================================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitudes.SelectedRows.Count == 0 && dgvSolicitudes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una solicitud.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filaActual = dgvSolicitudes.SelectedRows.Count > 0 ? dgvSolicitudes.SelectedRows[0] : dgvSolicitudes.CurrentRow;
                var solicitudSeleccionada = filaActual.DataBoundItem as ModelsEntidades.Solicitud;

                if (solicitudSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la solicitud seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea INACTIVAR la solicitud seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Llamamos al servicio igual que en los usuarios
                    _solicitudService.Inactivar(solicitudSeleccionada.IdSolicitud);

                    MessageBox.Show("La solicitud fue inactivada correctamente.", "CredenSoft",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos la grilla al instante
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BUSCAR DNI
        // =====================================================
        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            try
            {
                string dniBuscado = txtBuscarDni.Text.Trim();

                // Si la caja de texto está vacía, recargamos la grilla completa aplicando el filtro general del rol
                if (string.IsNullOrEmpty(dniBuscado))
                {
                    CargarGrilla();
                    return;
                }

                // Buscamos por DNI utilizando el servicio existente
                var listaFiltrada = _solicitudService.ObtenerPorDni(dniBuscado);
                OrdenarColumnas();

                if (listaFiltrada == null || listaFiltrada.Count == 0)
                {
                    MessageBox.Show("No se encontraron solicitudes asociadas a ese DNI.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSolicitudes.DataSource = null;
                    return;
                }

                // APLICAR RESTRICCIÓN DE ESTADOS SEGÚN EL ROL
                if (_rolUsuario == "Administrador Central")
                {
                    listaFiltrada = listaFiltrada
                        .Where(s => s.Estado != null &&
                                   (s.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase) ||
                                    s.Estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                                    s.Estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase)))
                        .ToList();
                }
                else if (_rolUsuario == "Agente")
                {
                    listaFiltrada = listaFiltrada
                        .Where(s => s.IdUsuario == _idUsuarioLogueado &&
                                    s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                else
                {
                    // Admin Local
                    listaFiltrada = listaFiltrada
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                if (listaFiltrada.Count == 0)
                {
                    MessageBox.Show("No se encontraron solicitudes con ese DNI dentro de los estados permitidos para su rol.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSolicitudes.DataSource = null;
                    return;
                }

                dgvSolicitudes.DataSource = listaFiltrada;
                OrdenarColumnas();
                OcultarColumnasTecnicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario borró todo y el textbox quedó vacío, recargamos la grilla completa al instante
            if (string.IsNullOrWhiteSpace(txtBuscarDni.Text))
            {
                CargarGrilla();
            }
        }


        // =====================================================
        // BUSCAR POR ESTADO
        // =====================================================

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                string estadoSeleccionado = cmbEstado.SelectedItem?.ToString();

                if (_rolUsuario == "Agente")
                {
                    var misSolicitudes = _solicitudService.ObtenerSolicitudesPorUsuario(_idUsuarioLogueado);


                    if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                    {
                        // Por defecto "Todos" para el agente excluye inactivos
                        dgvSolicitudes.DataSource = misSolicitudes
                            .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                    else
                    {
                        // Si selecciona explícitamente "Inactivo" u otro estado, filtra exacto
                        dgvSolicitudes.DataSource = misSolicitudes
                            .Where(s => s.Estado != null && s.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }
                }
                else
                {
                    // Lógica para administradores
                    var todas = _solicitudService.ObtenerTodas();

                    if (_rolUsuario == "Administrador Central")
                    {
                        if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                        {
                            // Si el Admin Central selecciona "Todos", filtramos estrictamente solo los 3 estados permitidos para él
                            dgvSolicitudes.DataSource = todas
                                .Where(s => s.Estado != null &&
                                           (s.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase) ||
                                            s.Estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                                            s.Estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase)))
                                .ToList();
                        }
                        else
                        {
                            // Si selecciona un estado específico (ej. Aprobado o Rechazado), respeta ese filtro
                            dgvSolicitudes.DataSource = todas
                                .Where(s => s.Estado != null && s.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                                .ToList();
                        }
                    }
                    else
                    {
                        // Lógica existente para Administrador Local
                        if (string.IsNullOrEmpty(estadoSeleccionado) || estadoSeleccionado.Equals("Todos", StringComparison.OrdinalIgnoreCase))
                        {
                            dgvSolicitudes.DataSource = todas
                                .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                                .ToList();
                        }
                        else
                        {
                            var listaFiltrada = _solicitudService.ObtenerPorEstado(estadoSeleccionado);
                            dgvSolicitudes.DataSource = listaFiltrada;
                        }
                    }
                }
                OrdenarColumnas();
                OcultarColumnasTecnicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por estado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OcultarColumnasTecnicas()
        {
            if (dgvSolicitudes.Columns["IdSolicitud"] != null)
                dgvSolicitudes.Columns["IdSolicitud"].Visible = false;

            if (dgvSolicitudes.Columns["IdUsuario"] != null)
                dgvSolicitudes.Columns["IdUsuario"].Visible = false;

            if (dgvSolicitudes.Columns["ArchivosAdjuntos"] != null)
                dgvSolicitudes.Columns["ArchivosAdjuntos"].Visible = false;
        }

        // =====================================================
        // EDITAR SOLICITUD
        // =====================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                // 1. Obtenemos la solicitud seleccionada de la grilla
                Solicitud solicitudSeleccionada = (Solicitud)dgvSolicitudes.SelectedRows[0].DataBoundItem;
                string estadoActual = solicitudSeleccionada.Estado != null ? solicitudSeleccionada.Estado.Trim() : string.Empty;
                // 3. 👉 REGLA DE NEGOCIO: Si está en "Pendiente de revisión", BLOQUEAR edición
                if (estadoActual.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase)||
                    estadoActual.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                    estadoActual.Equals("Rechazado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta solicitud ya ha sido enviada al Administrador Central o se encuentra resuelta, por lo que no puede ser modificada.",
                                   "Edición No Permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para que no abra la ventana de edición
                }

                // 2. Abrimos el formulario pasándole el ID al constructor (para que active el modo edición)
                using (FrmAltaSolicitud frm = new FrmAltaSolicitud(solicitudSeleccionada.IdSolicitud))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarGrilla(); // Refresca tu DataGridView principal
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una solicitud de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================
        // SALIR
        // =====================================================

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string MostrarVentanaMotivoRechazo()
        {
            Form prompt = new Form()
            {
                Width = 450,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Confirmar Rechazo",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblAdvertencia = new Label() { Left = 20, Top = 20, Text = "ADVERTENCIA: ¿Está seguro de RECHAZAR la solicitud seleccionada?\nIngrese el Motivo del Rechazo:", Width = 390, Height = 40, ForeColor = System.Drawing.Color.DarkRed };
            TextBox txtMotivo = new TextBox() { Left = 20, Top = 70, Width = 390, Height = 60, Multiline = true };
            Button confirmation = new Button() { Text = "Reconfirmar Rechazo", Left = 130, Width = 150, Top = 145, BackColor = System.Drawing.Color.LightCoral };
            Button cancellation = new Button() { Text = "Cancelar", Left = 290, Width = 120, Top = 145 };

            confirmation.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Debe especificar un motivo para rechazar la solicitud.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    prompt.DialogResult = DialogResult.OK;
                    prompt.Close();
                }
            };

            cancellation.Click += (sender, e) =>
            {
                prompt.DialogResult = DialogResult.Cancel;
                prompt.Close();
            };

            prompt.Controls.Add(lblAdvertencia);
            prompt.Controls.Add(txtMotivo);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancellation);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancellation;

            return prompt.ShowDialog() == DialogResult.OK ? txtMotivo.Text : string.Empty;
        }

        // =====================================================
        // ORDENAR COLUMNAS
        // =====================================================

        private void OrdenarColumnas()
        {
            // 1. Ocultar las columnas técnicas si existen
            if (dgvSolicitudes.Columns["IdSolicitud"] != null) dgvSolicitudes.Columns["IdSolicitud"].Visible = false;
            if (dgvSolicitudes.Columns["IdUsuario"] != null) dgvSolicitudes.Columns["IdUsuario"].Visible = false;
            if (dgvSolicitudes.Columns["DetalleAnexoC"] != null) dgvSolicitudes.Columns["DetalleAnexoC"].Visible = false;
            if (dgvSolicitudes.Columns["DetalleAnexoE"] != null) dgvSolicitudes.Columns["DetalleAnexoE"].Visible = false;
            if (dgvSolicitudes.Columns["ArchivosAdjuntos"] != null) dgvSolicitudes.Columns["ArchivosAdjuntos"].Visible = false;

            // 2. Configurar el orden secuencial fijo de izquierda a derecha
            int index = 0;

            if (dgvSolicitudes.Columns["Usuario"] != null) dgvSolicitudes.Columns["Usuario"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["DniUsuario"] != null) dgvSolicitudes.Columns["DniUsuario"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["TipoSolicitud"] != null) dgvSolicitudes.Columns["TipoSolicitud"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["FechaSolicitud"] != null) dgvSolicitudes.Columns["FechaSolicitud"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["Descripcion"] != null) dgvSolicitudes.Columns["Descripcion"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["RutaArchivoColumna"] != null) dgvSolicitudes.Columns["RutaArchivoColumna"].DisplayIndex = index++;

            // 👉 Estado y Motivo de Rechazo siempre juntos antes de los botones
            if (dgvSolicitudes.Columns["Estado"] != null) dgvSolicitudes.Columns["Estado"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["MotivoRechazo"] != null) dgvSolicitudes.Columns["MotivoRechazo"].DisplayIndex = index++;

            // 3. Botones de acciones al final de todo
            if (dgvSolicitudes.Columns["btnAprobarCol"] != null) dgvSolicitudes.Columns["btnAprobarCol"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["btnRechazarCol"] != null) dgvSolicitudes.Columns["btnRechazarCol"].DisplayIndex = index++;
            if (dgvSolicitudes.Columns["btnEnviarRevisionCol"] != null) dgvSolicitudes.Columns["btnEnviarRevisionCol"].DisplayIndex = index++;

        }

        // =====================================================
        // FILTRAR POR FECHAS
        // =====================================================
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltroFechasAutomatico();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltroFechasAutomatico();
        }

        private void AplicarFiltroFechasAutomatico()
        {
            try
            {
                // 1. Tomar y formatear el rango completo del día
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                // 2. Validar que la fecha "Desde" no sea mayor que la fecha "Hasta"
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final.",
                                    "Validación de Fechas",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Bloquea y frena la ejecución para que no busque
                }

                List<Solicitud> listaFiltrada;

                // 3. Aplicar el filtro según el rol (igual que hacés en CargarGrilla)
                if (_rolUsuario == "Agente")
                {
                    listaFiltrada = _solicitudService.ObtenerPorUsuarioYFecha(_idUsuarioLogueado, fechaDesde, fechaHasta)
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                else
                {
                    listaFiltrada = _solicitudService.ObtenerPorFecha(fechaDesde, fechaHasta)
                        .Where(s => s.Estado != null && !s.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                // 4. 👉 Validar si no hay registros en el rango seleccionado
                if (listaFiltrada == null || listaFiltrada.Count == 0)
                {
                    dgvSolicitudes.DataSource = null; // Limpiamos la grilla para que no queden datos viejos
                    MessageBox.Show("No hay registros de solicitud en ese rango de fechas.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                // 5. Refrescar la grilla
                dgvSolicitudes.DataSource = null;
                dgvSolicitudes.DataSource = listaFiltrada;

                // Asegurar orden y visibilidad de columnas
                OrdenarColumnas();
                OcultarColumnasTecnicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por fechas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}