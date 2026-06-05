using DataEF;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmLogin : Form
    {
        // Servicio que se conecta con la base de datos
        private readonly UsuarioService _usuarioService =
            new UsuarioService(new CredenSoftContext());

        public FrmLogin()
        {
            InitializeComponent();

            txtContrasenia.PasswordChar = '*';
            this.AcceptButton = btnIngresar;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Foco inicial en el textbox usuario
            txtUsuario.Select();

            // Ícono inicial del ojo
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // =====================================================
                // VALIDACIÓN DE CAMPOS VACÍOS
                // =====================================================

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show(
                        "Por favor, ingrese su correo electrónico y contraseña.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =====================================================
                // LOGIN DEL USUARIO
                // =====================================================

                var usuario = _usuarioService.Login(
                    txtUsuario.Text,
                    txtContrasenia.Text);

                // =====================================================
                // VALIDACIÓN DE USUARIO
                // =====================================================

                if (usuario == null)
                {
                    MessageBox.Show(
                        "Acceso inválido, por favor inténtelo nuevamente.",
                        "Error de Acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtContrasenia.Clear();
                    return;
                }

                // =====================================================
                // VALIDACIÓN DE ESTADO
                // =====================================================

                if (usuario.Estado != "Activo")
                {
                    MessageBox.Show(
                        "ACCESO DENEGADO: Su usuario se encuentra INACTIVO.",
                        "Usuario Bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

                    return;
                }

                // =====================================================
                // LOGIN EXITOSO
                // =====================================================

                // Guardamos los datos del usuario en la sesión actual
                SesionActual.UsuarioLogueado = usuario;

                // =====================================================
                // REDIRECCIÓN SEGÚN ROL
                // PASO 3 - Gestión de Roles y Permisos
                // =====================================================

                // ADMINISTRADOR CENTRAL
                if (usuario.IdRol == 1)
                {
                    FrmDashboardAdmin frm = new FrmDashboardAdmin();
                    frm.Show();
                }

                // ADMINISTRADOR LOCAL
                else if (usuario.IdRol == 2)
                {
                    FrmDashboardLocal frm = new FrmDashboardLocal();
                    frm.Show();
                }

                // AGENTE
                else if (usuario.IdRol == 3)
                {
                    FrmDashboardAgente frm = new FrmDashboardAgente();
                    frm.Show();
                }

                // ROL NO VÁLIDO
                else
                {
                    MessageBox.Show(
                        "El usuario no tiene un rol válido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // Oculta el Login luego de ingresar correctamente
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error Crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro
            FrmAltaUsuario frmRegistro = new FrmAltaUsuario();
            frmRegistro.ShowDialog();
        }

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            // =====================================================
            // MOSTRAR / OCULTAR CONTRASEÑA
            // =====================================================

            if (txtContrasenia.PasswordChar == '*')
            {
                txtContrasenia.PasswordChar = '\0';
                picVerContrasenia.Image = Properties.Resources.ojo_abierto;
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
                picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            }
        }

        private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre el formulario de recuperación de contraseña
            FrmRecuperarContrasenia frmRecuperar =
                new FrmRecuperarContrasenia(_usuarioService);

            frmRecuperar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra completamente la aplicación
            Application.Exit();
        }
    }
}