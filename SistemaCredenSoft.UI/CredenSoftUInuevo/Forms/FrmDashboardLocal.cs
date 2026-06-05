using ModelsEntidades;
using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboardLocal : Form
    {
        public FrmDashboardLocal()
        {
            InitializeComponent();

            Load += FrmDashboardLocal_Load;
        }

        // =====================================================
        // CARGA DEL DASHBOARD
        // =====================================================

        private void FrmDashboardLocal_Load(object sender, EventArgs e)
        {
            // Verificar sesión activa
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

            // Verificar rol Administrador Local
            if (SesionActual.UsuarioLogueado.IdRol != 2)
            {
                MessageBox.Show(
                    "Acceso denegado.\nEste módulo es exclusivo para Administradores Locales.",
                    "Seguridad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                this.Close();
                return;
            }

            // Mostrar datos del usuario
            lblRol.Text =
                "Rol: " +
                SesionActual.UsuarioLogueado.Rol.NombreRol;

            lblNombre.Text =
                "Nombre: " +
                SesionActual.UsuarioLogueado.Nombre + " " +
                SesionActual.UsuarioLogueado.Apellido;

            // Temporal hasta tener sede en BD
            lblSede.Text =
                "Sede: Aeropuerto Local";

            // Barra superior
            lblInfoUsuario.Text =
                $"{SesionActual.UsuarioLogueado.Nombre} " +
                $"{SesionActual.UsuarioLogueado.Apellido} | " +
                $"{SesionActual.UsuarioLogueado.Rol.NombreRol}";

            // Barra inferior
            lblStatus.Text =
                "● Sesión activa | Conexión segura";
        }

        // =====================================================
        // CERRAR SESIÓN
        // =====================================================

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "CredenSoft",
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
        // MI PERFIL
        // =====================================================
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.ShowDialog();
        }

        // =====================================================
        // VALIDACIONES
        // =====================================================

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmValidaciones frm = new FrmValidaciones();

            frm.ShowDialog();

            this.Show();
        }

        // =====================================================
        // VALIDAR SOLICITUD
        // =====================================================

        private void btnValidarSolicitud_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmValidaciones frm = new FrmValidaciones();

            frm.ShowDialog();

            this.Show();
        }

        // =====================================================
        // CONFIGURACIÓN
        // =====================================================

        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmConfiguracion frm = new FrmConfiguracion();

            frm.ShowDialog();

            this.Show();
        }

        // =====================================================
        // CREDENCIALES
        // =====================================================

        private void btnCredenciales_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCredenciales frm = new FrmCredenciales();

            frm.ShowDialog();

            this.Show();
        }

        // =====================================================
        // GENERAR REPORTE
        // =====================================================

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Funcionalidad en desarrollo.",
                "CredenSoft",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // SOLICITUDES
        // =====================================================

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmSolicitud frm = new FrmSolicitud();

            frm.ShowDialog();

            this.Show();
        }

        // =====================================================
        // GESTIÓN DE USUARIOS
        // =====================================================

        private void btnGestiónDeUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsuarios frm = new FrmUsuarios();

            frm.ShowDialog();

            this.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}