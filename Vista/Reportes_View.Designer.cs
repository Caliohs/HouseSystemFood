namespace Vista
{
    partial class Reportes_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_View));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbMoneda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.rdbCierres = new System.Windows.Forms.RadioButton();
            this.rdbGastos = new System.Windows.Forms.RadioButton();
            this.gboxM = new System.Windows.Forms.GroupBox();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbColon = new System.Windows.Forms.RadioButton();
            this.gbox4 = new System.Windows.Forms.GroupBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lbdesde = new System.Windows.Forms.Label();
            this.lbHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxT = new System.Windows.Forms.GroupBox();
            this.lbSimbol = new System.Windows.Forms.Label();
            this.lbAcum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbReporte = new System.Windows.Forms.Label();
            this.dtgReportes = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbox3.SuspendLayout();
            this.gboxM.SuspendLayout();
            this.gbox4.SuspendLayout();
            this.gboxT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbMoneda);
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.gboxT);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.lbReporte);
            this.groupBox.Controls.Add(this.dtgReportes);
            this.groupBox.Location = new System.Drawing.Point(12, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1076, 572);
            this.groupBox.TabIndex = 86;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Reportes";
            // 
            // lbMoneda
            // 
            this.lbMoneda.AutoSize = true;
            this.lbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneda.ForeColor = System.Drawing.Color.Maroon;
            this.lbMoneda.Location = new System.Drawing.Point(484, 16);
            this.lbMoneda.Name = "lbMoneda";
            this.lbMoneda.Size = new System.Drawing.Size(19, 20);
            this.lbMoneda.TabIndex = 123;
            this.lbMoneda.Text = "_";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.gbox3);
            this.groupBox2.Controls.Add(this.gboxM);
            this.groupBox2.Controls.Add(this.gbox4);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(9, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 508);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            // 
            // gbox3
            // 
            this.gbox3.Controls.Add(this.rdbVentas);
            this.gbox3.Controls.Add(this.rdbCierres);
            this.gbox3.Controls.Add(this.rdbGastos);
            this.gbox3.Location = new System.Drawing.Point(14, 30);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(273, 76);
            this.gbox3.TabIndex = 105;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "Tipo de Reporte";
            // 
            // rdbVentas
            // 
            this.rdbVentas.AutoSize = true;
            this.rdbVentas.Location = new System.Drawing.Point(187, 37);
            this.rdbVentas.Name = "rdbVentas";
            this.rdbVentas.Size = new System.Drawing.Size(58, 17);
            this.rdbVentas.TabIndex = 103;
            this.rdbVentas.Text = "Ventas";
            this.rdbVentas.UseVisualStyleBackColor = true;
            // 
            // rdbCierres
            // 
            this.rdbCierres.AutoSize = true;
            this.rdbCierres.Location = new System.Drawing.Point(105, 37);
            this.rdbCierres.Name = "rdbCierres";
            this.rdbCierres.Size = new System.Drawing.Size(57, 17);
            this.rdbCierres.TabIndex = 102;
            this.rdbCierres.Text = "Cierres";
            this.rdbCierres.UseVisualStyleBackColor = true;
            // 
            // rdbGastos
            // 
            this.rdbGastos.AutoSize = true;
            this.rdbGastos.Checked = true;
            this.rdbGastos.Location = new System.Drawing.Point(25, 37);
            this.rdbGastos.Name = "rdbGastos";
            this.rdbGastos.Size = new System.Drawing.Size(58, 17);
            this.rdbGastos.TabIndex = 101;
            this.rdbGastos.TabStop = true;
            this.rdbGastos.Text = "Gastos";
            this.rdbGastos.UseVisualStyleBackColor = true;
            // 
            // gboxM
            // 
            this.gboxM.Controls.Add(this.rdbDolar);
            this.gboxM.Controls.Add(this.rdbColon);
            this.gboxM.Location = new System.Drawing.Point(14, 275);
            this.gboxM.Name = "gboxM";
            this.gboxM.Size = new System.Drawing.Size(273, 77);
            this.gboxM.TabIndex = 117;
            this.gboxM.TabStop = false;
            this.gboxM.Text = "Tipo de Moneda";
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Location = new System.Drawing.Point(146, 36);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(61, 17);
            this.rdbDolar.TabIndex = 106;
            this.rdbDolar.Text = "Dolares";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbColon
            // 
            this.rdbColon.AutoSize = true;
            this.rdbColon.Checked = true;
            this.rdbColon.Location = new System.Drawing.Point(64, 36);
            this.rdbColon.Name = "rdbColon";
            this.rdbColon.Size = new System.Drawing.Size(63, 17);
            this.rdbColon.TabIndex = 105;
            this.rdbColon.TabStop = true;
            this.rdbColon.Text = "Colones";
            this.rdbColon.UseVisualStyleBackColor = true;
            // 
            // gbox4
            // 
            this.gbox4.Controls.Add(this.dtpInicio);
            this.gbox4.Controls.Add(this.lbdesde);
            this.gbox4.Controls.Add(this.lbHasta);
            this.gbox4.Controls.Add(this.dtpHasta);
            this.gbox4.Location = new System.Drawing.Point(14, 140);
            this.gbox4.Name = "gbox4";
            this.gbox4.Size = new System.Drawing.Size(273, 100);
            this.gbox4.TabIndex = 116;
            this.gbox4.TabStop = false;
            this.gbox4.Text = "Rango de busqueda";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(91, 20);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(116, 20);
            this.dtpInicio.TabIndex = 82;
            // 
            // lbdesde
            // 
            this.lbdesde.AutoSize = true;
            this.lbdesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdesde.Location = new System.Drawing.Point(48, 25);
            this.lbdesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdesde.Name = "lbdesde";
            this.lbdesde.Size = new System.Drawing.Size(43, 15);
            this.lbdesde.TabIndex = 81;
            this.lbdesde.Text = "Desde";
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasta.Location = new System.Drawing.Point(48, 65);
            this.lbHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(39, 15);
            this.lbHasta.TabIndex = 113;
            this.lbHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(92, 60);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(115, 20);
            this.dtpHasta.TabIndex = 114;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(14, 357);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 89);
            this.btnAceptar.TabIndex = 64;
            this.btnAceptar.Text = "Generar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Transparent;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(160, 357);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(127, 89);
            this.btnExportar.TabIndex = 115;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(14, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(273, 39);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gboxT
            // 
            this.gboxT.BackColor = System.Drawing.Color.Silver;
            this.gboxT.Controls.Add(this.lbSimbol);
            this.gboxT.Controls.Add(this.lbAcum);
            this.gboxT.Location = new System.Drawing.Point(512, 485);
            this.gboxT.Name = "gboxT";
            this.gboxT.Size = new System.Drawing.Size(160, 62);
            this.gboxT.TabIndex = 112;
            this.gboxT.TabStop = false;
            this.gboxT.Text = "Acumulado:";
            // 
            // lbSimbol
            // 
            this.lbSimbol.AutoSize = true;
            this.lbSimbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimbol.ForeColor = System.Drawing.Color.Maroon;
            this.lbSimbol.Location = new System.Drawing.Point(6, 26);
            this.lbSimbol.Name = "lbSimbol";
            this.lbSimbol.Size = new System.Drawing.Size(25, 24);
            this.lbSimbol.TabIndex = 120;
            this.lbSimbol.Text = "₡";
            // 
            // lbAcum
            // 
            this.lbAcum.AutoSize = true;
            this.lbAcum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcum.ForeColor = System.Drawing.Color.Maroon;
            this.lbAcum.Location = new System.Drawing.Point(32, 26);
            this.lbAcum.Name = "lbAcum";
            this.lbAcum.Size = new System.Drawing.Size(21, 24);
            this.lbAcum.TabIndex = 119;
            this.lbAcum.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lbCantidad);
            this.groupBox1.Location = new System.Drawing.Point(330, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 62);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de movimientos:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.lbCantidad.Location = new System.Drawing.Point(53, 26);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(21, 24);
            this.lbCantidad.TabIndex = 121;
            this.lbCantidad.Text = "0";
            // 
            // lbReporte
            // 
            this.lbReporte.AutoSize = true;
            this.lbReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReporte.ForeColor = System.Drawing.Color.Maroon;
            this.lbReporte.Location = new System.Drawing.Point(326, 16);
            this.lbReporte.Name = "lbReporte";
            this.lbReporte.Size = new System.Drawing.Size(104, 20);
            this.lbReporte.TabIndex = 111;
            this.lbReporte.Text = "Reporte de ";
            // 
            // dtgReportes
            // 
            this.dtgReportes.AllowUserToAddRows = false;
            this.dtgReportes.AllowUserToDeleteRows = false;
            this.dtgReportes.AllowUserToOrderColumns = true;
            this.dtgReportes.AllowUserToResizeColumns = false;
            this.dtgReportes.AllowUserToResizeRows = false;
            this.dtgReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReportes.BackgroundColor = System.Drawing.Color.White;
            this.dtgReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReportes.Enabled = false;
            this.dtgReportes.Location = new System.Drawing.Point(330, 39);
            this.dtgReportes.Name = "dtgReportes";
            this.dtgReportes.ReadOnly = true;
            this.dtgReportes.RowHeadersVisible = false;
            this.dtgReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReportes.Size = new System.Drawing.Size(727, 422);
            this.dtgReportes.TabIndex = 70;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1045, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(53, 24);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 30);
            this.panel2.TabIndex = 85;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(31, 2);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTitulo.Size = new System.Drawing.Size(157, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Gestion de Reportes";
            // 
            // Reportes_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes_View";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            this.gboxM.ResumeLayout(false);
            this.gboxM.PerformLayout();
            this.gbox4.ResumeLayout(false);
            this.gbox4.PerformLayout();
            this.gboxT.ResumeLayout(false);
            this.gboxT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lbHasta;
        private System.Windows.Forms.GroupBox gboxT;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.RadioButton rdbCierres;
        private System.Windows.Forms.RadioButton rdbGastos;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgReportes;
        private System.Windows.Forms.Label lbdesde;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbReporte;
        private System.Windows.Forms.GroupBox gbox4;
        private System.Windows.Forms.Label lbAcum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.GroupBox gboxM;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbColon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMoneda;
        private System.Windows.Forms.Label lbSimbol;
    }
}