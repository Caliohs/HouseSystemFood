using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;
namespace Vista.Seguridad
{
    public partial class Permisos_View : Form
    {
        private DataTable datos;
        private Menus menu;       
        private MenusHelper menuH;

        public Permisos_View()
        {
            InitializeComponent();
        }

        public Permisos_View(Roles obj)
        {
            InitializeComponent();
            this.lbRol.Text =  obj.Nombre;
            //validarPerfil(obj.Perfil); se usa para validar los permisos
        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void PermisosCmb_View_Load(object sender, EventArgs e)
        {
           
            // cargarCmbPermisos();
            cargarDatosDtg();
        }
        //public void cargarCmbPermisos()
        //{
        //    try
        //    {
        //        menu = new Menus();
        //        menu.Opc = 2;
        //        menuH = new MenusHelper(menu);
        //        datos = menuH.Listar();

        //        string[] dt = new string[datos.Rows.Count];
        //        for (int i = 0; i < datos.Rows.Count; i++)
        //        {
        //            dt[i] = datos.Rows[i]["Item_Menu"].ToString();
        //        }
        //        cmbPermiso.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarDatosDtg()
        {
            try
            {
                menu = new Menus();
                menu.Opc = 2;
                menuH = new MenusHelper(menu);
                datos = menuH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgMenus.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
