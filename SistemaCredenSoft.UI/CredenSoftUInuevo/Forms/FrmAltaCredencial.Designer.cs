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
            lblSolicitud = new Label();
            cmbSolicitud = new ComboBox();
            lblFechaDeEmision = new Label();
            dateTimeFechaDeEmision = new DateTimePicker();
            lblFechaDeVencimiento = new Label();
            dateTimeFechaDeVencimiento = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Location = new Point(76, 58);
            lblSolicitud.Margin = new Padding(4, 0, 4, 0);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(53, 15);
            lblSolicitud.TabIndex = 0;
            lblSolicitud.Text = "Solicitud";
            // 
            // cmbSolicitud
            // 
            cmbSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitud.FormattingEnabled = true;
            cmbSolicitud.Location = new Point(288, 48);
            cmbSolicitud.Margin = new Padding(4, 3, 4, 3);
            cmbSolicitud.Name = "cmbSolicitud";
            cmbSolicitud.Size = new Size(140, 23);
            cmbSolicitud.TabIndex = 1;
            // 
            // lblFechaDeEmision
            // 
            lblFechaDeEmision.AutoSize = true;
            lblFechaDeEmision.Location = new Point(76, 108);
            lblFechaDeEmision.Margin = new Padding(4, 0, 4, 0);
            lblFechaDeEmision.Name = "lblFechaDeEmision";
            lblFechaDeEmision.Size = new Size(99, 15);
            lblFechaDeEmision.TabIndex = 2;
            lblFechaDeEmision.Text = "Fecha de Emisión";
            // 
            // dateTimeFechaDeEmision
            // 
            dateTimeFechaDeEmision.Format = DateTimePickerFormat.Short;
            dateTimeFechaDeEmision.Location = new Point(288, 96);
            dateTimeFechaDeEmision.Margin = new Padding(4, 3, 4, 3);
            dateTimeFechaDeEmision.Name = "dateTimeFechaDeEmision";
            dateTimeFechaDeEmision.Size = new Size(233, 23);
            dateTimeFechaDeEmision.TabIndex = 3;
            // 
            // lblFechaDeVencimiento
            // 
            lblFechaDeVencimiento.AutoSize = true;
            lblFechaDeVencimiento.Location = new Point(76, 159);
            lblFechaDeVencimiento.Margin = new Padding(4, 0, 4, 0);
            lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            lblFechaDeVencimiento.Size = new Size(123, 15);
            lblFechaDeVencimiento.TabIndex = 4;
            lblFechaDeVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dateTimeFechaDeVencimiento
            // 
            dateTimeFechaDeVencimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaDeVencimiento.Location = new Point(288, 142);
            dateTimeFechaDeVencimiento.Margin = new Padding(4, 3, 4, 3);
            dateTimeFechaDeVencimiento.Name = "dateTimeFechaDeVencimiento";
            dateTimeFechaDeVencimiento.Size = new Size(233, 23);
            dateTimeFechaDeVencimiento.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(76, 210);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(288, 188);
            cmbEstado.Margin = new Padding(4, 3, 4, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 23);
            cmbEstado.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(76, 298);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(200, 70, 34);
            btnCancelar.Location = new Point(433, 298);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAltaCredencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dateTimeFechaDeVencimiento);
            Controls.Add(lblFechaDeVencimiento);
            Controls.Add(dateTimeFechaDeEmision);
            Controls.Add(lblFechaDeEmision);
            Controls.Add(cmbSolicitud);
            Controls.Add(lblSolicitud);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAltaCredencial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Credencial";
            Load += FrmCredencial_Load;
            ResumeLayout(false);
            PerformLayout();

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