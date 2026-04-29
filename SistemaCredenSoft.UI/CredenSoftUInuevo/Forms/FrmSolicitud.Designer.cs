namespace CredenSoftUInuevo.Forms
{
    partial class FrmSolicitud
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
            dgvSolicitudes = new DataGridView();
            btnNueva = new Button();
            btnEliminar = new Button();
            btnVer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(14, 14);
            dgvSolicitudes.Margin = new Padding(4, 3, 4, 3);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.Size = new Size(653, 346);
            dgvSolicitudes.TabIndex = 0;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = SystemColors.ActiveCaption;
            btnNueva.Location = new Point(14, 375);
            btnNueva.Margin = new Padding(4, 3, 4, 3);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(88, 27);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(200, 70, 34);
            btnEliminar.Location = new Point(583, 375);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.DarkSeaGreen;
            btnVer.Location = new Point(121, 375);
            btnVer.Margin = new Padding(4, 3, 4, 3);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(88, 27);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // FrmSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(btnVer);
            Controls.Add(btnEliminar);
            Controls.Add(btnNueva);
            Controls.Add(dgvSolicitudes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSolicitud";
            Text = "Listado de Solicitudes";
            Load += FrmSolicitud_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
    }
}