namespace CredenSoftUInuevo.Forms
{
    partial class FrmAltaCredencial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.cmbSolicitud = new System.Windows.Forms.ComboBox();
            this.lblFechaDeEmision = new System.Windows.Forms.Label();
            this.dateTimeFechaDeEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeVencimiento = new System.Windows.Forms.Label();
            this.dateTimeFechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Location = new System.Drawing.Point(65, 50);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(47, 13);
            this.lblSolicitud.TabIndex = 0;
            this.lblSolicitud.Text = "Solicitud";
            // 
            // cmbSolicitud
            // 
            this.cmbSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitud.FormattingEnabled = true;
            this.cmbSolicitud.Location = new System.Drawing.Point(247, 42);
            this.cmbSolicitud.Name = "cmbSolicitud";
            this.cmbSolicitud.Size = new System.Drawing.Size(121, 21);
            this.cmbSolicitud.TabIndex = 1;
            // 
            // lblFechaDeEmision
            // 
            this.lblFechaDeEmision.AutoSize = true;
            this.lblFechaDeEmision.Location = new System.Drawing.Point(65, 94);
            this.lblFechaDeEmision.Name = "lblFechaDeEmision";
            this.lblFechaDeEmision.Size = new System.Drawing.Size(91, 13);
            this.lblFechaDeEmision.TabIndex = 2;
            this.lblFechaDeEmision.Text = "Fecha de Emisión";
            // 
            // dateTimeFechaDeEmision
            // 
            this.dateTimeFechaDeEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeEmision.Location = new System.Drawing.Point(247, 83);
            this.dateTimeFechaDeEmision.Name = "dateTimeFechaDeEmision";
            this.dateTimeFechaDeEmision.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaDeEmision.TabIndex = 3;
            // 
            // lblFechaDeVencimiento
            // 
            this.lblFechaDeVencimiento.AutoSize = true;
            this.lblFechaDeVencimiento.Location = new System.Drawing.Point(65, 138);
            this.lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            this.lblFechaDeVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaDeVencimiento.TabIndex = 4;
            this.lblFechaDeVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dateTimeFechaDeVencimiento
            // 
            this.dateTimeFechaDeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaDeVencimiento.Location = new System.Drawing.Point(247, 123);
            this.dateTimeFechaDeVencimiento.Name = "dateTimeFechaDeVencimiento";
            this.dateTimeFechaDeVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaDeVencimiento.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(65, 182);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(247, 163);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(80, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(200, 70, 34);
            this.btnCancelar.Location = new System.Drawing.Point(263, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dateTimeFechaDeVencimiento);
            this.Controls.Add(this.lblFechaDeVencimiento);
            this.Controls.Add(this.dateTimeFechaDeEmision);
            this.Controls.Add(this.lblFechaDeEmision);
            this.Controls.Add(this.cmbSolicitud);
            this.Controls.Add(this.lblSolicitud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAltaCredencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Credencial";
            this.Load += new System.EventHandler(this.FrmCredencial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.ComboBox cmbSolicitud;
        private System.Windows.Forms.Label lblFechaDeEmision;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeEmision;
        private System.Windows.Forms.Label lblFechaDeVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeVencimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}