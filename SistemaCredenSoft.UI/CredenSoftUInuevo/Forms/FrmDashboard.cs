using System;
using System.Windows.Forms;
using System.Drawing;
using ModelsEntidades;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Shown(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                string nombreRolStr = "Sin Rol";

                // Casteo seguro al tipo Rol
                var objetoRol = SesionActual.UsuarioLogueado.Rol as ModelsEntidades.Rol;

                if (objetoRol != null)
                {

                    nombreRolStr = objetoRol.NombreRol;
                }

                MessageBox.Show($"¡Bienvenido al Sistema, {SesionActual.UsuarioLogueado.Nombre}!\n\nSesión iniciada como: {nombreRolStr}",
                                "Acceso Confirmado - CredenSoft",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();

            if (SesionActual.UsuarioLogueado != null && SesionActual.UsuarioLogueado.Estado != "Activo")
            {
                MessageBox.Show("Sesión inválida: Usuario Inactivo.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void CargarDatosUsuario()
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                string rolActualStr = "No asignado";

                var objetoRol = SesionActual.UsuarioLogueado.Rol as ModelsEntidades.Rol;

                if (objetoRol != null)
                {
                    // CORRECCIÓN: Usamos NombreRol
                    rolActualStr = objetoRol.NombreRol;
                }

                lblInfoUsuario.Text = $"Oficial: {SesionActual.UsuarioLogueado.Nombre} {SesionActual.UsuarioLogueado.Apellido} | Rol: {rolActualStr}";
            }
            else
            {
                lblInfoUsuario.Text = "Usuario no identificado";
            }
        }

        private void AbrirFormEnPanel(Form formularioHijo)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            this.panelContent.Controls.Add(formularioHijo);
            this.panelContent.Tag = formularioHijo;
            formularioHijo.Show();
        }

        // --- EVENTOS DE BOTONES ---

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAltaSolicitud());
            lblStatus.Text = "● Navegando: Gestión de Solicitudes";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAltaUsuario());
            lblStatus.Text = "● Navegando: Gestión de Usuarios";
        }

        private void btnCredenciales_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAltaCredencial());
            lblStatus.Text = "● Navegando: Emisión de Credenciales";
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El módulo de Auditoría está siendo actualizado por el administrador central.",
                            "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar su sesión de oficial?",
                                                    "Cerrar Sesión",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SesionActual.Logout();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}