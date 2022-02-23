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
        private Menus_View menus_View;
        private Roles_View roles_View;
       
        //private Acercade acerca;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuario obj)
        {
            //InitializeComponent();
            //this.statusUsuario.Text = "Bienvenid@ " + obj.Nombre;
            //validarPerfil(obj.Perfil);
        }

        private void validarPerfil(object perfil)
        {
            switch (perfil)
            {
                case "Plataforma":
                    this.OrdenesToolStripMenuItem.Visible = false;             
                    this.ReportesToolStripMenuItem.Visible = false;
                    break;

                case "Administrador":
                    this.OrdenesToolStripMenuItem.Visible = false;              
                    break;
            }
        }

        private void reIngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.addHoteles = null;
            //this.addReservas = null;
            //this.addClientes = null;
            //this.acerca = null;
            //Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.addHoteles = null;
            //this.addReservas = null;
            //this.addClientes = null;
            //this.acerca = null;
            //Application.Exit();
        }

        private void gestionarHotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.addHoteles = new GestionarHoteles();
            //this.addHoteles.MdiParent = this;
            //this.addHoteles.Show();
        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.addReservas = new GestionarReservas();
            //this.addReservas.MdiParent = this;
            //this.addReservas.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.addClientes = new GestionarClientes();
            //this.addClientes.MdiParent = this;
            //this.addClientes.Show();
        }

       

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.acerca = new Acercade();
            //this.acerca.MdiParent = this;
            //this.acerca.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosUsuatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.usuario_view = new Usuario_View();
            this.usuario_view.MdiParent = this;
            this.usuario_view.Show();
        }

        private void PermisostoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.menus_View = new Menus_View();
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
