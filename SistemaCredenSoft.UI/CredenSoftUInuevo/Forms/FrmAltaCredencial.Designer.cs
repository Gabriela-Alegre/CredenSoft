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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSolicitud.Location = new Point(18, 110);
            lblSolicitud.Margin = new Padding(6, 0, 6, 0);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(95, 28);
            lblSolicitud.TabIndex = 0;
            lblSolicitud.Text = "Solicitud";
            // 
            // cmbSolicitud
            // 
            cmbSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSolicitud.FormattingEnabled = true;
            cmbSolicitud.Location = new Point(320, 110);
            cmbSolicitud.Margin = new Padding(6, 5, 6, 5);
            cmbSolicitud.Name = "cmbSolicitud";
            cmbSolicitud.Size = new Size(198, 33);
            cmbSolicitud.TabIndex = 1;
            // 
            // lblFechaDeEmision
            // 
            lblFechaDeEmision.AutoSize = true;
            lblFechaDeEmision.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDeEmision.Location = new Point(18, 190);
            lblFechaDeEmision.Margin = new Padding(6, 0, 6, 0);
            lblFechaDeEmision.Name = "lblFechaDeEmision";
            lblFechaDeEmision.Size = new Size(175, 28);
            lblFechaDeEmision.TabIndex = 2;
            lblFechaDeEmision.Text = "Fecha de Emisión";
            // 
            // dateTimeFechaDeEmision
            // 
            dateTimeFechaDeEmision.Format = DateTimePickerFormat.Short;
            dateTimeFechaDeEmision.Location = new Point(320, 190);
            dateTimeFechaDeEmision.Margin = new Padding(6, 5, 6, 5);
            dateTimeFechaDeEmision.Name = "dateTimeFechaDeEmision";
            dateTimeFechaDeEmision.Size = new Size(331, 31);
            dateTimeFechaDeEmision.TabIndex = 3;
            // 
            // lblFechaDeVencimiento
            // 
            lblFechaDeVencimiento.AutoSize = true;
            lblFechaDeVencimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDeVencimiento.Location = new Point(18, 267);
            lblFechaDeVencimiento.Margin = new Padding(6, 0, 6, 0);
            lblFechaDeVencimiento.Name = "lblFechaDeVencimiento";
            lblFechaDeVencimiento.Size = new Size(219, 28);
            lblFechaDeVencimiento.TabIndex = 4;
            lblFechaDeVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dateTimeFechaDeVencimiento
            // 
            dateTimeFechaDeVencimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaDeVencimiento.Location = new Point(320, 267);
            dateTimeFechaDeVencimiento.Margin = new Padding(6, 5, 6, 5);
            dateTimeFechaDeVencimiento.Name = "dateTimeFechaDeVencimiento";
            dateTimeFechaDeVencimiento.Size = new Size(331, 31);
            dateTimeFechaDeVencimiento.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.Location = new Point(18, 343);
            lblEstado.Margin = new Padding(6, 0, 6, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 28);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(320, 343);
            cmbEstado.Margin = new Padding(6, 5, 6, 5);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(198, 33);
            cmbEstado.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(15, 521);
            btnGuardar.Margin = new Padding(6, 5, 6, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 45);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(525, 521);
            btnCancelar.Margin = new Padding(6, 5, 6, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(337, 32);
            label1.TabIndex = 10;
            label1.Text = "EMITIR NUEVA CREDENCIAL";
            // 
            // FrmAltaCredencial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 865);
            Controls.Add(label1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label label1;
    }
}