
namespace HouseSystemFood.Vista
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MantenimientoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeguridadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitacorasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CierresItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GastosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoItem,
            this.OrdenesItem,
            this.CierresItem,
            this.GastosItem,
            this.ReportesItem,
            this.acercaDeItem,
            this.AyudaItem,
            this.CerrarSesionItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 35, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 60);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MantenimientoItem
            // 
            this.MantenimientoItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriasItem,
            this.ProductosItem,
            this.UsuariosItem,
            this.SeguridadItem});
            this.MantenimientoItem.Name = "MantenimientoItem";
            this.MantenimientoItem.Size = new System.Drawing.Size(128, 25);
            this.MantenimientoItem.Text = "Mantenimiento";
            this.MantenimientoItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // CategoriasItem
            // 
            this.CategoriasItem.Name = "CategoriasItem";
            this.CategoriasItem.Size = new System.Drawing.Size(180, 26);
            this.CategoriasItem.Text = "Categorias";
            this.CategoriasItem.Click += new System.EventHandler(this.CategoriasItem_Click);
            // 
            // ProductosItem
            // 
            this.ProductosItem.Name = "ProductosItem";
            this.ProductosItem.Size = new System.Drawing.Size(180, 26);
            this.ProductosItem.Text = "Productos";
            this.ProductosItem.Click += new System.EventHandler(this.ProductosItem_Click);
            // 
            // UsuariosItem
            // 
            this.UsuariosItem.Name = "UsuariosItem";
            this.UsuariosItem.Size = new System.Drawing.Size(180, 26);
            this.UsuariosItem.Text = "Usuarios";
            this.UsuariosItem.Click += new System.EventHandler(this.UsuariosUsuatoolStripMenuItem_Click);
            // 
            // SeguridadItem
            // 
            this.SeguridadItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RolesItem,
            this.PermisosItem,
            this.BitacorasItem});
            this.SeguridadItem.Name = "SeguridadItem";
            this.SeguridadItem.Size = new System.Drawing.Size(180, 26);
            this.SeguridadItem.Text = "Seguridad";
            // 
            // RolesItem
            // 
            this.RolesItem.Name = "RolesItem";
            this.RolesItem.Size = new System.Drawing.Size(201, 26);
            this.RolesItem.Text = "Registro de Roles";
            this.RolesItem.Click += new System.EventHandler(this.RolestoolStripMenuItem1_Click);
            // 
            // PermisosItem
            // 
            this.PermisosItem.Name = "PermisosItem";
            this.PermisosItem.Size = new System.Drawing.Size(201, 26);
            this.PermisosItem.Text = "Items de menu";
            this.PermisosItem.Click += new System.EventHandler(this.PermisostoolStripMenuItem1_Click);
            // 
            // BitacorasItem
            // 
            this.BitacorasItem.Name = "BitacorasItem";
            this.BitacorasItem.Size = new System.Drawing.Size(201, 26);
            this.BitacorasItem.Text = "Bitacoras";
            // 
            // OrdenesItem
            // 
            this.OrdenesItem.Name = "OrdenesItem";
            this.OrdenesItem.Size = new System.Drawing.Size(81, 25);
            this.OrdenesItem.Text = "Ordenes";
            this.OrdenesItem.Click += new System.EventHandler(this.OrdenesItem_Click);
            // 
            // CierresItem
            // 
            this.CierresItem.Name = "CierresItem";
            this.CierresItem.Size = new System.Drawing.Size(71, 25);
            this.CierresItem.Text = "Cierres";
            // 
            // GastosItem
            // 
            this.GastosItem.Name = "GastosItem";
            this.GastosItem.Size = new System.Drawing.Size(69, 25);
            this.GastosItem.Text = "Gastos";
            // 
            // ReportesItem
            // 
            this.ReportesItem.Name = "ReportesItem";
            this.ReportesItem.Size = new System.Drawing.Size(84, 25);
            this.ReportesItem.Text = "Reportes";
            // 
            // acercaDeItem
            // 
            this.acercaDeItem.Name = "acercaDeItem";
            this.acercaDeItem.Size = new System.Drawing.Size(91, 25);
            this.acercaDeItem.Text = "AcercaDe ";
            this.acercaDeItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // AyudaItem
            // 
            this.AyudaItem.Name = "AyudaItem";
            this.AyudaItem.Size = new System.Drawing.Size(73, 25);
            this.AyudaItem.Text = "Ayuda?";
            // 
            // CerrarSesionItem
            // 
            this.CerrarSesionItem.Name = "CerrarSesionItem";
            this.CerrarSesionItem.Size = new System.Drawing.Size(112, 25);
            this.CerrarSesionItem.Text = "CerrarSesion";
            this.CerrarSesionItem.Click += new System.EventHandler(this.CerrarToolStripMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUsuario
            // 
            this.statusUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusUsuario.ForeColor = System.Drawing.Color.Green;
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(65, 21);
            this.statusUsuario.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 30);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(615, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(151, 24);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Modulo Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1319, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 24);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasItem;
        private System.Windows.Forms.ToolStripMenuItem ProductosItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenesItem;
        private System.Windows.Forms.ToolStripMenuItem CierresItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionItem;
        private System.Windows.Forms.ToolStripMenuItem SeguridadItem;
        private System.Windows.Forms.ToolStripMenuItem RolesItem;
        private System.Windows.Forms.ToolStripMenuItem PermisosItem;
        private System.Windows.Forms.ToolStripMenuItem BitacorasItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosItem;
        private System.Windows.Forms.ToolStripMenuItem GastosItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem AyudaItem;
    }
}