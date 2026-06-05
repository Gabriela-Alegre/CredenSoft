using ModelsEntidades;
using System;
using System.Windows.Forms;
using ServicesNegocio;
using DataEF;

namespace CredenSoftUInuevo.Forms
{
    public partial class FrmUsuarios : Form
    {
        // Servicio para traer los datos
        UsuarioService _usuarioService = new UsuarioService(new CredenSoftContext());

        public FrmUsuarios()
        {
            InitializeComponent();
            ConfigurarGrilla();

            // Recuperamos minimizar/maximizar
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Activated += FrmUsuarios_Activated;
        }

        private void ConfigurarGrilla()
        {
            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.ReadOnly = true;
            dgvUsuario.AllowUserToAddRows = false;

            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.MultiSelect = false;

            dgvUsuario.CellFormatting += dgvUsuario_CellFormatting;
        }


        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Refrescar siempre al volver al formulario
        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            try
            {
                var lista = _usuarioService.ObtenerTodos();

                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frm = new FrmAltaUsuario();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarGrilla();
            }
        }

        // =====================================================
        // BAJA LÓGICA DE USUARIO
        // =====================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                if (usuario == null)
                {
                    MessageBox.Show("No se pudo obtener el usuario seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    $"¿Desea dar de baja al usuario {usuario.Nombre} {usuario.Apellido}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    _usuarioService.BajaLogicaUsuario(usuario.IdUsuario);

                    MessageBox.Show("Usuario dado de baja correctamente.", "CredenSoft",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // EDICIÓN DE USUARIO
        // =====================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                if (usuario == null)
                {
                    MessageBox.Show("No se pudo obtener el usuario seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmEditarUsuario frm = new FrmEditarUsuario(usuario);

                // IMPORTANTE: FrmEditarUsuario debe devolver DialogResult.OK al guardar
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
