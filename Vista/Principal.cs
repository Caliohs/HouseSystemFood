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
        //INSTANCIAS Y VARIABLES
        #region
        public int xClick = 0, yClick = 0;
        private Usuario_View usuario_view;
        private Menus_View menus_View;
        private Roles_View roles_View;
        private Permisos_View permisos_View;
        private Bitacoras_View bitacoras_View;
        private Productos_View productos_View;
        private Categorias_View categorias_View;
        private Permisos permisos;
        private PermisosHelper permisosH;
        private Ordenes_View Ordenes_View;
        private Cobros_View Cobros_View;
        private Gastos_View Gastos_View;
        private Cierres_View Cierres_View;
        private Reportes_View Reportes_View;
        private DataTable datos;
        private Acercade acercade;
        private Usuario user;
        private Categorias categorias;
        private Productos productos;
        private Roles roles;
        private Ordenes ordenes;
        private Cobros cobros;
        private Gastos gastos;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;
        public int IdUser;

        #endregion



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

        //valido los modulos a habilitar segun permisos del rol
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
                       
                        if (this.MantenimientoItem.Text.Equals(nombre))
                        {
                            this.MantenimientoItem.Visible = true;
                        }
                        if (this.OrdenesItem.Text.Equals(nombre))
                        {
                            this.OrdenesItem.Visible = true;
                        }
                        if (this.OrdenarItem.Text.Equals(nombre))
                        {
                            this.OrdenarItem.Visible = true;
                        }
                        if (this.CobrarItem.Text.Equals(nombre))
                        {
                            this.CobrarItem.Visible = true;
                        }
                        if (this.CierresItem.Text.Equals(nombre))
                        {
                            this.CierresItem.Visible = true;
                        }
                        if (this.GastosItem.Text.Equals(nombre))
                        {
                            this.GastosItem.Visible = true;
                        }
                        if (this.ReportesItem.Text.Equals(nombre))
                        {
                            this.ReportesItem.Visible = true;
                        }
                        if (this.acercaDeItem.Text.Equals(nombre))
                        {
                            this.acercaDeItem.Visible = true;
                        }
                        if (this.AyudaItem.Text.Equals(nombre))
                        {
                            this.AyudaItem.Visible = true;
                        }
                        if (this.CategoriasItem.Text.Equals(nombre))
                        {
                            this.CategoriasItem.Visible = true;
                        }
                        if (this.ProductosItem.Text.Equals(nombre))
                        {
                            this.ProductosItem.Visible = true;
                        }
                        if (this.UsuariosItem.Text.Equals(nombre))
                        {
                            this.UsuariosItem.Visible = true;
                        }
                        if (this.SeguridadItem.Text.Equals(nombre))
                        {
                            this.SeguridadItem.Visible = true;
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

        private void RolestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.roles_View = new Roles_View(user);
            this.roles_View.MdiParent = this;
            this.roles_View.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RegistarEnBitacora();
            Application.Exit();
        }

        private void CerrarToolStripMenu_Click(object sender, EventArgs e)
        {
            RegistarEnBitacora();
            Application.Restart();
        }

        private void CategoriasItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.categorias_View = new Categorias_View(user);
            this.categorias_View.MdiParent = this;
            this.categorias_View.Show();
        }

        private void ProductosItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.productos_View = new Productos_View(user);
            this.productos_View.MdiParent = this;
            this.productos_View.Show();
        }

        private void OrdenarItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.Ordenes_View = new Ordenes_View(user);
            this.Ordenes_View.MdiParent = this;
            this.Ordenes_View.Show();
        }

        private void CobrarItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.Cobros_View = new Cobros_View(user);
            this.Cobros_View.MdiParent =this;
            this.Cobros_View.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void BitacorasItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.bitacoras_View = new Bitacoras_View();
            this.bitacoras_View.MdiParent = this;
            this.bitacoras_View.Show();
        }

        private void PermisosItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.permisos_View = new Permisos_View(user);
            this.permisos_View.MdiParent = this;
            this.permisos_View.Show();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.menus_View = new Menus_View(user);
            this.menus_View.MdiParent = this;
            this.menus_View.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void GastosItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.Gastos_View = new Gastos_View(user);
            this.Gastos_View.MdiParent = this;
            this.Gastos_View.Show();
        }

        private void CierresItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.Cierres_View = new Cierres_View(user);
            this.Cierres_View.MdiParent = this;
            this.Cierres_View.Show();
        }

        private void ReportesItem_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.Id = IdUser;
            this.Reportes_View = new Reportes_View(user);
            this.Reportes_View.MdiParent = this;
            this.Reportes_View.Show();
        }

        public void RegistarEnBitacora()
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 2;
                bitacoras.IdUser = user.Id;
                bitacoras.Accion = "LOGOUT";
                bitacoras.Fecha = DateTime.Now;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
