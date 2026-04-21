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
            this.lblGestionDeCredenciales = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCredenciales = new System.Windows.Forms.DataGridView();
            this.colcredencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDeEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionDeCredenciales
            // 
            this.lblGestionDeCredenciales.AutoSize = true;
            this.lblGestionDeCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionDeCredenciales.Location = new System.Drawing.Point(25, 19);
            this.lblGestionDeCredenciales.Name = "lblGestionDeCredenciales";
            this.lblGestionDeCredenciales.Size = new System.Drawing.Size(334, 31);
            this.lblGestionDeCredenciales.TabIndex = 0;
            this.lblGestionDeCredenciales.Text = "Gestion de Credenciales";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(68, 66);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click_1);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(178, 65);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 65);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvCredenciales
            // 
            this.dgvCredenciales.AllowUserToAddRows = false;
            this.dgvCredenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredenciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcredencial,
            this.colUsuario,
            this.colFechaDeEmision,
            this.colFechaDeVencimiento,
            this.colEstado});
            this.dgvCredenciales.Location = new System.Drawing.Point(31, 116);
            this.dgvCredenciales.Name = "dgvCredenciales";
            this.dgvCredenciales.Size = new System.Drawing.Size(570, 150);
            this.dgvCredenciales.TabIndex = 4;
            // 
            // colcredencial
            // 
            this.colcredencial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colcredencial.HeaderText = "ID Credencial";
            this.colcredencial.Name = "colcredencial";
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colFechaDeEmision
            // 
            this.colFechaDeEmision.HeaderText = "Fecha de Emision";
            this.colFechaDeEmision.Name = "colFechaDeEmision";
            // 
            // colFechaDeVencimiento
            // 
            this.colFechaDeVencimiento.HeaderText = "Fecha de Vencimiento";
            this.colFechaDeVencimiento.Name = "colFechaDeVencimiento";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // FrmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCredenciales);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lblGestionDeCredenciales);
            this.Name = "FrmCredenciales";
            this.Text = "FrmCredenciales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredenciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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