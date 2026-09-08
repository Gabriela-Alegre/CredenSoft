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
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.Anchor = AnchorStyles.Left;
            dgvSolicitudes.BackgroundColor = Color.WhiteSmoke;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(14, 35);
            dgvSolicitudes.Margin = new Padding(4, 3, 4, 3);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(818, 278);
            dgvSolicitudes.TabIndex = 0;
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.Bottom;
            btnNueva.BackColor = Color.MediumSeaGreen;
            btnNueva.Font = new Font("Segoe UI", 13F);
            btnNueva.Location = new Point(49, 319);
            btnNueva.Margin = new Padding(4, 3, 4, 3);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(155, 49);
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
            btnEliminar.Location = new Point(569, 319);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 49);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Inactivar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom;
            btnVer.BackColor = Color.Lavender;
            btnVer.Font = new Font("Segoe UI", 13F);
            btnVer.Location = new Point(227, 319);
            btnVer.Margin = new Padding(4, 3, 4, 3);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(149, 49);
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
            label1.Location = new Point(14, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 4;
            label1.Text = "LISTADO DE SOLICITUDES";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Font = new Font("Segoe UI", 13F);
            btnEditar.Location = new Point(395, 319);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 389);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(btnVer);
            Controls.Add(btnEliminar);
            Controls.Add(btnNueva);
            Controls.Add(dgvSolicitudes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
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
        private Button btnEditar;
    }
}