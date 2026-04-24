using System;
using System.Windows.Forms;
using ServicesNegocio;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmRecuperarContrasenia : Form
    {
        private readonly UsuarioService _usuarioService;

        // Recibimos el servicio para poder usar la lógica del Back
        public FrmRecuperarContrasenia(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que no haya nada vacío
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text) ||
                    string.IsNullOrWhiteSpace(txtNuevaContrasenia.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Atención");
                    return;
                }

                // Llamamos a la función de Xime
                _usuarioService.RecuperarContrasenia(
                    txtEmail.Text,
                    txtDni.Text,
                    txtNuevaContrasenia.Text
                );

                MessageBox.Show("Contraseña actualizada con éxito.", "¡Listo!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Si el mail o DNI no existen, salta este error
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FrmRecuperarContrasenia_Load(object sender, EventArgs e)
        {
        }
    }
}