using DataEF;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmLogin()
        {
            InitializeComponent();

            // Configuramos el carácter de máscara para la contraseña
            txtContrasenia.PasswordChar = '*';

            // Permite que al apretar "Enter" se ejecute el botón Ingresar
            this.AcceptButton = btnIngresar;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Foco inicial en el cuadro de usuario
            txtUsuario.Select();

            // Seteamos el icono inicial del ojo
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("Por favor, ingrese su correo electrónico y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Intento de Login a través del servicio
                var usuario = _usuarioService.Login(txtUsuario.Text, txtContrasenia.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Acceso inválido, por favor inténtelo nuevamente.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenia.Clear();
                    return;
                }

                // Verificación de estado del usuario
                if (usuario.Estado != "Activo")
                {
                    MessageBox.Show("ACCESO DENEGADO: Su usuario se encuentra INACTIVO.", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // --- LOGIN EXITOSO ---
                // Guardamos los datos en la sesión (incluye el Rol si está cargado)
                SesionActual.UsuarioLogueado = usuario;

                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Abre el formulario de alta como una ventana emergente
            FrmAltaUsuario frmRegistro = new FrmAltaUsuario();
            frmRegistro.ShowDialog();
        }

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar/ocultar contraseña
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
            FrmRecuperarContrasenia frmRecuperar = new FrmRecuperarContrasenia(_usuarioService);
            frmRecuperar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}