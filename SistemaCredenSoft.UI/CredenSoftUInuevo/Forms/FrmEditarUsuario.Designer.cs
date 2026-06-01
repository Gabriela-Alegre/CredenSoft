namespace CredenSoftUInuevo.Forms
{
    partial class FrmEditarUsuario
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
            label1 = new Label();
            lblNombre = new Label();
            cmbEstado = new ComboBox();
            cmbRol = new ComboBox();
            lblEstado = new Label();
            lblRol = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblApellido = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(-4, 41);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 0;
            label1.Text = "      EDITAR USUARIO ";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(37, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(177, 464);
            cmbEstado.Margin = new Padding(6, 5, 6, 5);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(331, 33);
            cmbEstado.TabIndex = 10;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(177, 405);
            cmbRol.Margin = new Padding(6, 5, 6, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(331, 33);
            cmbRol.TabIndex = 9;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.Location = new Point(37, 466);
            lblEstado.Margin = new Padding(6, 0, 6, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 28);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(37, 407);
            lblRol.Margin = new Padding(6, 0, 6, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(48, 28);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Location = new Point(404, 552);
            btnCancelar.Margin = new Padding(6, 5, 6, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 45);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(79, 552);
            btnGuardar.Margin = new Padding(6, 5, 6, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 45);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(37, 186);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(91, 28);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.Location = new Point(37, 243);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(49, 28);
            lblDni.TabIndex = 17;
            lblDni.Text = "DNI";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(37, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 299);
            txtEmail.Margin = new Padding(6, 5, 6, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 31);
            txtEmail.TabIndex = 23;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(177, 242);
            txtDni.Margin = new Padding(6, 5, 6, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(331, 31);
            txtDni.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(177, 185);
            txtApellido.Margin = new Padding(6, 5, 6, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(331, 31);
            txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 118);
            txtNombre.Margin = new Padding(6, 5, 6, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(331, 31);
            txtNombre.TabIndex = 20;
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 637);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(cmbRol);
            Controls.Add(lblEstado);
            Controls.Add(lblRol);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "FrmEditarUsuario";
            Text = "FrmEditarUsuario";
            Load += FrmEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private ComboBox cmbEstado;
        private ComboBox cmbRol;
        private Label lblEstado;
        private Label lblRol;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}