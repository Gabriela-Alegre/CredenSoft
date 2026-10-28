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
            panel1 = new Panel();
            panel2 = new Panel();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            btnGenerarInforme = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.Anchor = AnchorStyles.Left;
            dgvSolicitudes.BackgroundColor = Color.WhiteSmoke;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(14, 157);
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
            btnNueva.Image = (Image)resources.GetObject("btnNueva.Image");
            btnNueva.ImageAlign = ContentAlignment.MiddleRight;
            btnNueva.Location = new Point(57, 436);
            btnNueva.Margin = new Padding(4, 3, 4, 3);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(155, 49);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva";
            btnNueva.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 13F);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(557, 436);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 49);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Inactivar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom;
            btnVer.BackColor = Color.Lavender;
            btnVer.Font = new Font("Segoe UI", 13F);
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageAlign = ContentAlignment.MiddleRight;
            btnVer.Location = new Point(232, 436);
            btnVer.Margin = new Padding(4, 3, 4, 3);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(149, 49);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.Location = new Point(400, 436);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 49);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarDni.Location = new Point(13, 7);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(32, 15);
            lblBuscarDni.TabIndex = 6;
            lblBuscarDni.Text = "DNI:";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(74, 3);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(156, 23);
            txtBuscarDni.TabIndex = 7;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarDni.Image = (Image)resources.GetObject("btnBuscarDni.Image");
            btnBuscarDni.Location = new Point(226, 2);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(29, 24);
            btnBuscarDni.TabIndex = 8;
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 40);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtros de Busqueda por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 39);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Inactivo", "Pendiente de Revisión", "Aprobado", "Rechazado" });
            cmbEstado.Location = new Point(74, 36);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(156, 23);
            cmbEstado.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblBuscarDni);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(txtBuscarDni);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBuscarDni);
            panel1.Location = new Point(57, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 70);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dtpHasta);
            panel2.Controls.Add(dtpDesde);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(362, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 70);
            panel2.TabIndex = 13;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(60, 40);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(228, 23);
            dtpHasta.TabIndex = 3;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(60, 6);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(228, 23);
            dtpDesde.TabIndex = 2;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 39);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 1;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 6);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Desde:";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.MediumSeaGreen;
            btnGenerarInforme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarInforme.Image = (Image)resources.GetObject("btnGenerarInforme.Image");
            btnGenerarInforme.ImageAlign = ContentAlignment.MiddleRight;
            btnGenerarInforme.Location = new Point(713, 118);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(129, 33);
            btnGenerarInforme.TabIndex = 14;
            btnGenerarInforme.Text = "Generar Informe";
            btnGenerarInforme.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // FrmSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 497);
            Controls.Add(btnGenerarInforme);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnGenerarInforme;
    }
}