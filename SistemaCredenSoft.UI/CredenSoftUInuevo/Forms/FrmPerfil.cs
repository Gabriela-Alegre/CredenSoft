using ModelsEntidades;
using System;
using System.Windows.Forms;
using DataEF; // 👈 IMPORTANTE (tu DbContext está acá)
using ServicesNegocio;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmPerfil : Form
    {
        private CredenSoftContext _context;

        public FrmPerfil()
        {
            InitializeComponent();

            // 🔥 CREÁS EL CONTEXTO UNA SOLA VEZ
            _context = new CredenSoftContext();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioLogueado;

            if (usuario == null)
            {
                MessageBox.Show("No hay usuario logueado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Complete todos los campos");
                return;
            }

            try
            {
                UsuarioService servicio = new UsuarioService(_context);

                servicio.ActualizarPerfilPersonal(
                    usuario.IdUsuario,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtEmail.Text
                );

                // 🔥 actualizar sesión también
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;

                MessageBox.Show("Perfil actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                MessageBox.Show("Ingrese una contraseña");
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

                MessageBox.Show("Contraseña actualizada");

                txtNuevaContrasenia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
        }
    }
}