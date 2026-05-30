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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(6, 78);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(198, 78);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(357, 33);
            cmbUsuario.TabIndex = 1;
            // 
            // lblTipoDeSolicitud
            // 
            lblTipoDeSolicitud.AutoSize = true;
            lblTipoDeSolicitud.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoDeSolicitud.Location = new Point(6, 153);
            lblTipoDeSolicitud.Name = "lblTipoDeSolicitud";
            lblTipoDeSolicitud.Size = new Size(172, 28);
            lblTipoDeSolicitud.TabIndex = 2;
            lblTipoDeSolicitud.Text = "Tipo de Solicitud";
            // 
            // cmbTipoDeSolicitud
            // 
            cmbTipoDeSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeSolicitud.FormattingEnabled = true;
            cmbTipoDeSolicitud.Location = new Point(198, 153);
            cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            cmbTipoDeSolicitud.Size = new Size(357, 33);
            cmbTipoDeSolicitud.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.Location = new Point(6, 215);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(123, 28);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(198, 215);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(357, 174);
            txtDescripcion.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(6, 429);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(198, 426);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(357, 31);
            dateTimeFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(82, 583);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 51);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(454, 583);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 51);
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
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(465, 32);
            label1.TabIndex = 10;
            label1.Text = "REGISTRAR SOLICITUD DE CREDENCIAL";
            label1.Click += label1_Click;
            // 
            // FrmAltaSolicitud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 675);
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
    }
}