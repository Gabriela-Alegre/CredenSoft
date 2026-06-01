using System;
using System.Windows.Forms;
using ModelsEntidades;
using ServicesNegocio;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmEditarUsuario : Form
    {
        private Usuario _usuario;
        private UsuarioService _usuarioService;

        public FrmEditarUsuario(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;
            _usuarioService = new UsuarioService(new CredenSoftContext());
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar Roles
                cmbRol.DataSource = _usuarioService.ObtenerTodosLosRoles();
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";

                // Cargar datos del usuario
                txtNombre.Text = _usuario.Nombre;
                txtApellido.Text = _usuario.Apellido;
                txtDni.Text = _usuario.Dni;
                txtEmail.Text = _usuario.Email;

                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("Activo");
                cmbEstado.Items.Add("Inactivo");

                cmbRol.SelectedValue = _usuario.IdRol;
                cmbEstado.Text = _usuario.Estado;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                _usuario.Nombre = txtNombre.Text.Trim();
                _usuario.Apellido = txtApellido.Text.Trim();
                _usuario.Dni = txtDni.Text.Trim();
                _usuario.Email = txtEmail.Text.Trim();

                _usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
                _usuario.Estado = cmbEstado.Text;

                _usuarioService.ActualizarUsuarioCompleto(_usuario);

                MessageBox.Show(
                    "Usuario actualizado correctamente.",
                    "CredenSoft",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}