
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
            Label4 = new Label();
            label6 = new Label();
            txtDni = new TextBox();
            label7 = new Label();
            txtRutaArchivo = new TextBox();
            btnExaminar = new Button();
            lblArchivoSeleccionado = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(3, 47);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(142, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Nombre y Apellido:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(167, 43);
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
            lblTipoDeSolicitud.Size = new Size(126, 19);
            lblTipoDeSolicitud.TabIndex = 2;
            lblTipoDeSolicitud.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoDeSolicitud
            // 
            cmbTipoDeSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeSolicitud.FormattingEnabled = true;
            cmbTipoDeSolicitud.Location = new Point(167, 88);
            cmbTipoDeSolicitud.Margin = new Padding(2);
            cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            cmbTipoDeSolicitud.Size = new Size(251, 23);
            cmbTipoDeSolicitud.TabIndex = 3;
            cmbTipoDeSolicitud.SelectedIndexChanged += cmbTipoDeSolicitud_SelectedIndexChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.Location = new Point(4, 189);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(141, 19);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Motivo del Tramite:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(167, 188);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(251, 54);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(11, 353);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 19);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(167, 349);
            dateTimeFecha.Margin = new Padding(2);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(251, 23);
            dateTimeFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(60, 448);
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
            btnCancelar.Location = new Point(316, 448);
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
            label2.Location = new Point(141, 51);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 11;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(133, 92);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 12;
            label3.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(67, 355);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 14;
            label5.Text = "*";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Label4.Location = new Point(9, 137);
            Label4.Name = "Label4";
            Label4.Size = new Size(38, 19);
            Label4.TabIndex = 15;
            Label4.Text = "DNI:";
            Label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(44, 140);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 16;
            label6.Text = "*";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(167, 137);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(251, 23);
            txtDni.TabIndex = 17;
            txtDni.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(4, 274);
            label7.Name = "label7";
            label7.Size = new Size(147, 19);
            label7.TabIndex = 18;
            label7.Text = "Documento Adjunto:";
            label7.Click += label7_Click;
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Location = new Point(167, 270);
            txtRutaArchivo.Multiline = true;
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(242, 44);
            txtRutaArchivo.TabIndex = 19;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(167, 310);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(147, 23);
            btnExaminar.TabIndex = 20;
            btnExaminar.Text = "Seleccionar Archivo";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // lblArchivoSeleccionado
            // 
            lblArchivoSeleccionado.AutoSize = true;
            lblArchivoSeleccionado.Location = new Point(316, 314);
            lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            lblArchivoSeleccionado.Size = new Size(161, 15);
            lblArchivoSeleccionado.TabIndex = 21;
            lblArchivoSeleccionado.Text = "Ningún archivo seleccionado";
            lblArchivoSeleccionado.Click += lblArchivoSeleccionado_Click;
            // 
            // FrmAltaSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 490);
            Controls.Add(lblArchivoSeleccionado);
            Controls.Add(btnExaminar);
            Controls.Add(txtRutaArchivo);
            Controls.Add(label7);
            Controls.Add(txtDni);
            Controls.Add(label6);
            Controls.Add(Label4);
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
        private Label Label4;
        private Label label6;
        private TextBox txtDni;
        private Label label7;
        private TextBox txtRutaArchivo;
        private Button btnExaminar;
        private Label lblArchivoSeleccionado;
    }
}