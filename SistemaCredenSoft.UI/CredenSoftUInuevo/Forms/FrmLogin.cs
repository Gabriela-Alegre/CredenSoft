using DataEF;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmLogin()
        {
            InitializeComponent();

            // Configuramos el inicio: contraseña oculta y botón Enter activado
            txtContrasenia.PasswordChar = '*';
            this.AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("Por favor, ingrese su correo electrónico y contraseña.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validación de formato de email
                if (!txtUsuario.Text.Contains("@") || !txtUsuario.Text.Contains("."))
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico válido (ejemplo@correo.com).",
                                    "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return;
                }

                // 3. Intento de Login
                var usuario = _usuarioService.Login(txtUsuario.Text, txtContrasenia.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Acceso inválido, por favor inténtelo nuevamente.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenia.Clear();
                    return;
                }

                // 4. Validación de usuario inactivo
                if (usuario.Estado != "Activo")
                {
                    MessageBox.Show("ACCESO DENEGADO: Su usuario se encuentra INACTIVO.\nContacte al administrador central de la PSA.",
                                    "Usuario Bloqueado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }

                // 5. Éxito: Guardamos la sesión y saltamos directo al Dashboard
                SesionActual.UsuarioLogueado = usuario;

                if (chkRecordarme.Checked)
                {
                    // Lógica futura de cookies/config
                }

                // Abrimos el Dashboard sin carteles intermedios
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lógica para mostrar/ocultar contraseña con los iconos de Recursos
        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.PasswordChar == '*')
            {
                // Mostramos texto y cambiamos al ojo abierto
                txtContrasenia.PasswordChar = '\0';
                picVerContrasenia.Image = Properties.Resources.ojo_abierto;
            }
            else
            {
                // Ocultamos texto y volvemos al ojo cerrado
                txtContrasenia.PasswordChar = '*';
                picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Abre el registro de nuevos usuarios
            FrmAltaUsuario frmRegistro = new FrmAltaUsuario();
            frmRegistro.ShowDialog();
        }

        private void lnkRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre la recuperación de contraseña
            FrmRecuperarContrasenia frmRecuperar = new FrmRecuperarContrasenia(_usuarioService);
            frmRecuperar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // El foco empieza en el usuario para que el programador/usuario escriba rápido
            txtUsuario.Select();

            // Aseguramos que la imagen inicial sea el ojo cerrado
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
        }
    }
}