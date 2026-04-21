namespace CredenSoftUInuevo.Forms
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGestionDeUsuarios = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvUsuario = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            ColDni = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblGestionDeUsuarios
            // 
            lblGestionDeUsuarios.AutoSize = true;
            lblGestionDeUsuarios.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDeUsuarios.Location = new Point(4, 10);
            lblGestionDeUsuarios.Margin = new Padding(4, 0, 4, 0);
            lblGestionDeUsuarios.Name = "lblGestionDeUsuarios";
            lblGestionDeUsuarios.Size = new Size(279, 31);
            lblGestionDeUsuarios.TabIndex = 0;
            lblGestionDeUsuarios.Text = "Gestion de Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(215, 73);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(127, 73);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 27);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(40, 73);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(88, 27);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellido, ColDni, colEmail, colRol, colEstado });
            dgvUsuario.Location = new Point(40, 123);
            dgvUsuario.Margin = new Padding(4, 3, 4, 3);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(755, 173);
            dgvUsuario.TabIndex = 4;
            dgvUsuario.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            // 
            // ColDni
            // 
            ColDni.HeaderText = "DNI";
            ColDni.Name = "ColDni";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colRol
            // 
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dgvUsuario);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblGestionDeUsuarios);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionDeUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}