namespace Vista
{
    partial class Gastos_View
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
            this.components = new System.ComponentModel.Container();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.gboxMoneda = new System.Windows.Forms.GroupBox();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbColon = new System.Windows.Forms.RadioButton();
            this.chkRetiro = new System.Windows.Forms.CheckBox();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rdbPlanilla = new System.Windows.Forms.RadioButton();
            this.rdbServ = new System.Windows.Forms.RadioButton();
            this.rdbUten = new System.Windows.Forms.RadioButton();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mskMonto = new System.Windows.Forms.MaskedTextBox();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gBox.SuspendLayout();
            this.gboxMoneda.SuspendLayout();
            this.gbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.gboxMoneda);
            this.gBox.Controls.Add(this.chkRetiro);
            this.gBox.Controls.Add(this.gbox3);
            this.gBox.Controls.Add(this.label1);
            this.gBox.Controls.Add(this.lbMonto);
            this.gBox.Controls.Add(this.dtpFecha);
            this.gBox.Controls.Add(this.mskMonto);
            this.gBox.Controls.Add(this.dtgGastos);
            this.gBox.Controls.Add(this.txtBuscar);
            this.gBox.Controls.Add(this.lbBuscar);
            this.gBox.Controls.Add(this.btnCancelar);
            this.gBox.Controls.Add(this.lbDescripcion);
            this.gBox.Controls.Add(this.btnAceptar);
            this.gBox.Controls.Add(this.txtJustificacion);
            this.gBox.Location = new System.Drawing.Point(12, 46);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(1176, 547);
            this.gBox.TabIndex = 83;
            this.gBox.TabStop = false;
            this.gBox.Text = "Gestion de gastos";
            this.gBox.Enter += new System.EventHandler(this.gBox_Enter);
            // 
            // gboxMoneda
            // 
            this.gboxMoneda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxMoneda.Controls.Add(this.rdbDolar);
            this.gboxMoneda.Controls.Add(this.rdbColon);
            this.gboxMoneda.Location = new System.Drawing.Point(39, 155);
            this.gboxMoneda.Name = "gboxMoneda";
            this.gboxMoneda.Size = new System.Drawing.Size(224, 47);
            this.gboxMoneda.TabIndex = 10;
            this.gboxMoneda.TabStop = false;
            this.gboxMoneda.Text = "Moneda";
            this.gboxMoneda.Enter += new System.EventHandler(this.gboxMoneda_Enter);
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Location = new System.Drawing.Point(108, 19);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(61, 17);
            this.rdbDolar.TabIndex = 6;
            this.rdbDolar.Text = "Dolares";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbColon
            // 
            this.rdbColon.AutoSize = true;
            this.rdbColon.Checked = true;
            this.rdbColon.Location = new System.Drawing.Point(25, 19);
            this.rdbColon.Name = "rdbColon";
            this.rdbColon.Size = new System.Drawing.Size(63, 17);
            this.rdbColon.TabIndex = 5;
            this.rdbColon.TabStop = true;
            this.rdbColon.Text = "Colones";
            this.rdbColon.UseVisualStyleBackColor = true;
            // 
            // chkRetiro
            // 
            this.chkRetiro.AutoSize = true;
            this.chkRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRetiro.Location = new System.Drawing.Point(154, 125);
            this.chkRetiro.Name = "chkRetiro";
            this.chkRetiro.Size = new System.Drawing.Size(107, 17);
            this.chkRetiro.TabIndex = 3;
            this.chkRetiro.Text = "Retira de Caja";
            this.chkRetiro.UseVisualStyleBackColor = true;
            // 
            // gbox3
            // 
            this.gbox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox3.Controls.Add(this.rdbOtro);
            this.gbox3.Controls.Add(this.rdbPlanilla);
            this.gbox3.Controls.Add(this.rdbServ);
            this.gbox3.Controls.Add(this.rdbUten);
            this.gbox3.Controls.Add(this.rdbProd);
            this.gbox3.Location = new System.Drawing.Point(37, 208);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(224, 138);
            this.gbox3.TabIndex = 4;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "Tipo de Gasto";
            this.gbox3.Enter += new System.EventHandler(this.gbox3_Enter);
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Location = new System.Drawing.Point(24, 111);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(50, 17);
            this.rdbOtro.TabIndex = 9;
            this.rdbOtro.Text = "Otros";
            this.rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbPlanilla
            // 
            this.rdbPlanilla.AutoSize = true;
            this.rdbPlanilla.Location = new System.Drawing.Point(24, 65);
            this.rdbPlanilla.Name = "rdbPlanilla";
            this.rdbPlanilla.Size = new System.Drawing.Size(101, 17);
            this.rdbPlanilla.TabIndex = 7;
            this.rdbPlanilla.Text = "Pago de Planilla";
            this.rdbPlanilla.UseVisualStyleBackColor = true;
            // 
            // rdbServ
            // 
            this.rdbServ.AutoSize = true;
            this.rdbServ.Location = new System.Drawing.Point(24, 88);
            this.rdbServ.Name = "rdbServ";
            this.rdbServ.Size = new System.Drawing.Size(111, 17);
            this.rdbServ.TabIndex = 8;
            this.rdbServ.Text = "Pago de Servicios";
            this.rdbServ.UseVisualStyleBackColor = true;
            // 
            // rdbUten
            // 
            this.rdbUten.AutoSize = true;
            this.rdbUten.Location = new System.Drawing.Point(24, 42);
            this.rdbUten.Name = "rdbUten";
            this.rdbUten.Size = new System.Drawing.Size(120, 17);
            this.rdbUten.TabIndex = 6;
            this.rdbUten.Text = "Compra de Utencilio";
            this.rdbUten.UseVisualStyleBackColor = true;
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.Checked = true;
            this.rdbProd.Location = new System.Drawing.Point(25, 19);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(122, 17);
            this.rdbProd.TabIndex = 5;
            this.rdbProd.TabStop = true;
            this.rdbProd.Text = "Compra de Producto";
            this.rdbProd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fecha del gasto";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.Location = new System.Drawing.Point(35, 103);
            this.lbMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(99, 15);
            this.lbMonto.TabIndex = 83;
            this.lbMonto.Text = "Ingrese el Monto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(38, 396);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // mskMonto
            // 
            this.mskMonto.Location = new System.Drawing.Point(39, 122);
            this.mskMonto.Mask = "9999999999";
            this.mskMonto.Name = "mskMonto";
            this.mskMonto.Size = new System.Drawing.Size(100, 20);
            this.mskMonto.TabIndex = 2;
            this.mskMonto.ValidatingType = typeof(int);
            // 
            // dtgGastos
            // 
            this.dtgGastos.AllowUserToAddRows = false;
            this.dtgGastos.AllowUserToDeleteRows = false;
            this.dtgGastos.AllowUserToOrderColumns = true;
            this.dtgGastos.AllowUserToResizeColumns = false;
            this.dtgGastos.AllowUserToResizeRows = false;
            this.dtgGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgGastos.BackgroundColor = System.Drawing.Color.White;
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGastos.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgGastos.Location = new System.Drawing.Point(290, 62);
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.ReadOnly = true;
            this.dtgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGastos.Size = new System.Drawing.Size(852, 454);
            this.dtgGastos.TabIndex = 13;
            this.dtgGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditar,
            this.toolStripEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(117, 22);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(117, 22);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(942, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(883, 33);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(45, 15);
            this.lbBuscar.TabIndex = 80;
            this.lbBuscar.Text = "Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(145, 457);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(34, 60);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(128, 15);
            this.lbDescripcion.TabIndex = 55;
            this.lbDescripcion.Text = "Ingrese la justificación";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(39, 457);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 39);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(37, 78);
            this.txtJustificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(224, 20);
            this.txtJustificacion.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1147, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 24);
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
            this.panel2.Size = new System.Drawing.Size(1200, 30);
            this.panel2.TabIndex = 82;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(21, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(143, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Gestion de Gastos";
            // 
            // Gastos_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 606);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gastos_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos_View";
            this.Load += new System.EventHandler(this.Gastos_View_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.gboxMoneda.ResumeLayout(false);
            this.gboxMoneda.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox mskMonto;
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.CheckBox chkRetiro;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbPlanilla;
        private System.Windows.Forms.RadioButton rdbServ;
        private System.Windows.Forms.RadioButton rdbUten;
        private System.Windows.Forms.RadioButton rdbProd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.GroupBox gboxMoneda;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbColon;
    }
}