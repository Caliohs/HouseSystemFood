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
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;


        public int UserId;

        public Menus_View()
        {
            InitializeComponent();
        }
        public Menus_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void Menus_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text.Equals("") || this.cmbEstado.Text.Equals(""))
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Guardar_Menu();
            }
          

        }

        public void Guardar_Menu()
        {
            //guarda un nuevo menu
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
                    RegistarEnBitacora("INSERT");
                    MessageBox.Show("Se ha registrado un nuevo item de menu","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                    RegistarEnBitacora("UPDATE");
                    MessageBox.Show("Se ha actualizado el item menu", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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
                    MessageBox.Show("No hay registros por Eliminar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                } else
                {
                    DialogResult result= MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if( result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgMenus.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        menu = new Menus();
                        menu.Opc = 5;
                        menu.Id = int.Parse(fila["MenuId"].ToString());
                        menuH = new MenusHelper(menu);
                        menuH.Eliminar();
                        RegistarEnBitacora("DELETE");
                        MessageBox.Show("Se ha eliminado el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //registro el evento
        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "MENUS";
                bitacoras.Fecha = DateTime.Today;
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
