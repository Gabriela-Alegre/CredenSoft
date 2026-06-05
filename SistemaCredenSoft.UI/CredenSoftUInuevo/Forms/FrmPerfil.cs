using ModelsEntidades;
using System;
using System.Windows.Forms;
using DataEF;
using ServicesNegocio;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmPerfil : Form
    {
        private CredenSoftContext _context;

        public FrmPerfil()
        {
            InitializeComponent();

            _context = new CredenSoftContext();

            // IMPORTANTE
            this.Load += FrmPerfil_Load;

            // Validación visual HU09
            txtNombre.TextChanged += LimpiarColorError;
            txtApellido.TextChanged += LimpiarColorError;
            txtEmail.TextChanged += LimpiarColorError;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
            {
                MessageBox.Show(
                    "No hay usuario logueado",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtEmail.Text = usuario.Email;

            txtUsuario.Text = usuario.IdUsuario.ToString();
            txtDni.Text = usuario.Dni;

            if (usuario.Rol != null)
                txtRol.Text = usuario.Rol.NombreRol;
        }
        private void LimpiarColorError(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
                return;

            // Restaurar colores normales
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtEmail.BackColor = Color.White;

            bool hayErrores = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.MistyRose;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.BackColor = Color.MistyRose;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.MistyRose;
                hayErrores = true;
            }

            if (hayErrores)
            {
                MessageBox.Show(
                    "Complete todos los campos obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string patronEmail =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), patronEmail))
            {
                txtEmail.BackColor = Color.MistyRose;

                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            try
            {
                UsuarioService servicio =
                    new UsuarioService(_context);

                Usuario usuarioEditado = new Usuario
                {
                    IdUsuario = usuario.IdUsuario,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Dni = usuario.Dni,
                    IdRol = usuario.IdRol,
                    Estado = usuario.Estado
                };

                servicio.ActualizarUsuarioCompleto(usuarioEditado);

                usuario.Nombre = usuarioEditado.Nombre;
                usuario.Apellido = usuarioEditado.Apellido;
                usuario.Email = usuarioEditado.Email;

                MessageBox.Show(
                    "Perfil actualizado correctamente.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

      
        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
                return;

            if (string.IsNullOrWhiteSpace(txtNuevaContrasenia.Text))
            {
                MessageBox.Show(
                    "Ingrese una nueva contraseña.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UsuarioService servicio =
                    new UsuarioService(_context);

                servicio.RecuperarContrasenia(
                    usuario.Email,
                    usuario.Dni,
                    txtNuevaContrasenia.Text);

                MessageBox.Show(
                    "Contraseña actualizada correctamente.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNuevaContrasenia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}