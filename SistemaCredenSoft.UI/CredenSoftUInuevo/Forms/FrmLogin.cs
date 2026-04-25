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
            txtContrasenia.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos vacíos (Advertencia amarilla)
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("Por favor, ingrese su correo electrónico y contraseña.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Intento de Login
                var usuario = _usuarioService.Login(txtUsuario.Text, txtContrasenia.Text);

                // 3. VALIDACIÓN DE USUARIO INACTIVO (HU 04)
                // Si las credenciales son correctas pero el usuario está dado de baja
                if (usuario.Estado != "Activo")
                {
                    MessageBox.Show("ACCESO DENEGADO: Su usuario se encuentra INACTIVO.\nContacte al administrador central de la PSA.",
                                    "Usuario Bloqueado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop); // <--- Señal de Stop/Prohibido
                    return; 
                }

                // 4. Éxito: Guardamos sesión y entramos
                SesionActual.UsuarioLogueado = usuario;

                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // HU 03: Credenciales Incorrectas
                MessageBox.Show(ex.Message, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.PasswordChar == '*')
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmRegistro = new FrmAltaUsuario();
            frmRegistro.ShowDialog();
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }
    }
}