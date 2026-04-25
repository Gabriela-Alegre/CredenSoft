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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(33, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Location = new Point(153, 49);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(200, 23);
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
            cmbTipoDeSolicitud.Location = new Point(153, 87);
            cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            cmbTipoDeSolicitud.Size = new Size(200, 23);
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
            txtDescripcion.Location = new Point(153, 125);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 90);
            txtDescripcion.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(33, 230);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(153, 221);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(200, 23);
            dateTimeFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(20, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(268, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAltaSolicitud
            // 
            ClientSize = new Size(400, 320);
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
    }
}