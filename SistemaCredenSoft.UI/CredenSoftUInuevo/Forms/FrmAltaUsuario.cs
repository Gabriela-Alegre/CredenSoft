using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesNegocio;
using ModelsEntidades;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmAltaUsuario : Form
    {
        UsuarioService _usuarioService =
            new UsuarioService(new CredenSoftContext());

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDni.Text,
                    Email = txtEmail.Text,
                    IdRol = (int)cmbRol.SelectedValue
                };

                _usuarioService.RegistrarUsuario(
                    nuevo,
                    txtContrasenia.Text);

                MessageBox.Show("Usuario registrado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}