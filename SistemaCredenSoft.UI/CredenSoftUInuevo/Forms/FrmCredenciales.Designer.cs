namespace CredenSoftUInuevo.Forms
{
    partial class FrmCredenciales
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
            lblGestionDeCredenciales = new Label();
            btnNueva = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            dgvCredenciales = new DataGridView();
            colcredencial = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colFechaDeEmision = new DataGridViewTextBoxColumn();
            colFechaDeVencimiento = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCredenciales).BeginInit();
            SuspendLayout();
            // 
            // lblGestionDeCredenciales
            // 
            lblGestionDeCredenciales.AutoSize = true;
            lblGestionDeCredenciales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDeCredenciales.ForeColor = Color.FromArgb(28, 78, 128);
            lblGestionDeCredenciales.Location = new Point(51, 26);
            lblGestionDeCredenciales.Margin = new Padding(6, 0, 6, 0);
            lblGestionDeCredenciales.Name = "lblGestionDeCredenciales";
            lblGestionDeCredenciales.Size = new Size(287, 32);
            lblGestionDeCredenciales.TabIndex = 0;
            lblGestionDeCredenciales.Text = "Gestion de Credenciales";
            // 
            // btnNueva
            // 
            btnNueva.BackColor = SystemColors.ActiveCaption;
            btnNueva.Location = new Point(51, 785);
            btnNueva.Margin = new Padding(6, 5, 6, 5);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(210, 55);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click_1;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Lavender;
            btnVer.Location = new Point(277, 785);
            btnVer.Margin = new Padding(6, 5, 6, 5);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(210, 55);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(499, 785);
            btnEliminar.Margin = new Padding(6, 5, 6, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 55);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvCredenciales
            // 
            dgvCredenciales.AllowUserToAddRows = false;
            dgvCredenciales.BackgroundColor = Color.WhiteSmoke;
            dgvCredenciales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCredenciales.Columns.AddRange(new DataGridViewColumn[] { colcredencial, colUsuario, colFechaDeEmision, colFechaDeVencimiento, colEstado });
            dgvCredenciales.Location = new Point(51, 100);
            dgvCredenciales.Margin = new Padding(6, 5, 6, 5);
            dgvCredenciales.Name = "dgvCredenciales";
            dgvCredenciales.RowHeadersWidth = 62;
            dgvCredenciales.Size = new Size(1047, 623);
            dgvCredenciales.TabIndex = 4;
            // 
            // colcredencial
            // 
            colcredencial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colcredencial.HeaderText = "ID Credencial";
            colcredencial.MinimumWidth = 8;
            colcredencial.Name = "colcredencial";
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 8;
            colUsuario.Name = "colUsuario";
            colUsuario.Width = 150;
            // 
            // colFechaDeEmision
            // 
            colFechaDeEmision.HeaderText = "Fecha de Emision";
            colFechaDeEmision.MinimumWidth = 8;
            colFechaDeEmision.Name = "colFechaDeEmision";
            colFechaDeEmision.Width = 150;
            // 
            // colFechaDeVencimiento
            // 
            colFechaDeVencimiento.HeaderText = "Fecha de Vencimiento";
            colFechaDeVencimiento.MinimumWidth = 8;
            colFechaDeVencimiento.Name = "colFechaDeVencimiento";
            colFechaDeVencimiento.Width = 150;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 8;
            colEstado.Name = "colEstado";
            colEstado.Width = 150;
            // 
            // FrmCredenciales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(btnVer);
            Controls.Add(btnNueva);
            Controls.Add(dgvCredenciales);
            Controls.Add(btnEliminar);
            Controls.Add(lblGestionDeCredenciales);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmCredenciales";
            Text = "FrmCredenciales";
            ((System.ComponentModel.ISupportInitialize)dgvCredenciales).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionDeCredenciales;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCredenciales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcredencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}