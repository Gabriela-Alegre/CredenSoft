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
        // Servicio para conectar con la base de datos
        private readonly UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos vacíos (Front-end)
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("Por favor, ingrese su email y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Intento de Login
                var usuario = _usuarioService.Login(txtUsuario.Text, txtContrasenia.Text);

                // Guardamos el usuario en la sesión global
                SesionActual.UsuarioLogueado = usuario;

                // 3. Abrir Dashboard y ocultar Login
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Muestra el error de credenciales con icono de Error (Círculo rojo con X)
                MessageBox.Show(ex.Message, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void label2_Click(object sender, EventArgs e)
        {
            // Mensaje con el icono de información (el círculo con la "i")
            MessageBox.Show("El registro de oficiales es gestionado únicamente por el Administrador Central de la PSA.\n\nPor favor, contacte a su superior para obtener sus credenciales de acceso.",
                            "Aviso de Seguridad",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Método para la recuperación de contraseña
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
            // Hace que el cursor aparezca directamente en el campo de usuario
            txtUsuario.Select();
        }
    }
}