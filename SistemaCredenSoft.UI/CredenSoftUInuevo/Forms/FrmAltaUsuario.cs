using System;
using System.Drawing;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaUsuario : Form
    {
        // Servicio de negocio para gestionar los usuarios
        private readonly UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmAltaUsuario()
        {
            InitializeComponent();
            VincularEventosLimpieza();

            
            // Desactivamos el carácter de sistema para que el código tenga el control total
            txtContrasenia.UseSystemPasswordChar = false;
            txtConfirmarContrasenia.UseSystemPasswordChar = false;

            // Seteamos el asterisco como máscara inicial
            txtContrasenia.PasswordChar = '*';
            txtConfirmarContrasenia.PasswordChar = '*';

            // Carga de imágenes iniciales
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;

            // Aseguramos que los ojos estén por encima de los cuadros de texto
            picVerContrasenia.BringToFront();
            picVerConfirmarContrasenia.BringToFront();
        }

        private void VincularEventosLimpieza()
        {
            txtNombre.TextChanged += LimpiarErrorAlEscribir;
            txtApellido.TextChanged += LimpiarErrorAlEscribir;
            txtDni.TextChanged += LimpiarErrorAlEscribir;
            txtEmail.TextChanged += LimpiarErrorAlEscribir;
            txtContrasenia.TextChanged += LimpiarErrorAlEscribir;
            txtConfirmarContrasenia.TextChanged += LimpiarErrorAlEscribir;
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

        // --- LÓGICA DE VISIBILIDAD (COMO EN TU LOGIN) ---

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.PasswordChar == '*')
            {
                txtContrasenia.PasswordChar = '\0'; // Muestra la contraseña
                picVerContrasenia.Image = Properties.Resources.ojo_abierto;
            }
            else
            {
                txtContrasenia.PasswordChar = '*'; // Oculta la contraseña
                picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            }
        }

        private void picVerConfirmarContrasenia_Click(object sender, EventArgs e)
        {
            if (txtConfirmarContrasenia.PasswordChar == '*')
            {
                txtConfirmarContrasenia.PasswordChar = '\0';
                picVerConfirmarContrasenia.Image = Properties.Resources.ojo_abierto;
            }
            else
            {
                txtConfirmarContrasenia.PasswordChar = '*';
                picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;
            }
        }

        // --- ACCIONES DE GUARDADO ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ResetearColores();

            try
            {
                bool hayError = false;

                if (string.IsNullOrWhiteSpace(txtNombre.Text)) { errorProvider1.SetError(txtNombre, "Nombre obligatorio"); txtNombre.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) { errorProvider1.SetError(txtApellido, "Apellido obligatorio"); txtApellido.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtDni.Text)) { errorProvider1.SetError(txtDni, "DNI obligatorio"); txtDni.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) { errorProvider1.SetError(txtEmail, "Email obligatorio"); txtEmail.BackColor = Color.LightPink; hayError = true; }

                if (string.IsNullOrWhiteSpace(txtContrasenia.Text)) { errorProvider1.SetError(txtContrasenia, "Contraseña obligatoria"); txtContrasenia.BackColor = Color.LightPink; hayError = true; }

                if (txtContrasenia.Text != txtConfirmarContrasenia.Text)
                {
                    errorProvider1.SetError(txtConfirmarContrasenia, "Las contraseñas no coinciden");
                    txtConfirmarContrasenia.BackColor = Color.LightPink;
                    hayError = true;
                }

                if (cmbRol.SelectedIndex == -1) { errorProvider1.SetError(cmbRol, "Seleccione un rol"); hayError = true; }
                if (cmbEstado.SelectedIndex == -1) { errorProvider1.SetError(cmbEstado, "Seleccione un estado"); hayError = true; }

                if (hayError) return;

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

                MessageBox.Show("Usuario registrado con éxito.", "CredenSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetearColores()
        {
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtDni.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
            txtConfirmarContrasenia.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;
        }
    }
}