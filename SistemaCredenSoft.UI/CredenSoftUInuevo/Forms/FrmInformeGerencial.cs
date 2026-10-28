using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmInformeGerencial : Form
    {
        private readonly SolicitudService _solicitudService;

        public FrmInformeGerencial()
        {
            InitializeComponent();
            _solicitudService = new SolicitudService();
        }

        private void FrmInformeGerencial_Load(object sender, EventArgs e)
        {
            // 1. Configurar las 2 columnas del TableLayoutPanel al 50% cada una (Distribución vertical)
            if (tableLayoutPanel1.ColumnCount >= 2)
            {
                tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 50F);
                tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 50F);
            }

            // 2. Estado inicial: Mostrar el cartel de bienvenida al frente, ocultar gráfico y grilla
            lblMensajeInicial.Visible = true;
            lblMensajeInicial.BringToFront();
            chartEstadisticas.Visible = false;
            dgvResumen.Visible = false;

            // =========================================================
            // DISEÑO PROFESIONAL PARA LA GRILLA RESUMEN (dgvResumen)
            // =========================================================
            dgvResumen.EnableHeadersVisualStyles = false;

            // 1. Estilo del Encabezado (Cabecera)
            dgvResumen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91); // Un azul gerencial elegante
            dgvResumen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResumen.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvResumen.ColumnHeadersHeight = 35; // Darle un poco más de altura para que respire

            // 2. Estilo de las Celdas y Filas
            dgvResumen.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvResumen.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgvResumen.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Color al seleccionar una fila
            dgvResumen.DefaultCellStyle.SelectionForeColor = Color.White;

            // 3. Filas cebra (alternar colores para facilitar la lectura)
            dgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246);

            // 4. Bordes y rejilla generales
            dgvResumen.GridColor = Color.LightGray;
            dgvResumen.BorderStyle = BorderStyle.None;
            dgvResumen.RowHeadersVisible = false; // Ocultar la columna gris de la izquierda si prefieres un look más limpio

            // 3. Fechas por defecto (desde el inicio del mes actual hasta hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpHasta.Value = DateTime.Now;
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                // Validación de Rango de Fechas
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("Error de Rango de Fechas: La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.",
                                    "Validación de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener estadísticas gerenciales globales (excluyendo inactivos)
                var stats = _solicitudService.ObtenerEstadisticasGerenciales(fechaDesde, fechaHasta);

                // Control de datos vacíos en el período
                if (stats.total == 0)
                {
                    lblValorTotal.Text = "0";
                    lblValorAprobadas.Text = "0 (0.0%)";
                    lblValorRechazadas.Text = "0 (0.0%)";
                    lblValorPendientes.Text = "0 (0.0%)";

                    // Mostrar mensaje inicial y ocultar elementos de datos
                    lblMensajeInicial.Visible = true;
                    lblMensajeInicial.BringToFront();
                    chartEstadisticas.Visible = false;
                    dgvResumen.Visible = false;

                    MessageBox.Show("ADVERTENCIA: No se encontraron registros de solicitudes para el periodo de fechas seleccionado.",
                                    "Informe Gerencial (Cero Datos)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si hay datos, ocultar mensaje inicial y mostrar gráfico y grilla
                lblMensajeInicial.Visible = false;
                chartEstadisticas.Visible = true;
                dgvResumen.Visible = true;

                // Calcular porcentajes
                double pAprobadas = (double)stats.aprobadas / stats.total * 100;
                double pRechazadas = (double)stats.rechazadas / stats.total * 100;
                double pPendientes = (double)stats.pendientes / stats.total * 100;

                // Llenar Tarjetas KPIs con valores y porcentajes
                lblValorTotal.Text = stats.total.ToString("N0");
                lblValorAprobadas.Text = $"{stats.aprobadas} ({pAprobadas:F1}%)";
                lblValorRechazadas.Text = $"{stats.rechazadas} ({pRechazadas:F1}%)";
                lblValorPendientes.Text = $"{stats.pendientes} ({pPendientes:F1}%)";

                // =========================================================
                // A) CARGAR EL GRÁFICO DE BARRAS (Columna Izquierda)
                // =========================================================
                chartEstadisticas.Series.Clear();
                var series = chartEstadisticas.Series.Add("Solicitudes");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series.IsXValueIndexed = true;

                series.Points.AddXY("Aprobadas", stats.aprobadas);
                series.Points.AddXY("Rechazadas", stats.rechazadas);
                series.Points.AddXY("Pendientes", stats.pendientes);

                // Colores institucionales para las barras
                series.Points[0].Color = Color.SeaGreen;
                series.Points[1].Color = Color.Firebrick;
                series.Points[2].Color = Color.Goldenrod;

                // =========================================================
                // B) CARGAR LA GRILLA RESUMEN (Columna Derecha)
                // =========================================================
                var listaPeriodo = _solicitudService.ObtenerPorFecha(fechaDesde, fechaHasta)
            .Where(s => s.Estado != null &&
                        (s.Estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                         s.Estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase) ||
                         s.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase)))
            .Select(s => new
            {
                Titular = s.Usuario != null ? $"{s.Usuario.Nombre} {s.Usuario.Apellido}" : "Sin Asignar",
                Tramite = s.TipoSolicitud,
                FechaIngreso = s.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"),
                EstadoActual = s.Estado
            })
            .ToList();

                dgvResumen.DataSource = listaPeriodo;
                dgvResumen.ReadOnly = true;
                dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // =========================================================
                // FORZAR ESTILOS VISUALES DESPUÉS DEL ENLACE DE DATOS
                // =========================================================
                dgvResumen.EnableHeadersVisualStyles = false;
                dgvResumen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91); // Azul gerencial
                dgvResumen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvResumen.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvResumen.ColumnHeadersHeight = 35;

                dgvResumen.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                dgvResumen.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
                dgvResumen.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvResumen.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvResumen.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246);
                dgvResumen.GridColor = Color.LightGray;
                dgvResumen.BorderStyle = BorderStyle.None;
                dgvResumen.RowHeadersVisible = false;
                // =========================================================
                // C) ACTUALIZAR ANCHO DINÁMICO DE LAS BARRAS DE LAS TARJETAS (WIDTH)
                // =========================================================

                // El ancho máximo ahora es el ancho total del panel gris de fondo de cada tarjeta
                panelBarraTotal.Width = panelFondoTotal.Width; // El total siempre va al 100%

                panelBarraAprobadas.Width = (int)(panelFondoAprobadas.Width * (pAprobadas / 100.0));
                panelBarraRechazadas.Width = (int)(panelFondoRechazadas.Width * (pRechazadas / 100.0));
                panelBarraPendientes.Width = (int)(panelFondoPendientes.Width * (pPendientes / 100.0));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe gerencial: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Configurar el cuadro de diálogo para guardar archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Exportar Panel a Imagen";
                    saveFileDialog.Filter = "Imagen PNG|*.png|Imagen JPEG|*.jpg";
                    saveFileDialog.FileName = $"Dashboard_Admin_{DateTime.Now:yyyyMMdd_HHmmss}.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 2. Crear un Bitmap con el tamaño actual del panel principal (o del formulario completo)
                        // Si quieres exportar todo el formulario, cambia 'panelPrincipal' por 'this'
                        Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
                        using (Bitmap bitmap = new Bitmap(rect.Width, rect.Height))
                        {
                            this.DrawToBitmap(bitmap, new Rectangle(0, 0, rect.Width, rect.Height));

                            // 3. Guardar la imagen en la ruta seleccionada por el usuario
                            string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();
                            if (extension == ".jpg" || extension == ".jpeg")
                            {
                                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            else
                            {
                                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            }
                        }

                        MessageBox.Show(
                            "¡Panel exportado con éxito!",
                            "CredenSoft",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al exportar la imagen: " + ex.Message,
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}