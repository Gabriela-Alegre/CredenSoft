namespace CredenSoftUInuevo.Forms
{
    partial class FrmEditarSolicitud
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
            lblTitulo = new Label();
            lblCodigoSolicitud = new Label();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            cmbNombreApellido = new ComboBox();
            lblTipo = new Label();
            cmbTipoSolicitud = new ComboBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblArchivo = new Label();
            txtRutaArchivo = new TextBox();
            btnSeleccionarArchivo = new Button();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.RoyalBlue;
            lblTitulo.Location = new Point(18, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MODIFICAR SOLICITUD";
            // 
            // lblCodigoSolicitud
            // 
            lblCodigoSolicitud.AutoSize = true;
            lblCodigoSolicitud.Location = new Point(135, 50);
            lblCodigoSolicitud.Name = "lblCodigoSolicitud";
            lblCodigoSolicitud.Size = new Size(0, 15);
            lblCodigoSolicitud.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(18, 193);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(53, 17);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            lblEstado.Click += label1_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Aprobado", "Inactivo" });
            cmbEstado.Location = new Point(170, 192);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(211, 23);
            cmbEstado.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(18, 227);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(84, 17);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(170, 226);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(211, 38);
            txtDescripcion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(78, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 27);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(258, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(129, 17);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre y Apellido:";
            // 
            // cmbNombreApellido
            // 
            cmbNombreApellido.FormattingEnabled = true;
            cmbNombreApellido.Location = new Point(170, 89);
            cmbNombreApellido.Name = "cmbNombreApellido";
            cmbNombreApellido.Size = new Size(211, 23);
            cmbNombreApellido.TabIndex = 10;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(18, 119);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(117, 17);
            lblTipo.TabIndex = 11;
            lblTipo.Text = "Tipo de Solicitud:";
            // 
            // cmbTipoSolicitud
            // 
            cmbTipoSolicitud.FormattingEnabled = true;
            cmbTipoSolicitud.Items.AddRange(new object[] { "Anexo C", "Anexo E" });
            cmbTipoSolicitud.Location = new Point(170, 119);
            cmbTipoSolicitud.Name = "cmbTipoSolicitud";
            cmbTipoSolicitud.Size = new Size(211, 23);
            cmbTipoSolicitud.TabIndex = 12;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(18, 160);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 17);
            lblDni.TabIndex = 13;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(170, 160);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(211, 23);
            txtDni.TabIndex = 14;
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArchivo.Location = new Point(18, 282);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(138, 17);
            lblArchivo.TabIndex = 15;
            lblArchivo.Text = "Documento Adjunto:";
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Location = new Point(171, 276);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(210, 23);
            txtRutaArchivo.TabIndex = 16;
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSeleccionarArchivo.Location = new Point(171, 298);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(120, 23);
            btnSeleccionarArchivo.TabIndex = 17;
            btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(18, 339);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 17);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 339);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // FrmEditarSolicitud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(btnSeleccionarArchivo);
            Controls.Add(txtRutaArchivo);
            Controls.Add(lblArchivo);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(cmbTipoSolicitud);
            Controls.Add(lblTipo);
            Controls.Add(cmbNombreApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(lblCodigoSolicitud);
            Controls.Add(lblTitulo);
            Name = "FrmEditarSolicitud";
            Text = "   Editar Solicitud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigoSolicitud;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblNombre;
        private ComboBox cmbNombreApellido;
        private Label lblTipo;
        private ComboBox cmbTipoSolicitud;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblArchivo;
        private TextBox txtRutaArchivo;
        private Button btnSeleccionarArchivo;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
    }
}