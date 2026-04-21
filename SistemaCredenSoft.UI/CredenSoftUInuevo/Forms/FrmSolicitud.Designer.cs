namespace CredenSoftUInuevo.Forms
{
    partial class FrmSolicitudes
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
            this.lblGestionDeSolicitudes = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionDeSolicitudes
            // 
            this.lblGestionDeSolicitudes.AutoSize = true;
            this.lblGestionDeSolicitudes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblGestionDeSolicitudes.Location = new System.Drawing.Point(12, 9);
            this.lblGestionDeSolicitudes.Name = "lblGestionDeSolicitudes";
            this.lblGestionDeSolicitudes.Size = new System.Drawing.Size(306, 37);
            this.lblGestionDeSolicitudes.TabIndex = 0;
            this.lblGestionDeSolicitudes.Text = "Gestión de Solicitudes";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(76, 78);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(204, 77);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(332, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUsuario,
            this.colTipo,
            this.ColFecha,
            this.colEstado});
            this.dgvSolicitudes.Location = new System.Drawing.Point(76, 144);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(562, 150);
            this.dgvSolicitudes.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // ColFecha
            // 
            this.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            // 
            // colEstado
            // 
            this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // FrmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lblGestionDeSolicitudes);
            this.Name = "FrmSolicitudes";
            this.Text = "Solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionDeSolicitudes;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}