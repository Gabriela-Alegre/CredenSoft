using ModelsEntidades;
using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboardAdmin : Form
    {
        public FrmDashboardAdmin()
        {
            InitializeComponent();
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

            // =====================================================
            // DATOS INFORMATIVOS
            // =====================================================

            lblUsuariosActivos.Text =
                "Usuarios Activos: --";

            lblSolicitudesPendientes.Text =
                "Solicitudes Pendientes: --";

            lblCredencialesEmitidas.Text =
                "Credenciales Emitidas: --";

            lblAccesosRegistradosHoy.Text =
                "Accesos Registrados Hoy: --";
        }

        // =====================================================
        // GESTIÓN DE USUARIOS
        // SOLO ADMINISTRADOR LOCAL
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
                // Si existe el método Logout, dejarlo.
                // Si da error, eliminar esta línea.
                SesionActual.Logout();

                FrmLogin frm = new FrmLogin();
                frm.Show();

                this.Close();
            }
        }

        // =====================================================
        // EVENTOS GENERADOS POR EL DISEÑADOR
        // =====================================================

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblÚltimasSolicitudes_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

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
            FrmConfiguracion frm = new FrmConfiguracion();
            frm.ShowDialog();
        }

        private void btnVerSolicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
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
    }
    }