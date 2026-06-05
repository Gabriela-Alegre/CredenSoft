namespace CredenSoftUInuevo.Forms
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            lblGestionDeUsuarios.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDeUsuarios.ForeColor = Color.FromArgb(28, 78, 128);
            lblGestionDeUsuarios.Location = new Point(46, 24);
            lblGestionDeUsuarios.Margin = new Padding(6, 0, 6, 0);
            lblGestionDeUsuarios.Name = "lblGestionDeUsuarios";
            lblGestionDeUsuarios.Size = new Size(327, 38);
            lblGestionDeUsuarios.TabIndex = 0;
            lblGestionDeUsuarios.Text = "GESTIÒN DE USUARIOS";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(546, 981);
            btnEliminar.Margin = new Padding(6, 5, 6, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 55);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.Location = new Point(296, 981);
            btnEditar.Margin = new Padding(6, 5, 6, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(210, 55);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaption;
            btnNuevo.Location = new Point(46, 981);
            btnNuevo.Margin = new Padding(6, 5, 6, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(210, 55);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.BackgroundColor = Color.White;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellido, ColDni, colEmail, colRol, colEstado });
            dgvUsuario.Location = new Point(46, 97);
            dgvUsuario.Margin = new Padding(6, 5, 6, 5);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersWidth = 62;
            dgvUsuario.Size = new Size(1373, 552);
            dgvUsuario.TabIndex = 3;
            dgvUsuario.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 8;
            colApellido.Name = "colApellido";
            // 
            // ColDni
            // 
            ColDni.DataPropertyName = "Dni";
            ColDni.HeaderText = "DNI";
            ColDni.MinimumWidth = 8;
            ColDni.Name = "ColDni";
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            // 
            // colRol
            // 
            colRol.HeaderText = "Rol";
            colRol.MinimumWidth = 8;
            colRol.Name = "colRol";
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 1050);
            Controls.Add(dgvUsuario);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblGestionDeUsuarios);
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            Text = "Usuarios - CredenSoft";
            WindowState = FormWindowState.Maximized;
            Activated += FrmUsuarios_Activated;
            Load += FrmUsuarios_Load;
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