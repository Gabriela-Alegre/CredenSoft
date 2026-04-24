using ModelsEntidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicesNegocio; // Asegurate que este using esté
using DataEF;         // Y este también

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmUsuarios : Form
    {
        // Creamos el servicio para traer los datos
        UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmUsuarios()
        {
            InitializeComponent();
            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            this.dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.ReadOnly = true; // Mejor dejarlo en true si usás ventana de Alta/Editar
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.CellFormatting += dgvUsuario_CellFormatting;
        }

        // Este es el evento que se ejecuta al abrir la ventana
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                // Traemos la lista real de la base de datos
                var lista = _usuarioService.ObtenerTodos();
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frm = new FrmAltaUsuario();
            frm.ShowDialog();
            CargarGrilla(); // Recargamos para ver al nuevo usuario
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsuario.Columns[e.ColumnIndex].Name == "colRol")
            {
                var usuario = dgvUsuario.Rows[e.RowIndex].DataBoundItem as Usuario;
                if (usuario != null && usuario.Rol != null)
                {
                    e.Value = usuario.Rol.NombreRol;
                }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}