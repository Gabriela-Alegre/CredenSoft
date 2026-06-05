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

            // Configuración inicial de las contraseñas
            txtContrasenia.UseSystemPasswordChar = false;
            txtConfirmarContrasenia.UseSystemPasswordChar = false;
            txtContrasenia.PasswordChar = '*';
            txtConfirmarContrasenia.PasswordChar = '*';

            // Carga de imágenes iniciales y posición
            picVerContrasenia.Image = Properties.Resources.ojo_cerrado;
            picVerConfirmarContrasenia.Image = Properties.Resources.ojo_cerrado;
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
                    cb.BackColor = Color.White;
                    errorProvider1.SetError(cb, "");
                }
            }
        }

        // --- LÓGICA DE VISIBILIDAD DE CONTRASEÑAS ---

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
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

        // --- ACCIONES DE GUARDADO Y VALIDACIÓN ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ResetearColores();

            try
            {
                bool hayError = false;

                // Validación de campos de texto básicos
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) { errorProvider1.SetError(txtNombre, "Nombre obligatorio"); txtNombre.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) { errorProvider1.SetError(txtApellido, "Apellido obligatorio"); txtApellido.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtDni.Text)) { errorProvider1.SetError(txtDni, "DNI obligatorio"); txtDni.BackColor = Color.LightPink; hayError = true; }
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) { errorProvider1.SetError(txtEmail, "Email obligatorio"); txtEmail.BackColor = Color.LightPink; hayError = true; }

                // Validación de Contraseña
                if (string.IsNullOrWhiteSpace(txtContrasenia.Text)) { errorProvider1.SetError(txtContrasenia, "Contraseña obligatoria"); txtContrasenia.BackColor = Color.LightPink; hayError = true; }

                // Validación de Confirmación de Contraseña
                if (string.IsNullOrWhiteSpace(txtConfirmarContrasenia.Text))
                {
                    errorProvider1.SetError(txtConfirmarContrasenia, "Debe confirmar la contraseña");
                    txtConfirmarContrasenia.BackColor = Color.LightPink;
                    hayError = true;
                }
                else if (txtContrasenia.Text != txtConfirmarContrasenia.Text)
                {
                    errorProvider1.SetError(txtConfirmarContrasenia, "Las contraseñas no coinciden");
                    txtConfirmarContrasenia.BackColor = Color.LightPink;
                    hayError = true;
                }

                // Validación de ComboBoxes
                if (cmbRol.SelectedIndex == -1) { errorProvider1.SetError(cmbRol, "Seleccione un rol"); cmbRol.BackColor = Color.LightPink; hayError = true; }
                if (cmbEstado.SelectedIndex == -1) { errorProvider1.SetError(cmbEstado, "Seleccione un estado"); cmbEstado.BackColor = Color.LightPink; hayError = true; }

                if (hayError) return;

                // Mapeo del objeto Usuario
                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text.Trim().ToUpper(),
                    Apellido = txtApellido.Text.Trim().ToUpper(),
                    Dni = txtDni.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Estado = cmbEstado.SelectedItem.ToString(),
                    IdRol = cmbRol.SelectedIndex + 1
                };

                _usuarioService.RegistrarUsuario(nuevo, txtContrasenia.Text);

                MessageBox.Show("Usuario registrado con éxito.", "CredenSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
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
            cmbRol.BackColor = Color.White;
            cmbEstado.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números en el DNI
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            // Opcional: inicializar el estado en el primer elemento
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;
        }
    }
}