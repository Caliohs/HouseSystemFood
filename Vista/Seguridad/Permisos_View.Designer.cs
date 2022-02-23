namespace Vista.Seguridad
{
    partial class Permisos_View
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbAsignarPermiso = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lbtitle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 30);
            this.panel2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(554, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.BackColor = System.Drawing.Color.Transparent;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.White;
            this.lbtitle.Location = new System.Drawing.Point(12, 7);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(148, 20);
            this.lbtitle.TabIndex = 6;
            this.lbtitle.Text = "Gestionar Permisos";
            this.lbtitle.Click += new System.EventHandler(this.lbtitle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(781, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(462, 352);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 39);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(351, 352);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 39);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Aplicar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbAsignarPermiso
            // 
            this.lbAsignarPermiso.AutoSize = true;
            this.lbAsignarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignarPermiso.ForeColor = System.Drawing.Color.Black;
            this.lbAsignarPermiso.Location = new System.Drawing.Point(40, 82);
            this.lbAsignarPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAsignarPermiso.Name = "lbAsignarPermiso";
            this.lbAsignarPermiso.Size = new System.Drawing.Size(162, 16);
            this.lbAsignarPermiso.TabIndex = 65;
            this.lbAsignarPermiso.Text = "Editando permisos al Rol:";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.Color.Black;
            this.lbRol.Location = new System.Drawing.Point(206, 82);
            this.lbRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(32, 16);
            this.lbRol.TabIndex = 68;
            this.lbRol.Text = "Rol";
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToAddRows = false;
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.AllowUserToResizeColumns = false;
            this.dtgPermisos.AllowUserToResizeRows = false;
            this.dtgPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPermisos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgPermisos.Location = new System.Drawing.Point(27, 106);
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos.Size = new System.Drawing.Size(528, 226);
            this.dtgPermisos.TabIndex = 69;
            this.dtgPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(419, 78);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(136, 20);
            this.txtBuscar.TabIndex = 77;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(370, 83);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(45, 15);
            this.lbBuscar.TabIndex = 82;
            this.lbBuscar.Text = "Buscar";
            // 
            // Permisos_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(585, 413);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgPermisos);
            this.Controls.Add(this.lbRol);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbAsignarPermiso);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permisos_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermisosCmb_View";
            this.Load += new System.EventHandler(this.PermisosCmb_View_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbAsignarPermiso;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
    }
}