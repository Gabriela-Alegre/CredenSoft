namespace CredenSoftUInuevo.Forms
{
    partial class FrmInformeGerencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformeGerencial));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelFiltros = new Panel();
            label1 = new Label();
            btnGenerarInforme = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblFechaHasta = new Label();
            lblFechaDesde = new Label();
            panelTotal = new Panel();
            panelFondoTotal = new Panel();
            panelBarraTotal = new Panel();
            label7 = new Label();
            lblValorTotal = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panelAprobadas = new Panel();
            panelFondoAprobadas = new Panel();
            panelBarraAprobadas = new Panel();
            lblPorcentajeAprobadas = new Label();
            label9 = new Label();
            lblValorAprobadas = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelRechazadas = new Panel();
            lblPorcentajeRechazadas = new Label();
            panelFondoRechazadas = new Panel();
            panelBarraRechazadas = new Panel();
            label11 = new Label();
            lblValorRechazadas = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panelPendientes = new Panel();
            panelFondoPendientes = new Panel();
            panelBarraPendientes = new Panel();
            lblPorcentajePendientes = new Label();
            label13 = new Label();
            lblValorPendientes = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panelVistaPrevia = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvResumen = new DataGridView();
            lblMensajeInicial = new Label();
            panelFiltros.SuspendLayout();
            panelTotal.SuspendLayout();
            panelFondoTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAprobadas.SuspendLayout();
            panelFondoAprobadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRechazadas.SuspendLayout();
            panelFondoRechazadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelPendientes.SuspendLayout();
            panelFondoPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelVistaPrevia.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartEstadisticas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // panelFiltros
            // 
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(label1);
            panelFiltros.Controls.Add(btnGenerarInforme);
            panelFiltros.Controls.Add(dateTimePicker2);
            panelFiltros.Controls.Add(dateTimePicker1);
            panelFiltros.Controls.Add(lblFechaHasta);
            panelFiltros.Controls.Add(lblFechaDesde);
            panelFiltros.Location = new Point(12, 12);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(974, 63);
            panelFiltros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, -1);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrado de Busqueda:";
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.MediumSeaGreen;
            btnGenerarInforme.Image = (Image)resources.GetObject("btnGenerarInforme.Image");
            btnGenerarInforme.ImageAlign = ContentAlignment.MiddleRight;
            btnGenerarInforme.Location = new Point(831, 20);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(127, 28);
            btnGenerarInforme.TabIndex = 4;
            btnGenerarInforme.Text = "Generar Informe";
            btnGenerarInforme.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(429, 21);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(148, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(188, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(349, 26);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(74, 15);
            lblFechaHasta.TabIndex = 1;
            lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(106, 26);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(76, 15);
            lblFechaDesde.TabIndex = 0;
            lblFechaDesde.Text = "Fecha Desde:";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = SystemColors.Control;
            panelTotal.BorderStyle = BorderStyle.Fixed3D;
            panelTotal.Controls.Add(panelFondoTotal);
            panelTotal.Controls.Add(label7);
            panelTotal.Controls.Add(lblValorTotal);
            panelTotal.Controls.Add(pictureBox2);
            panelTotal.Controls.Add(label3);
            panelTotal.Location = new Point(12, 114);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(267, 168);
            panelTotal.TabIndex = 1;
            // 
            // panelFondoTotal
            // 
            panelFondoTotal.Controls.Add(panelBarraTotal);
            panelFondoTotal.Location = new Point(8, 140);
            panelFondoTotal.Name = "panelFondoTotal";
            panelFondoTotal.Size = new Size(245, 25);
            panelFondoTotal.TabIndex = 5;
            // 
            // panelBarraTotal
            // 
            panelBarraTotal.BackColor = Color.DodgerBlue;
            panelBarraTotal.Location = new Point(3, 3);
            panelBarraTotal.Name = "panelBarraTotal";
            panelBarraTotal.Size = new Size(239, 18);
            panelBarraTotal.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 121);
            label7.Name = "label7";
            label7.Size = new Size(166, 15);
            label7.TabIndex = 3;
            label7.Text = "Solicitudes Totales Registradas";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(80, 64);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(34, 40);
            lblValorTotal.TabIndex = 2;
            lblValorTotal.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(171, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(4, 10);
            label3.Name = "label3";
            label3.Size = new Size(161, 22);
            label3.TabIndex = 0;
            label3.Text = "Total de Solicitudes:";
            // 
            // panelAprobadas
            // 
            panelAprobadas.BorderStyle = BorderStyle.Fixed3D;
            panelAprobadas.Controls.Add(panelFondoAprobadas);
            panelAprobadas.Controls.Add(lblPorcentajeAprobadas);
            panelAprobadas.Controls.Add(label9);
            panelAprobadas.Controls.Add(lblValorAprobadas);
            panelAprobadas.Controls.Add(pictureBox1);
            panelAprobadas.Controls.Add(label2);
            panelAprobadas.Location = new Point(294, 114);
            panelAprobadas.Name = "panelAprobadas";
            panelAprobadas.Size = new Size(275, 168);
            panelAprobadas.TabIndex = 2;
            // 
            // panelFondoAprobadas
            // 
            panelFondoAprobadas.Controls.Add(panelBarraAprobadas);
            panelFondoAprobadas.Location = new Point(15, 139);
            panelFondoAprobadas.Name = "panelFondoAprobadas";
            panelFondoAprobadas.Size = new Size(247, 26);
            panelFondoAprobadas.TabIndex = 5;
            // 
            // panelBarraAprobadas
            // 
            panelBarraAprobadas.BackColor = Color.DarkGreen;
            panelBarraAprobadas.Location = new Point(3, 3);
            panelBarraAprobadas.Name = "panelBarraAprobadas";
            panelBarraAprobadas.Size = new Size(241, 20);
            panelBarraAprobadas.TabIndex = 5;
            // 
            // lblPorcentajeAprobadas
            // 
            lblPorcentajeAprobadas.AutoSize = true;
            lblPorcentajeAprobadas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeAprobadas.ForeColor = Color.Green;
            lblPorcentajeAprobadas.Location = new Point(199, 72);
            lblPorcentajeAprobadas.Name = "lblPorcentajeAprobadas";
            lblPorcentajeAprobadas.Size = new Size(31, 30);
            lblPorcentajeAprobadas.TabIndex = 4;
            lblPorcentajeAprobadas.Text = "%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 121);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 3;
            label9.Text = "Aprobaciones Emitidas";
            // 
            // lblValorAprobadas
            // 
            lblValorAprobadas.AutoSize = true;
            lblValorAprobadas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorAprobadas.Location = new Point(44, 65);
            lblValorAprobadas.Name = "lblValorAprobadas";
            lblValorAprobadas.Size = new Size(34, 40);
            lblValorAprobadas.TabIndex = 2;
            lblValorAprobadas.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(180, 22);
            label2.TabIndex = 0;
            label2.Text = "Solicitudes Aprobadas:";
            // 
            // panelRechazadas
            // 
            panelRechazadas.BorderStyle = BorderStyle.Fixed3D;
            panelRechazadas.Controls.Add(lblPorcentajeRechazadas);
            panelRechazadas.Controls.Add(panelFondoRechazadas);
            panelRechazadas.Controls.Add(label11);
            panelRechazadas.Controls.Add(lblValorRechazadas);
            panelRechazadas.Controls.Add(pictureBox3);
            panelRechazadas.Controls.Add(label4);
            panelRechazadas.Location = new Point(589, 114);
            panelRechazadas.Name = "panelRechazadas";
            panelRechazadas.Size = new Size(260, 168);
            panelRechazadas.TabIndex = 3;
            // 
            // lblPorcentajeRechazadas
            // 
            lblPorcentajeRechazadas.AutoSize = true;
            lblPorcentajeRechazadas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeRechazadas.ForeColor = Color.Crimson;
            lblPorcentajeRechazadas.Location = new Point(191, 72);
            lblPorcentajeRechazadas.Name = "lblPorcentajeRechazadas";
            lblPorcentajeRechazadas.Size = new Size(31, 30);
            lblPorcentajeRechazadas.TabIndex = 4;
            lblPorcentajeRechazadas.Text = "%";
            // 
            // panelFondoRechazadas
            // 
            panelFondoRechazadas.Controls.Add(panelBarraRechazadas);
            panelFondoRechazadas.Location = new Point(16, 136);
            panelFondoRechazadas.Name = "panelFondoRechazadas";
            panelFondoRechazadas.Size = new Size(241, 26);
            panelFondoRechazadas.TabIndex = 5;
            // 
            // panelBarraRechazadas
            // 
            panelBarraRechazadas.BackColor = Color.Crimson;
            panelBarraRechazadas.Location = new Point(3, 3);
            panelBarraRechazadas.Name = "panelBarraRechazadas";
            panelBarraRechazadas.Size = new Size(239, 20);
            panelBarraRechazadas.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 122);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 3;
            label11.Text = "Rechazos de Solicitud";
            // 
            // lblValorRechazadas
            // 
            lblValorRechazadas.AutoSize = true;
            lblValorRechazadas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorRechazadas.Location = new Point(39, 67);
            lblValorRechazadas.Name = "lblValorRechazadas";
            lblValorRechazadas.Size = new Size(34, 40);
            lblValorRechazadas.TabIndex = 2;
            lblValorRechazadas.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(191, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(185, 22);
            label4.TabIndex = 0;
            label4.Text = "Solicitudes Rechazadas:";
            // 
            // panelPendientes
            // 
            panelPendientes.BorderStyle = BorderStyle.Fixed3D;
            panelPendientes.Controls.Add(panelFondoPendientes);
            panelPendientes.Controls.Add(lblPorcentajePendientes);
            panelPendientes.Controls.Add(label13);
            panelPendientes.Controls.Add(lblValorPendientes);
            panelPendientes.Controls.Add(label5);
            panelPendientes.Controls.Add(pictureBox4);
            panelPendientes.Location = new Point(855, 114);
            panelPendientes.Name = "panelPendientes";
            panelPendientes.Size = new Size(252, 168);
            panelPendientes.TabIndex = 4;
            // 
            // panelFondoPendientes
            // 
            panelFondoPendientes.Controls.Add(panelBarraPendientes);
            panelFondoPendientes.Location = new Point(3, 136);
            panelFondoPendientes.Name = "panelFondoPendientes";
            panelFondoPendientes.Size = new Size(246, 29);
            panelFondoPendientes.TabIndex = 5;
            // 
            // panelBarraPendientes
            // 
            panelBarraPendientes.BackColor = Color.Gold;
            panelBarraPendientes.Location = new Point(3, 3);
            panelBarraPendientes.Name = "panelBarraPendientes";
            panelBarraPendientes.Size = new Size(239, 21);
            panelBarraPendientes.TabIndex = 5;
            // 
            // lblPorcentajePendientes
            // 
            lblPorcentajePendientes.AutoSize = true;
            lblPorcentajePendientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajePendientes.ForeColor = Color.DarkGoldenrod;
            lblPorcentajePendientes.Location = new Point(187, 72);
            lblPorcentajePendientes.Name = "lblPorcentajePendientes";
            lblPorcentajePendientes.Size = new Size(31, 30);
            lblPorcentajePendientes.TabIndex = 4;
            lblPorcentajePendientes.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(66, 121);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 3;
            label13.Text = "Pendientes de Revisión";
            // 
            // lblValorPendientes
            // 
            lblValorPendientes.AutoSize = true;
            lblValorPendientes.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorPendientes.Location = new Point(66, 64);
            lblValorPendientes.Name = "lblValorPendientes";
            lblValorPendientes.Size = new Size(34, 40);
            lblValorPendientes.TabIndex = 2;
            lblValorPendientes.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 1;
            label5.Text = "Solicitudes Pendientes:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(187, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panelVistaPrevia
            // 
            panelVistaPrevia.Controls.Add(lblMensajeInicial);
            panelVistaPrevia.Controls.Add(tableLayoutPanel1);
            panelVistaPrevia.Location = new Point(12, 288);
            panelVistaPrevia.Name = "panelVistaPrevia";
            panelVistaPrevia.Size = new Size(1092, 266);
            panelVistaPrevia.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(chartEstadisticas, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvResumen, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1092, 266);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // chartEstadisticas
            // 
            chartArea3.Name = "ChartArea1";
            chartEstadisticas.ChartAreas.Add(chartArea3);
            chartEstadisticas.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartEstadisticas.Legends.Add(legend3);
            chartEstadisticas.Location = new Point(3, 3);
            chartEstadisticas.Name = "chartEstadisticas";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartEstadisticas.Series.Add(series3);
            chartEstadisticas.Size = new Size(540, 260);
            chartEstadisticas.TabIndex = 0;
            chartEstadisticas.Text = "chart1";
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Dock = DockStyle.Fill;
            dgvResumen.Location = new Point(549, 3);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.Size = new Size(540, 260);
            dgvResumen.TabIndex = 1;
            // 
            // lblMensajeInicial
            // 
            lblMensajeInicial.Dock = DockStyle.Fill;
            lblMensajeInicial.Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeInicial.Location = new Point(0, 0);
            lblMensajeInicial.Name = "lblMensajeInicial";
            lblMensajeInicial.Size = new Size(1092, 266);
            lblMensajeInicial.TabIndex = 7;
            lblMensajeInicial.Text = "\"Vista previa de informe consolidado - Seleccione un rango de fechas y presione Generar Informe\".";
            lblMensajeInicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInformeGerencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 612);
            Controls.Add(panelVistaPrevia);
            Controls.Add(panelPendientes);
            Controls.Add(panelRechazadas);
            Controls.Add(panelAprobadas);
            Controls.Add(panelTotal);
            Controls.Add(panelFiltros);
            Name = "FrmInformeGerencial";
            Text = "FrmInformeGerencial";
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelFondoTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAprobadas.ResumeLayout(false);
            panelAprobadas.PerformLayout();
            panelFondoAprobadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRechazadas.ResumeLayout(false);
            panelRechazadas.PerformLayout();
            panelFondoRechazadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelPendientes.ResumeLayout(false);
            panelPendientes.PerformLayout();
            panelFondoPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelVistaPrevia.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartEstadisticas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFiltros;
        private Label lblFechaHasta;
        private Label lblFechaDesde;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnGenerarInforme;
        private Label label1;
        private Panel panelTotal;
        private Panel panelAprobadas;
        private Panel panelRechazadas;
        private Panel panelPendientes;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label7;
        private Label lblValorTotal;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label9;
        private Label lblValorAprobadas;
        private Label label11;
        private Label lblValorRechazadas;
        private Label label13;
        private Label lblValorPendientes;
        private Label lblPorcentajeAprobadas;
        private Label lblPorcentajeRechazadas;
        private Label lblPorcentajePendientes;
        private Panel panelBarraTotal;
        private Panel panelBarraAprobadas;
        private Panel panelBarraRechazadas;
        private Panel panelBarraPendientes;
        private Panel panelFondoTotal;
        private Panel panelFondoAprobadas;
        private Panel panelFondoRechazadas;
        private Panel panelFondoPendientes;
        private Panel panelVistaPrevia;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private DataGridView dgvResumen;
        private Label lblMensajeInicial;
    }
}