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
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            // Validación visual (HU 05)
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { MarcarError(txtEmail); hayError = true; }
            if (string.IsNullOrWhiteSpace(txtDni.Text)) { MarcarError(txtDni); hayError = true; }
            if (string.IsNullOrWhiteSpace(txtNuevaContrasenia.Text)) { MarcarError(txtNuevaContrasenia); hayError = true; }

            if (hayError)
            {
                MessageBox.Show("Por favor, complete los datos para la recuperación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _usuarioService.RecuperarContrasenia(txtEmail.Text, txtDni.Text, txtNuevaContrasenia.Text);

                // --- INTEGRACIÓN MENSAJE VERDE ---
               
                lblMensajeExito.Text = "✔ Se ha enviado un enlace de recuperación.";
                lblMensajeExito.ForeColor = Color.DarkGreen;
                lblMensajeExito.BackColor = Color.Honeydew;
                lblMensajeExito.Visible = true;

                // HU 05: Éxito
                MessageBox.Show("Contraseña actualizada con éxito. Se envió un correo de confirmación.",
                                "Recuperación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                
                lblMensajeExito.Visible = false;

                // HU 05: Error (X roja)
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Si el usuario vuelve a escribir, ocultamos el label
            lblMensajeExito.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números en el DNI
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmRecuperarContrasenia_Load(object sender, EventArgs e)
        {
            // Aseguramos que el label de éxito esté oculto al abrir el form
            lblMensajeExito.Visible = false;
        }
    }
}