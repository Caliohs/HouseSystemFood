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

        private void Menus_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar_Menu();

        }
        public void Guardar_Menu()
        {
            //guarda un nuevo usuario
            try
            {
                menu = new Menus();
                if (this.btnAceptar.Text.Equals("Aceptar"))
                {
                   
                    menu.Opc = 1;
                    menu.Nombre = this.txtNombre.Text;
                    menu.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                    menuH = new MenusHelper(menu);
                    menuH.Guardar();

                    MessageBox.Show("Se ha reigstrado un nuevo menu");
                }
                else
                {
                    datos = (DataTable)dtgMenus.DataSource;

                    int indice = dtgMenus.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                   
                    menu.Opc = 4;
                    menu.Nombre = this.txtNombre.Text;
                    menu.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                    menu.Id = int.Parse(fila["MenuId"].ToString());
                    menuH = new MenusHelper(menu);
                    menuH.Actualizar();

                    MessageBox.Show("Se ha actualizo el menu");
                   
                    this.btnAceptar.Text = "Aceptar";
                }
                   
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnAceptar.Text = "Actualizar";
                datos = (DataTable)dtgMenus.DataSource;
           
                    int indice = dtgMenus.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];
                    this.txtNombre.Text = fila["Item_Menu"].ToString();
                if (fila["Estado"].Equals(true))
                {
                    this.cmbEstado.SelectedItem = "Activo";                 
                }
                else
                {
                    this.cmbEstado.SelectedItem = "Inactivo";
                }
                          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                menu = new Menus();
                menu.Opc = 3;
                menu.Nombre = this.txtBuscar.Text;
                menuH = new MenusHelper(menu);
                datos = menuH.Buscar();

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

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            try
            {
             
                datos = (DataTable)dtgMenus.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar");

                } else
                {
                    DialogResult result= MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo);
                    if( result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgMenus.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        menu = new Menus();
                        menu.Opc = 5;
                        menu.Id = int.Parse(fila["MenuId"].ToString());
                        menuH = new MenusHelper(menu);
                        menuH.Eliminar();

                        MessageBox.Show("Se ha eliminado el registro");
                        cargarDatosDtg();
                    }
                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
