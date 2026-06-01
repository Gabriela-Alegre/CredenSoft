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
        // VALIDACIÓN DE ACCESO POR ROL
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

            // Mostrar datos de sesión
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
        }

        // =====================================================
        // GESTIÓN DE USUARIOS
        // =====================================================

        private void btnGestiónDeUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        // =====================================================
        // CERRAR SESIÓN
        // =====================================================

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();

            this.Hide();
        }

        // =====================================================
        // EVENTOS VACÍOS DEL DISEÑADOR
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
    }
}