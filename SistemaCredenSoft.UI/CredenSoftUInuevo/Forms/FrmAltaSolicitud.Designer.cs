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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoDeSolicitud = new System.Windows.Forms.Label();
            this.cmbTipoDeSolicitud = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(33, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.Text = "Usuario";

            // cmbUsuario
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Location = new System.Drawing.Point(153, 49);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(200, 21);
            this.cmbUsuario.DisplayMember = "Nombre";
            this.cmbUsuario.ValueMember = "IdUsuario";

            // cmbTipoDeSolicitud
            this.cmbTipoDeSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeSolicitud.Location = new System.Drawing.Point(153, 87);
            this.cmbTipoDeSolicitud.Name = "cmbTipoDeSolicitud";
            this.cmbTipoDeSolicitud.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoDeSolicitud.DisplayMember = "NombreTipo";
            this.cmbTipoDeSolicitud.ValueMember = "IdTipoCredencial";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(153, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 90);

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(33, 230);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.Text = "Fecha";

            // dateTimeFecha
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(153, 221);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 20);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(20, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(268, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmAltaSolicitud
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblFecha); // Agregado para que se vea el label de fecha
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion); // Agregado
            this.Controls.Add(this.cmbTipoDeSolicitud);
            this.Controls.Add(this.lblTipoDeSolicitud); // Agregado
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmAltaSolicitud";
            this.Text = "Nueva Solicitud";
            this.Load += new System.EventHandler(this.FrmAltaSolicitud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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