using HouseSystemFood.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Seguridad
{
   
    public partial class Roles_View : Form
    {
        private Permisos_View dtg_view;

        private DataTable datos;
        private Roles roles;
        private RolesHelper rolesH;

        public Roles_View()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Agregar_Rol();
        }
        public void Agregar_Rol()
        {
            //guarda un nuevo usuario
            try
            {

                roles = new Roles();
                roles.Opc = 1;
                roles.Nombre = this.txtNombre.Text;
                roles.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                rolesH = new RolesHelper(roles);
                rolesH.Guardar();

                MessageBox.Show("Se ha registrado un nuevo Rol o puesto");
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
                roles = new Roles();
                roles.Opc = 2;
                rolesH = new RolesHelper(roles);
                datos = rolesH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgRoles.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                datos = (DataTable)dtgRoles.DataSource;
               
                {
                    int indice = dtgRoles.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];                                   
                    roles.Nombre = fila["Nombre_del_rol"].ToString();
                    this.dtg_view = new Permisos_View(roles);
                    this.dtg_view.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Roles_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
        }
    }
}
