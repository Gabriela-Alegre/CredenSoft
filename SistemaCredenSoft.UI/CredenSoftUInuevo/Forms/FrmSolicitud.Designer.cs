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
            dgvSolicitudes.Anchor = AnchorStyles.Left;
            dgvSolicitudes.BackgroundColor = Color.WhiteSmoke;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(20, 59);
            dgvSolicitudes.Margin = new Padding(6, 5, 6, 5);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(1169, 463);
            dgvSolicitudes.TabIndex = 0;
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.Bottom;
            btnNueva.BackColor = SystemColors.ActiveCaption;
            btnNueva.Font = new Font("Segoe UI", 13F);
            btnNueva.Location = new Point(70, 532);
            btnNueva.Margin = new Padding(6, 5, 6, 5);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(222, 81);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 13F);
            btnEliminar.Location = new Point(569, 532);
            btnEliminar.Margin = new Padding(6, 5, 6, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(232, 81);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom;
            btnVer.BackColor = Color.Lavender;
            btnVer.Font = new Font("Segoe UI", 13F);
            btnVer.Location = new Point(324, 532);
            btnVer.Margin = new Padding(6, 5, 6, 5);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(213, 81);
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
            ClientSize = new Size(1226, 648);
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
            StartPosition = FormStartPosition.CenterParent;
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