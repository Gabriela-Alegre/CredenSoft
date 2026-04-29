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
            lblGestionDeCredenciales.Font = new Font("Gabriola", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDeCredenciales.Location = new Point(36, 9);
            lblGestionDeCredenciales.Margin = new Padding(4, 0, 4, 0);
            lblGestionDeCredenciales.Name = "lblGestionDeCredenciales";
            lblGestionDeCredenciales.Size = new Size(283, 59);
            lblGestionDeCredenciales.TabIndex = 0;
            lblGestionDeCredenciales.Text = "Gestion de Credenciales";
            // 
            // btnNueva
            // 
            btnNueva.BackColor = SystemColors.ActiveCaption;
            btnNueva.Location = new Point(36, 472);
            btnNueva.Margin = new Padding(4, 3, 4, 3);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(88, 27);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click_1;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkSeaGreen;
            btnVer.Location = new Point(165, 471);
            btnVer.Margin = new Padding(4, 3, 4, 3);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(88, 27);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(613, 471);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvCredenciales
            // 
            dgvCredenciales.AllowUserToAddRows = false;
            dgvCredenciales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCredenciales.Columns.AddRange(new DataGridViewColumn[] { colcredencial, colUsuario, colFechaDeEmision, colFechaDeVencimiento, colEstado });
            dgvCredenciales.Location = new Point(36, 60);
            dgvCredenciales.Margin = new Padding(4, 3, 4, 3);
            dgvCredenciales.Name = "dgvCredenciales";
            dgvCredenciales.Size = new Size(665, 374);
            dgvCredenciales.TabIndex = 4;
            // 
            // colcredencial
            // 
            colcredencial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colcredencial.HeaderText = "ID Credencial";
            colcredencial.Name = "colcredencial";
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            // 
            // colFechaDeEmision
            // 
            colFechaDeEmision.HeaderText = "Fecha de Emision";
            colFechaDeEmision.Name = "colFechaDeEmision";
            // 
            // colFechaDeVencimiento
            // 
            colFechaDeVencimiento.HeaderText = "Fecha de Vencimiento";
            colFechaDeVencimiento.Name = "colFechaDeVencimiento";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            // 
            // FrmCredenciales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnVer);
            Controls.Add(btnNueva);
            Controls.Add(dgvCredenciales);
            Controls.Add(btnEliminar);
            Controls.Add(lblGestionDeCredenciales);
            Margin = new Padding(4, 3, 4, 3);
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