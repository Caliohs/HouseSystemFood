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
        private Permisos permisos;
        private PermisosHelper permisosH;
        public int IdRol;

        public Permisos_View()
        {
            InitializeComponent();
        }

        public Permisos_View(Roles obj)
        {
            InitializeComponent();
            this.lbRol.Text =  obj.Nombre;
            IdRol = obj.Id;
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
               
                permisos = new Permisos();
                permisos.Opc = 2;
                permisosH = new PermisosHelper(permisos);
                datos = permisosH.Listar(IdRol);

                if (datos.Rows.Count > 0)
                {
                    dtgPermisos.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GuardarPermisos()
        {
            try
            {
                //actualiza los permisos
                datos = (DataTable)dtgPermisos.DataSource;
                  
                        int n_indices = dtgPermisos.RowCount;
                        for (int i = 0; i < n_indices; i++)
                        {
                            permisos = new Permisos();

                            DataRow fila = datos.Rows[i];
                            if (dtgPermisos.CurrentRow != null)
                            {
                                permisos.Id = int.Parse(fila["PermisoId"].ToString());
                                permisos.Nombre = fila["Nombre_del_modulo"].ToString();
                               
                                     if (fila["Estado"].Equals(true))
                                    {
                                      permisos.Estado = 1;
                                     }else
                                     {
                                      permisos.Estado = 0;
                                     }
                                   

                            }
                             permisos.Opc = 1;
                             permisosH = new PermisosHelper(permisos);
                             permisosH.Guardar();
                         }

                        MessageBox.Show("Se han actualizado los permisos");
                        cargarDatosDtg();                                       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarPermisos();
            
        }

        private void dtgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                permisos = new Permisos();
                permisos.Opc = 3;
                permisos.Nombre = this.txtBuscar.Text;
                permisosH = new PermisosHelper(permisos);
                datos = permisosH.Buscar(IdRol);

                if (datos.Rows.Count > 0)
                {
                    dtgPermisos.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
