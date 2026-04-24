using System;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;
using System.Drawing;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaUsuario : Form
    {
        UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmAltaUsuario()
        {
            InitializeComponent();
            // Conectamos los eventos para que se limpien al escribir
            VincularEventosLimpieza();
        }

        // MÉTODO PARA VINCULAR EVENTOS 
        private void VincularEventosLimpieza()
        {
            txtNombre.TextChanged += LimpiarErrorAlEscribir;
            txtApellido.TextChanged += LimpiarErrorAlEscribir;
            txtDni.TextChanged += LimpiarErrorAlEscribir;
            txtEmail.TextChanged += LimpiarErrorAlEscribir;
            txtContrasenia.TextChanged += LimpiarErrorAlEscribir;

            // Para los ComboBox usamos SelectedIndexChanged
            cmbRol.SelectedIndexChanged += LimpiarErrorAlEscribir;
            cmbEstado.SelectedIndexChanged += LimpiarErrorAlEscribir;
        }

        
        private void LimpiarErrorAlEscribir(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (!string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.BackColor = Color.White;
                    errorProvider1.SetError(tb, "");
                }
            }
            else if (sender is ComboBox cb)
            {
                if (cb.SelectedIndex != -1)
                {
                    errorProvider1.SetError(cb, "");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ResetearColores();

            try
            {
                bool hayError = false;

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                    txtNombre.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    errorProvider1.SetError(txtApellido, "El apellido es obligatorio");
                    txtApellido.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    errorProvider1.SetError(txtDni, "El DNI es obligatorio");
                    txtDni.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "El email es obligatorio");
                    txtEmail.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    errorProvider1.SetError(txtContrasenia, "La contraseña es obligatoria");
                    txtContrasenia.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (cmbRol.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbRol, "Debe seleccionar un rol");
                    hayError = true;
                }

                if (cmbEstado.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbEstado, "Debe seleccionar un estado");
                    hayError = true;
                }

                if (hayError)
                {
                    MessageBox.Show("Por favor, complete los campos resaltados.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDni.Text,
                    Email = txtEmail.Text,
                    Estado = cmbEstado.SelectedItem.ToString(),
                    IdRol = cmbRol.SelectedIndex + 1
                };

                _usuarioService.RegistrarUsuario(nuevo, txtContrasenia.Text);

                MessageBox.Show("Usuario registrado con éxito.", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetearColores()
        {
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtDni.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}