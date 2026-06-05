using System;
using System.Windows.Forms;
using ModelsEntidades;
using ServicesNegocio;
using DataEF;
using System.Text.RegularExpressions;
using System.Linq;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmEditarUsuario : Form
    {
        private Usuario _usuario;
        private UsuarioService _usuarioService;
        private string _estadoOriginal;

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
                _estadoOriginal = _usuario.Estado;
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

                // Validar formato de email
                if (!Regex.IsMatch(
                        txtEmail.Text.Trim(),
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show(
                        "Ingrese un correo electrónico válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    return;
                }

                _usuario.Nombre = txtNombre.Text.Trim();
                _usuario.Apellido = txtApellido.Text.Trim();
                _usuario.Dni = txtDni.Text.Trim();
                _usuario.Email = txtEmail.Text.Trim();

                if (_estadoOriginal != cmbEstado.Text)
                {
                    DialogResult resultado = MessageBox.Show(
                        $"¿Está seguro de cambiar el estado del usuario de {_estadoOriginal} a {cmbEstado.Text}?",
                        "Confirmar cambio de estado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (resultado == DialogResult.No)
                        return;
                }

                _usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
                _usuario.Estado = cmbEstado.Text;

                _usuarioService.ActualizarUsuarioCompleto(_usuario);

                if (SesionActual.UsuarioLogueado != null &&
                    SesionActual.UsuarioLogueado.IdUsuario == _usuario.IdUsuario)
                {
                    SesionActual.UsuarioLogueado.IdRol = _usuario.IdRol;

                    var todosLosRoles = _usuarioService.ObtenerTodosLosRoles();

                    SesionActual.UsuarioLogueado.Rol =
                        todosLosRoles.FirstOrDefault(r => r.IdRol == _usuario.IdRol);
                }

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

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}