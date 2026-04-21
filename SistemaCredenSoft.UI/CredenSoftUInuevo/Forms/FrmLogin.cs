using DataEF;
using ModelsEntidades;
using ServicesNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmLogin : Form
    {
        // Inicializamos el servicio apuntando al contexto de datos
        private readonly UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Código opcional al cargar
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentamos el login con los datos de los TextBox
                var usuario = _usuarioService.Login(
                    txtUsuario.Text,
                    txtContrasenia.Text);

                // Si llegamos aquí es porque el login fue exitoso
                SesionActual.UsuarioLogueado = usuario;

                // Abrimos el Dashboard
                FrmDashboard frm = new FrmDashboard();
                frm.Show();

                // Ocultamos el Login
                this.Hide();
            }
            catch (Exception ex)
            {
                // Si el servicio lanza una excepción (usuario no encontrado, etc.)
                MessageBox.Show(ex.Message, "Error de Acceso");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
        }
    }
}