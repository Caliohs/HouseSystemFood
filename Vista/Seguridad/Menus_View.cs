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

namespace Vista
{
    public partial class Menus_View : Form
    {
        private DataTable datos;
        private Menus menu;
        private MenusHelper menuH;

        public Menus_View()
        {
            InitializeComponent();
        }

        private void Permisos_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Agregar_Menu();
        }
        public void Agregar_Menu()
        {
            //guarda un nuevo usuario
            try
            {

                menu = new Menus();
                menu.Opc = 1; 
                menu.Nombre = this.txtNombre.Text;
                menu.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                menuH = new MenusHelper(menu);
                menuH.Guardar();

                MessageBox.Show("Se ha reigstrado un nuevo menu");
                cargarDatosDtg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
