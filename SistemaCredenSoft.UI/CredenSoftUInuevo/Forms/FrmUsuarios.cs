using ModelsEntidades;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            // --- CONFIGURACIÓN DE LA GRILLA ---

            // Hace que las columnas ocupen todo el ancho del formulario automáticamente
            this.dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Permite que el usuario pueda escribir en las celdas
            this.dgvUsuario.ReadOnly = false;

            // Permite empezar a editar solo con tocar una tecla o F2
            this.dgvUsuario.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Muestra una fila vacía al final para agregar usuarios nuevos rápidamente
            this.dgvUsuario.AllowUserToAddRows = true;

            // Conectamos el evento para mostrar el nombre del rol correctamente
            this.dgvUsuario.CellFormatting += dgvUsuario_CellFormatting;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario de alta
            FrmAltaUsuario frm = new FrmAltaUsuario();

            // Lo mostramos como cuadro de diálogo
            frm.ShowDialog();
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos que la columna sea la de 'Rol' por su nombre en el Designer
            if (dgvUsuario.Columns[e.ColumnIndex].Name == "colRol")
            {
                var usuario = dgvUsuario.Rows[e.RowIndex].DataBoundItem as Usuario;

                if (usuario != null && usuario.Rol != null)
                {
                    // Mostramos el nombre del Rol (ej: "Admin") en lugar del objeto técnico
                    e.Value = usuario.Rol.NombreRol;
                }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento para detectar clics en celdas específicas si lo necesitás a futuro
        }
    }
}