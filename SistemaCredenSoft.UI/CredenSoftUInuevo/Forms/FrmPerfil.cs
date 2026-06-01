using ModelsEntidades;
using System;
using System.Windows.Forms;
using DataEF;
using ServicesNegocio;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmPerfil : Form
    {
        private CredenSoftContext _context;

        public FrmPerfil()
        {
            InitializeComponent();

            // Crear contexto una sola vez
            _context = new CredenSoftContext();
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

            // DATOS EDITABLES
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtEmail.Text = usuario.Email;

            // DATOS NO EDITABLES
            txtUsuario.Text = usuario.IdUsuario.ToString();
            txtDni.Text = usuario.Dni;
            txtRol.Text = usuario.Rol.NombreRol;
        }

        // =========================
        // GUARDAR PERFIL
        // =========================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
                return;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UsuarioService servicio = new UsuarioService(_context);

                Usuario usuarioEditado = new Usuario
                {
                    IdUsuario = usuario.IdUsuario,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Dni = usuario.Dni
                };

                servicio.ActualizarUsuarioCompleto(usuarioEditado);

                // Actualizar sesión
                usuario.Nombre = usuarioEditado.Nombre;
                usuario.Apellido = usuarioEditado.Apellido;
                usuario.Email = usuarioEditado.Email;

                MessageBox.Show(
                    "Perfil actualizado correctamente",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // CAMBIAR CONTRASEÑA
        // =========================
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
                return;

            if (string.IsNullOrWhiteSpace(txtNuevaContrasenia.Text))
            {
                MessageBox.Show(
                    "Ingrese una contraseña",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UsuarioService servicio = new UsuarioService(_context);

                servicio.RecuperarContrasenia(
                    usuario.Email,
                    usuario.Dni,
                    txtNuevaContrasenia.Text
                );

                MessageBox.Show(
                    "Contraseña actualizada",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNuevaContrasenia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
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