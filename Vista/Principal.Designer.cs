
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
            this.MantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeguridadtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisostoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BitacorastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosUsuatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CierresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GastostoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoToolStripMenuItem,
            this.OrdenesToolStripMenuItem,
            this.CierresToolStripMenuItem,
            this.GastostoolStripMenuItem,
            this.ReportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.CerrarToolStripMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 35, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 55);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MantenimientoToolStripMenuItem
            // 
            this.MantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriasToolStripMenuItem,
            this.ProductosToolStripMenuItem,
            this.SeguridadtoolStripMenuItem,
            this.UsuariosUsuatoolStripMenuItem});
            this.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem";
            this.MantenimientoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.MantenimientoToolStripMenuItem.Text = "Matenimiento";
            this.MantenimientoToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.CategoriasToolStripMenuItem.Text = "Categorias";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.reIngresarToolStripMenuItem_Click);
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // SeguridadtoolStripMenuItem
            // 
            this.SeguridadtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RolestoolStripMenuItem1,
            this.PermisostoolStripMenuItem1,
            this.BitacorastoolStripMenuItem1});
            this.SeguridadtoolStripMenuItem.Name = "SeguridadtoolStripMenuItem";
            this.SeguridadtoolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.SeguridadtoolStripMenuItem.Text = "Seguridad";
            // 
            // RolestoolStripMenuItem1
            // 
            this.RolestoolStripMenuItem1.Name = "RolestoolStripMenuItem1";
            this.RolestoolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.RolestoolStripMenuItem1.Text = "Registro de Roles";
            this.RolestoolStripMenuItem1.Click += new System.EventHandler(this.RolestoolStripMenuItem1_Click);
            // 
            // PermisostoolStripMenuItem1
            // 
            this.PermisostoolStripMenuItem1.Name = "PermisostoolStripMenuItem1";
            this.PermisostoolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.PermisostoolStripMenuItem1.Text = "Registro de menu";
            this.PermisostoolStripMenuItem1.Click += new System.EventHandler(this.PermisostoolStripMenuItem1_Click);
            // 
            // BitacorastoolStripMenuItem1
            // 
            this.BitacorastoolStripMenuItem1.Name = "BitacorastoolStripMenuItem1";
            this.BitacorastoolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.BitacorastoolStripMenuItem1.Text = "Ver Bitacoras";
            // 
            // UsuariosUsuatoolStripMenuItem
            // 
            this.UsuariosUsuatoolStripMenuItem.Name = "UsuariosUsuatoolStripMenuItem";
            this.UsuariosUsuatoolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.UsuariosUsuatoolStripMenuItem.Text = "Usuarios";
            this.UsuariosUsuatoolStripMenuItem.Click += new System.EventHandler(this.UsuariosUsuatoolStripMenuItem_Click);
            // 
            // OrdenesToolStripMenuItem
            // 
            this.OrdenesToolStripMenuItem.Name = "OrdenesToolStripMenuItem";
            this.OrdenesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OrdenesToolStripMenuItem.Text = "Ordenes";
            // 
            // CierresToolStripMenuItem
            // 
            this.CierresToolStripMenuItem.Name = "CierresToolStripMenuItem";
            this.CierresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.CierresToolStripMenuItem.Text = "Cierres";
            // 
            // GastostoolStripMenuItem
            // 
            this.GastostoolStripMenuItem.Name = "GastostoolStripMenuItem";
            this.GastostoolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.GastostoolStripMenuItem.Text = "Gastos";
            // 
            // ReportesToolStripMenuItem
            // 
            this.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ReportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // CerrarToolStripMenu
            // 
            this.CerrarToolStripMenu.Name = "CerrarToolStripMenu";
            this.CerrarToolStripMenu.Size = new System.Drawing.Size(96, 20);
            this.CerrarToolStripMenu.Text = "Cerrar Sesion";
            this.CerrarToolStripMenu.Click += new System.EventHandler(this.CerrarToolStripMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUsuario
            // 
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(47, 17);
            this.statusUsuario.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(511, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 20);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Modulo Principal";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1169, 3);
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
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 700);
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
        private System.Windows.Forms.ToolStripMenuItem MantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CierresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.ToolStripMenuItem CerrarToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SeguridadtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RolestoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PermisostoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BitacorastoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UsuariosUsuatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GastostoolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSalir;
    }
}