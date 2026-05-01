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
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Location = new Point(126, 78);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(357, 33);
            cmbUsuario.TabIndex = 8;
            cmbUsuario.ValueMember = "IdUsuario";
            // 
            // lblTipoDeSolicitud
            // 
            lblTipoDeSolicitud.Location = new Point(0, 0);
            lblTipoDeSolicitud.Name = "lblTipoDeSolicitud";
            lblTipoDeSolicitud.Size = new Size(100, 23);
            lblTipoDeSolicitud.TabIndex = 7;
            // 
            // cmbTipoDeSolicitud
            // 
            cmbTipoDeSolicitud.DisplayMember = "NombreTipo";
            cmbTipoDeSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeSolicitud.Location = new Point(126, 153);
            cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            cmbTipoDeSolicitud.Size = new Size(357, 33);
            cmbTipoDeSolicitud.TabIndex = 6;
            cmbTipoDeSolicitud.ValueMember = "IdTipoCredencial";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(0, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 23);
            lblDescripcion.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(126, 215);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(357, 174);
            txtDescripcion.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFecha.Location = new Point(6, 429);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(126, 426);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(357, 31);
            dateTimeFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(6, 531);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 51);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(378, 531);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 51);
            btnCancelar.TabIndex = 1;
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
            ClientSize = new Size(816, 651);
            Controls.Add(label1);
            Controls.Add(lblFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimeFecha);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbTipoDeSolicitud);
            Controls.Add(lblTipoDeSolicitud);
            Controls.Add(cmbUsuario);
            Controls.Add(lblUsuario);
            Name = "FrmAltaSolicitud";
            Text = "Nueva Solicitud";
            Load += FrmAltaSolicitud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblTipoDeSolicitud;
        private System.Windows.Forms.ComboBox cmbTipoDeSolicitud;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Label label1;
    }
}