namespace CredenSoftUInuevo.Forms
{
    partial class FrmAltaSolicitud
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
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            lblTipoDeSolicitud = new Label();
            cmbTipoDeSolicitud = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblFecha = new Label();
            dateTimeFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(4, 47);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(139, 47);
            cmbUsuario.Margin = new Padding(2);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(251, 23);
            cmbUsuario.TabIndex = 1;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;
            // 
            // lblTipoDeSolicitud
            // 
            lblTipoDeSolicitud.AutoSize = true;
            lblTipoDeSolicitud.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoDeSolicitud.Location = new Point(4, 92);
            lblTipoDeSolicitud.Margin = new Padding(2, 0, 2, 0);
            lblTipoDeSolicitud.Name = "lblTipoDeSolicitud";
            lblTipoDeSolicitud.Size = new Size(122, 19);
            lblTipoDeSolicitud.TabIndex = 2;
            lblTipoDeSolicitud.Text = "Tipo de Solicitud";
            // 
            // cmbTipoDeSolicitud
            // 
            cmbTipoDeSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeSolicitud.FormattingEnabled = true;
            cmbTipoDeSolicitud.Location = new Point(139, 92);
            cmbTipoDeSolicitud.Margin = new Padding(2);
            cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            cmbTipoDeSolicitud.Size = new Size(251, 23);
            cmbTipoDeSolicitud.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.Location = new Point(4, 129);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(139, 128);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(251, 106);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(4, 257);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 19);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(139, 256);
            dateTimeFecha.Margin = new Padding(2);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(251, 23);
            dateTimeFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(57, 350);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(74, 31);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(318, 350);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(4, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 21);
            label1.TabIndex = 10;
            label1.Text = "REGISTRAR SOLICITUD DE CREDENCIAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(69, 49);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 11;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(122, 92);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 12;
            label3.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(52, 261);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 14;
            label5.Text = "*";
            // 
            // FrmAltaSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 405);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimeFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbTipoDeSolicitud);
            Controls.Add(lblTipoDeSolicitud);
            Controls.Add(cmbUsuario);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaSolicitud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Solicitud";
            Load += FrmAltaSolicitud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private ComboBox cmbUsuario;
        private Label lblTipoDeSolicitud;
        private ComboBox cmbTipoDeSolicitud;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblFecha;
        private DateTimePicker dateTimeFecha;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}