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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.gboxT = new System.Windows.Forms.GroupBox();
            this.lbet3 = new System.Windows.Forms.Label();
            this.lbAcumD = new System.Windows.Forms.Label();
            this.lbAcumC = new System.Windows.Forms.Label();
            this.lbet4 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbet1 = new System.Windows.Forms.Label();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.rdbCierres = new System.Windows.Forms.RadioButton();
            this.rdbGastos = new System.Windows.Forms.RadioButton();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgCierres = new System.Windows.Forms.DataGridView();
            this.lbdesde = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lbHasta = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.gboxT.SuspendLayout();
            this.gbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierres)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnExportar);
            this.groupBox.Controls.Add(this.dtpHasta);
            this.groupBox.Controls.Add(this.lbHasta);
            this.groupBox.Controls.Add(this.gboxT);
            this.groupBox.Controls.Add(this.gbox3);
            this.groupBox.Controls.Add(this.dtpInicio);
            this.groupBox.Controls.Add(this.btnAceptar);
            this.groupBox.Controls.Add(this.dtgCierres);
            this.groupBox.Controls.Add(this.lbdesde);
            this.groupBox.Controls.Add(this.btnCancelar);
            this.groupBox.Location = new System.Drawing.Point(12, 46);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 461);
            this.groupBox.TabIndex = 86;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Reportes";
            // 
            // gboxT
            // 
            this.gboxT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gboxT.Controls.Add(this.lbet3);
            this.gboxT.Controls.Add(this.lbAcumD);
            this.gboxT.Controls.Add(this.lbAcumC);
            this.gboxT.Controls.Add(this.lbet4);
            this.gboxT.Controls.Add(this.lbCantidad);
            this.gboxT.Controls.Add(this.lbet1);
            this.gboxT.Location = new System.Drawing.Point(36, 267);
            this.gboxT.Name = "gboxT";
            this.gboxT.Size = new System.Drawing.Size(260, 135);
            this.gboxT.TabIndex = 112;
            this.gboxT.TabStop = false;
            this.gboxT.Text = "Detalles";
            // 
            // lbet3
            // 
            this.lbet3.AutoSize = true;
            this.lbet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbet3.ForeColor = System.Drawing.Color.Red;
            this.lbet3.Location = new System.Drawing.Point(10, 72);
            this.lbet3.Name = "lbet3";
            this.lbet3.Size = new System.Drawing.Size(146, 20);
            this.lbet3.TabIndex = 110;
            this.lbet3.Text = "Acumulado en ₡:";
            // 
            // lbAcumD
            // 
            this.lbAcumD.AutoSize = true;
            this.lbAcumD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcumD.ForeColor = System.Drawing.Color.Red;
            this.lbAcumD.Location = new System.Drawing.Point(172, 97);
            this.lbAcumD.Name = "lbAcumD";
            this.lbAcumD.Size = new System.Drawing.Size(19, 20);
            this.lbAcumD.TabIndex = 101;
            this.lbAcumD.Text = "0";
            // 
            // lbAcumC
            // 
            this.lbAcumC.AutoSize = true;
            this.lbAcumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcumC.ForeColor = System.Drawing.Color.Red;
            this.lbAcumC.Location = new System.Drawing.Point(172, 72);
            this.lbAcumC.Name = "lbAcumC";
            this.lbAcumC.Size = new System.Drawing.Size(19, 20);
            this.lbAcumC.TabIndex = 109;
            this.lbAcumC.Text = "0";
            // 
            // lbet4
            // 
            this.lbet4.AutoSize = true;
            this.lbet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbet4.ForeColor = System.Drawing.Color.Red;
            this.lbet4.Location = new System.Drawing.Point(10, 97);
            this.lbet4.Name = "lbet4";
            this.lbet4.Size = new System.Drawing.Size(148, 20);
            this.lbet4.TabIndex = 102;
            this.lbet4.Text = "Acumulado en $: ";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.Red;
            this.lbCantidad.Location = new System.Drawing.Point(172, 21);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(19, 20);
            this.lbCantidad.TabIndex = 105;
            this.lbCantidad.Text = "0";
            // 
            // lbet1
            // 
            this.lbet1.AutoSize = true;
            this.lbet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbet1.ForeColor = System.Drawing.Color.Red;
            this.lbet1.Location = new System.Drawing.Point(6, 22);
            this.lbet1.Name = "lbet1";
            this.lbet1.Size = new System.Drawing.Size(81, 20);
            this.lbet1.TabIndex = 106;
            this.lbet1.Text = "Cantidad";
            // 
            // gbox3
            // 
            this.gbox3.Controls.Add(this.rdbVentas);
            this.gbox3.Controls.Add(this.rdbCierres);
            this.gbox3.Controls.Add(this.rdbGastos);
            this.gbox3.Location = new System.Drawing.Point(23, 56);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(273, 76);
            this.gbox3.TabIndex = 105;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "Tipo de Reporte";
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
            this.rdbGastos.Location = new System.Drawing.Point(25, 37);
            this.rdbGastos.Name = "rdbGastos";
            this.rdbGastos.Size = new System.Drawing.Size(58, 17);
            this.rdbGastos.TabIndex = 101;
            this.rdbGastos.Text = "Gastos";
            this.rdbGastos.UseVisualStyleBackColor = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(375, 31);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(116, 20);
            this.dtpInicio.TabIndex = 82;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(23, 156);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 39);
            this.btnAceptar.TabIndex = 64;
            this.btnAceptar.Text = "Generar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // dtgCierres
            // 
            this.dtgCierres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCierres.BackgroundColor = System.Drawing.Color.White;
            this.dtgCierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCierres.Location = new System.Drawing.Point(330, 73);
            this.dtgCierres.Name = "dtgCierres";
            this.dtgCierres.ReadOnly = true;
            this.dtgCierres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCierres.Size = new System.Drawing.Size(428, 329);
            this.dtgCierres.TabIndex = 70;
            // 
            // lbdesde
            // 
            this.lbdesde.AutoSize = true;
            this.lbdesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdesde.Location = new System.Drawing.Point(327, 36);
            this.lbdesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdesde.Name = "lbdesde";
            this.lbdesde.Size = new System.Drawing.Size(43, 15);
            this.lbdesde.TabIndex = 81;
            this.lbdesde.Text = "Desde";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(633, 407);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 39);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(770, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 24);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 30);
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
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(616, 31);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(115, 20);
            this.dtpHasta.TabIndex = 114;
            // 
            // lbHasta
            // 
            this.lbHasta.AutoSize = true;
            this.lbHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasta.Location = new System.Drawing.Point(572, 38);
            this.lbHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHasta.Name = "lbHasta";
            this.lbHasta.Size = new System.Drawing.Size(39, 15);
            this.lbHasta.TabIndex = 113;
            this.lbHasta.Text = "Hasta";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportar.Location = new System.Drawing.Point(522, 407);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(98, 39);
            this.btnExportar.TabIndex = 115;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // Reportes_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes_View";
            this.Text = "Reportes_View";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.gboxT.ResumeLayout(false);
            this.gboxT.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCierres)).EndInit();
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
        private System.Windows.Forms.Label lbet3;
        private System.Windows.Forms.Label lbAcumD;
        private System.Windows.Forms.Label lbAcumC;
        private System.Windows.Forms.Label lbet4;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbet1;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.RadioButton rdbCierres;
        private System.Windows.Forms.RadioButton rdbGastos;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgCierres;
        private System.Windows.Forms.Label lbdesde;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
    }
}