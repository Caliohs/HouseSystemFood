using HouseSystemFood.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
using Vista.Seguridad;



namespace HouseSystemFood.Vista
{

    public partial class Principal : Form
    {
        public int xClick = 0, yClick = 0;
        private Usuario_View usuario_view;
        private Gastos_View menus_View;
        private Roles_View roles_View;
        private Bitacoras_View bitacoras_View;
        private Productos_View productos_View;
        private Categorias_View categorias_View;
        private Permisos permisos;
        private PermisosHelper permisosH;
        private Ordenes_View Ordenes_View;
        private Cobros_View Cobros_View;
        private DataTable datos;
        private Acercade acercade;
        private Usuario user;
        public int IdUser;

        //private Acercade acerca;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuario obj)
        {
            InitializeComponent();
            this.statusUsuario.Text = "Bienvenid@ " + obj.Nombre;
            validarPerfil(obj.RolId);
            IdUser = obj.Id;
        }

        private void validarPerfil(int RolId)
        {
            try
            {
                permisos = new Permisos();
                permisos.Opc = 4;
                permisos.Rolid = RolId;
                permisosH = new PermisosHelper(permisos);
                datos= permisosH.ValidarPermisos();
                if (datos.Rows.Count > 0)
                {
                    for(int i=0; i< datos.Rows.Count; i++)
                    {
                        DataRow fila = datos.Rows[i];
                        string nombre = fila["Nombre_del_modulo"].ToString();
                        int estado = 0;
                        if (fila["Estado"].Equals(true))
                            estado =1;
                       
                        if (this.MantenimientoItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.MantenimientoItem.Visible = false;
                        }
                        if (this.OrdenesItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.OrdenesItem.Visible = false;
                        }
                        if (this.CobrarItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.CobrarItem.Visible = false;
                        }
                        if (this.CierresItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.CierresItem.Visible = false;
                        }
                        if (this.GastosItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.GastosItem.Visible = false;
                        }
                        if (this.ReportesItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.ReportesItem.Visible = false;
                        }
                        if (this.acercaDeItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.acercaDeItem.Visible = false;
                        }
                        if (this.AyudaItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.AyudaItem.Visible = false;
                        }
                        if (this.CategoriasItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.CategoriasItem.Visible = false;
                        }
                        if (this.ProductosItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.ProductosItem.Visible = false;
                        }
                        if (this.UsuariosItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.UsuariosItem.Visible = false;
                        }
                        if (this.SeguridadItem.Text.Equals(nombre) && estado.Equals(0))
                        {
                            this.SeguridadItem.Visible = false;
                        }

                    }

                 }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.acercade = new Acercade();
            this.acercade.MdiParent = this;
            this.acercade.Show();
        }

        private void UsuariosUsuatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.usuario_view = new Usuario_View(user);
            this.usuario_view.MdiParent = this;
            this.usuario_view.Show();
        }

        private void PermisostoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.menus_View = new Gastos_View();
            this.menus_View.MdiParent = this;
            this.menus_View.Show();
        }

        private void RolestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.roles_View = new Roles_View();
            this.roles_View.MdiParent = this;
            this.roles_View.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarToolStripMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CategoriasItem_Click(object sender, EventArgs e)
        {
            this.categorias_View = new Categorias_View();
            this.categorias_View.MdiParent = this;
            this.categorias_View.Show();
        }

        private void ProductosItem_Click(object sender, EventArgs e)
        {
            this.productos_View = new Productos_View();
            this.productos_View.MdiParent = this;
            this.productos_View.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void OrdenarItem_Click(object sender, EventArgs e)
        {
            this.Ordenes_View = new Ordenes_View();
            this.Ordenes_View.MdiParent = this;
            this.Ordenes_View.Show();
        }

        private void CobrarItem_Click(object sender, EventArgs e)
        {
            this.Cobros_View = new Cobros_View();
            this.Cobros_View.MdiParent =this;
            this.Cobros_View.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void BitacorasItem_Click(object sender, EventArgs e)
        {
            this.bitacoras_View = new Bitacoras_View();
            this.bitacoras_View.MdiParent = this;
            this.bitacoras_View.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
