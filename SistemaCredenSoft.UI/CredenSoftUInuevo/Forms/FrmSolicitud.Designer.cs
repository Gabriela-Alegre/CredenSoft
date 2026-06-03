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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.BackgroundColor = Color.WhiteSmoke;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(20, 93);
            dgvSolicitudes.Margin = new Padding(6, 5, 6, 5);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(1329, 507);
            dgvSolicitudes.TabIndex = 0;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = SystemColors.ActiveCaption;
            btnNueva.Location = new Point(20, 625);
            btnNueva.Margin = new Padding(6, 5, 6, 5);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(210, 55);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(480, 625);
            btnEliminar.Margin = new Padding(6, 5, 6, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(210, 55);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Lavender;
            btnVer.Location = new Point(250, 625);
            btnVer.Margin = new Padding(6, 5, 6, 5);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(210, 55);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(306, 32);
            label1.TabIndex = 4;
            label1.Text = "LISTADO DE SOLICITUDES";
            // 
            // FrmSolicitud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 695);
            Controls.Add(label1);
            Controls.Add(btnVer);
            Controls.Add(btnEliminar);
            Controls.Add(btnNueva);
            Controls.Add(dgvSolicitudes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSolicitud";
            Text = "Listado de Solicitudes";
            Load += FrmSolicitud_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
        private Label label1;
    }
}