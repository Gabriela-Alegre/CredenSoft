using System;
using System.Windows.Forms;
using System.Drawing;
using ServicesNegocio;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmRecuperarContrasenia : Form
    {
        private readonly UsuarioService _usuarioService;

        public FrmRecuperarContrasenia(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;

            // Configuración inicial de visibilidad
            ConfigurarPasswordChar(txtNuevaContrasenia, picVerContrasenia);
            ConfigurarPasswordChar(txtConfirmarContrasenia, picVerConfirmarContrasenia);
        }

        private void ConfigurarPasswordChar(TextBox txt, PictureBox pic)
        {
            txt.UseSystemPasswordChar = false;
            txt.PasswordChar = '*';
            pic.Image = Properties.Resources.ojo_cerrado;
            pic.BringToFront();
        }

        // Evento para el ojo de Nueva Contraseña
        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            GestionarVisibilidad(txtNuevaContrasenia, picVerContrasenia);
        }

        // Evento para el ojo de Confirmar Contraseña
        private void picVerConfirmarContrasenia_Click(object sender, EventArgs e)
        {
            GestionarVisibilidad(txtConfirmarContrasenia, picVerConfirmarContrasenia);
        }

        private void GestionarVisibilidad(TextBox txt, PictureBox pic)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                pic.Image = Properties.Resources.ojo_abierto;
            }
            else
            {
                txt.PasswordChar = '*';
                pic.Image = Properties.Resources.ojo_cerrado;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { MarcarError(txtEmail); hayError = true; }
            if (string.IsNullOrWhiteSpace(txtDni.Text)) { MarcarError(txtDni); hayError = true; }
            if (string.IsNullOrWhiteSpace(txtNuevaContrasenia.Text)) { MarcarError(txtNuevaContrasenia); hayError = true; }
            if (string.IsNullOrWhiteSpace(txtConfirmarContrasenia.Text)) { MarcarError(txtConfirmarContrasenia); hayError = true; }

            if (hayError)
            {
                MessageBox.Show("Por favor, complete los datos para la recuperación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNuevaContrasenia.Text != txtConfirmarContrasenia.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _usuarioService.RecuperarContrasenia(txtEmail.Text, txtDni.Text, txtNuevaContrasenia.Text);

                lblMensajeExito.Text = "✔ Se ha enviado un enlace de recuperación.";
                lblMensajeExito.ForeColor = Color.DarkGreen;
                lblMensajeExito.BackColor = Color.Honeydew;
                lblMensajeExito.Visible = true;

                MessageBox.Show("Contraseña actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                lblMensajeExito.Visible = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarcarError(TextBox txt)
        {
            txt.BackColor = Color.LightPink;
            errorProvider1.SetError(txt, "Campo obligatorio");
        }

        private void LimpiarError_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
                errorProvider1.SetError(txt, "");
            }
            lblMensajeExito.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void FrmRecuperarContrasenia_Load(object sender, EventArgs e) { lblMensajeExito.Visible = false; }
    }
}