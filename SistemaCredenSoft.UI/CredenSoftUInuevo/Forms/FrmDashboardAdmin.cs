using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboardAdmin : Form
    {
        private readonly SolicitudService _solicitudService;

        public FrmDashboardAdmin()
        {
            InitializeComponent();
            _solicitudService = new SolicitudService();
        }

        // =====================================================
        // CARGA DEL DASHBOARD
        // =====================================================
        private void FrmDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Verificar sesión
            if (SesionActual.UsuarioLogueado == null)
            {
                MessageBox.Show(
                    "No hay sesión iniciada.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            // Solo Administrador Central
            if (SesionActual.UsuarioLogueado.IdRol != 1)
            {
                MessageBox.Show(
                    "ACCESO DENEGADO.\nNo posee permisos para ingresar a este panel.",
                    "Seguridad del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                this.Close();
                return;
            }

            // =====================================================
            // DATOS DE SESIÓN
            // =====================================================
            lblUsuario.Text =
                "Usuario: " +
                SesionActual.UsuarioLogueado.Nombre + " " +
                SesionActual.UsuarioLogueado.Apellido;

            lblRol.Text =
                "Rol: " +
                SesionActual.UsuarioLogueado.Rol.NombreRol;

            lblFecha.Text =
                "Fecha: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            lblEstado.Text = "Estado: Activo";
            lblInfoUsuario.Text =
                $"{SesionActual.UsuarioLogueado.Nombre} " +
                $"{SesionActual.UsuarioLogueado.Apellido} | " +
                $"{SesionActual.UsuarioLogueado.Rol.NombreRol}";
            lblStatus.Text =
                "● Sesión activa | Conexión segura";

            // Cargar datos y métricas gerenciales
            CargarDatosDashboard();
        }


        // =====================================================
        // CARGAR DATOS DASH
        // =====================================================
        private void CargarDatosDashboard()
        {
            try
            {
                // Definimos el rango del mes actual por defecto para las métricas del panel
                DateTime fechaDesde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime fechaHasta = DateTime.Now;

                // 1. Obtener estadísticas gerenciales usando tu servicio
                var stats = _solicitudService.ObtenerEstadisticasGerenciales(fechaDesde, fechaHasta);

                // Asignar textos claros y acordes al informe gerencial
                lblUsuariosActivos.Text = $"Total Registradas: {stats.total}";
                lblSolicitudesPendientes.Text = $"Pendientes de revisión: {stats.pendientes}";
                lblCredencialesEmitidas.Text = $"Solicitudes Aprobadas: {stats.aprobadas}";
                lblAccesosRegistradosHoy.Text = $"Solicitudes Rechazadas: {stats.rechazadas}";

                // 2. Cargar la grilla de "Últimas Solicitudes" (dgvSolicitudes)
                var ultimasSolicitudes = _solicitudService.ObtenerPorFecha(fechaDesde.AddMonths(-3), fechaHasta)
                    .Where(s => s.Estado != null &&
               (s.Estado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase) ||
                s.Estado.Equals("Rechazado", StringComparison.OrdinalIgnoreCase) ||
                s.Estado.Equals("Pendiente de revisión", StringComparison.OrdinalIgnoreCase)))
                    .OrderByDescending(s => s.FechaSolicitud)
                    .Take(5) // Tomamos las últimas 5 solicitudes
                    .Select(s => new
                    {
                        ID = s.IdSolicitud,
                        Estado = s.Estado,
                        Fecha = s.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"),
                        Tipo = s.TipoSolicitud
                    })
                    .ToList();

                dgvSolicitudes.AutoGenerateColumns = false;
                // Evitar que duplique columnas automáticas desactivando AutoGenerateColumns o limpiándolas
                dgvSolicitudes.AutoGenerateColumns = true;
                dgvSolicitudes.DataSource = ultimasSolicitudes;

                // 3. Aplicar diseño gerencial profesional a la grilla `dgvSolicitudes`
                dgvSolicitudes.EnableHeadersVisualStyles = false;
                dgvSolicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91); // Azul gerencial
                dgvSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSolicitudes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                dgvSolicitudes.ColumnHeadersHeight = 30;

                dgvSolicitudes.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
                dgvSolicitudes.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
                dgvSolicitudes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvSolicitudes.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvSolicitudes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246); // Efecto cebra
                dgvSolicitudes.GridColor = Color.LightGray;
                dgvSolicitudes.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del dashboard: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // MI PERFIL
        // =====================================================
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.ShowDialog();
        }

        // =====================================================
        // GESTIÓN DE USUARIOS
        // =====================================================
        private void btnGestiónDeUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Esta funcionalidad corresponde al Administrador Local.",
                "Acceso Restringido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // =====================================================
        // CERRAR SESIÓN
        // =====================================================
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SesionActual.Logout();

                FrmLogin frm = new FrmLogin();
                frm.Show();

                this.Close();
            }
        }

        // =====================================================
        // EVENTOS GENERADOS POR EL DISEÑADOR
        // =====================================================
        private void label2_Click(object sender, EventArgs e) { }
        private void lblÚltimasSolicitudes_Click(object sender, EventArgs e) { }
        private void panelMenu_Paint(object sender, PaintEventArgs e) { }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.ShowDialog();
        }

        private void btnCredenciales_Click(object sender, EventArgs e)
        {
            FrmMiCredencial frm = new FrmMiCredencial();
            frm.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado.IdRol != 2)
            {
                MessageBox.Show(
                    "Acceso denegado: su rol no tiene permisos para ingresar al módulo de Configuración.",
                    "Permiso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            FrmConfiguracion frm = new FrmConfiguracion();
            frm.ShowDialog();
        }

        private void btnVerSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud(
                SesionActual.UsuarioLogueado.Rol.NombreRol,
                SesionActual.UsuarioLogueado.IdUsuario
                );
            frm.ShowDialog();
        }

        private void btnEmitirCredencial_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Funcionalidad en desarrollo.",
                "CredenSoft",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Esta funcionalidad corresponde al Administrador Local.",
                "Acceso Restringido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            FrmValidaciones frm = new FrmValidaciones();
            frm.Show();
            this.Hide();
        }

        private void lblInfoUsuario_Click(object sender, EventArgs e) { }
    }
}