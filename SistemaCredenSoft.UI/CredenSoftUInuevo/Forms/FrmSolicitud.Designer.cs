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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitud));
            dgvSolicitudes = new DataGridView();
            btnNueva = new Button();
            btnEliminar = new Button();
            btnVer = new Button();
            label1 = new Label();
            btnEditar = new Button();
            lblBuscarDni = new Label();
            txtBuscarDni = new TextBox();
            btnBuscarDni = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.Anchor = AnchorStyles.Left;
            dgvSolicitudes.BackgroundColor = Color.WhiteSmoke;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(14, 107);
            dgvSolicitudes.Margin = new Padding(4, 3, 4, 3);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 62;
            dgvSolicitudes.Size = new Size(848, 273);
            dgvSolicitudes.TabIndex = 0;
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.Bottom;
            btnNueva.BackColor = Color.MediumSeaGreen;
            btnNueva.Font = new Font("Segoe UI", 13F);
            btnNueva.Location = new Point(57, 393);
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
            btnEliminar.Location = new Point(577, 393);
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
            btnVer.Location = new Point(235, 393);
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
            label1.Location = new Point(8, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 4;
            label1.Text = "LISTADO DE SOLICITUDES";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Font = new Font("Segoe UI", 13F);
            btnEditar.Location = new Point(395, 393);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarDni.Location = new Point(390, 29);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(32, 15);
            lblBuscarDni.TabIndex = 6;
            lblBuscarDni.Text = "DNI:";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(428, 26);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(156, 23);
            txtBuscarDni.TabIndex = 7;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarDni.Image = (Image)resources.GetObject("btnBuscarDni.Image");
            btnBuscarDni.Location = new Point(577, 26);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(28, 24);
            btnBuscarDni.TabIndex = 8;
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 6);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 61);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Aprobado", "Inactivo" });
            cmbEstado.Location = new Point(453, 61);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 11;
            // 
            // FrmSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 463);
            Controls.Add(cmbEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscarDni);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblBuscarDni);
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
        private Label lblBuscarDni;
        private TextBox txtBuscarDni;
        private Button btnBuscarDni;
        private Label label2;
        private Label label3;
        private ComboBox cmbEstado;
    }
}