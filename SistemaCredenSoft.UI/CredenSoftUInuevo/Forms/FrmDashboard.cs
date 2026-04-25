using System;
using System.Windows.Forms;
using System.Drawing;
using ModelsEntidades; // Importante para SesionActual

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // 1. Cargamos los datos del usuario logueado en el Header
            CargarDatosUsuario();

            // 2. Validación de seguridad extra (HU 04)
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
                // Mostramos Nombre, Apellido y Rol en el label que creamos en el Designer
                lblInfoUsuario.Text = $"Oficial: {SesionActual.UsuarioLogueado.Nombre} {SesionActual.UsuarioLogueado.Apellido} | Rol: {SesionActual.UsuarioLogueado.Rol}";
            }
            else
            {
                lblInfoUsuario.Text = "Usuario no identificado";
            }
        }

        // --- MÉTODO CLAVE: Abre formularios dentro del Panel Central ---
        private void AbrirFormEnPanel(Form formularioHijo)
        {
            // Si ya hay un formulario abierto,cerramos para liberar memoria
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita bordes (X, minimizar, etc)
            formularioHijo.Dock = DockStyle.Fill; // Hace que ocupe todo el espacio blanco

            this.panelContent.Controls.Add(formularioHijo);
            this.panelContent.Tag = formularioHijo;
            formularioHijo.Show();
        }

        // --- EVENTOS DE BOTONES ---

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            // Ahora se abre ADENTRO del dashboard
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
                // Limpiamos la sesión
                SesionActual.UsuarioLogueado = null;

                // Volvemos al Login
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide(); // Escondemos el Dash 
            }
        }
    }
}