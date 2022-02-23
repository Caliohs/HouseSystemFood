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
            Guardar_Rol();
        }

        public void Guardar_Rol()
        {
            //guarda rol
            try
            {

                roles = new Roles();
                if (this.btnAceptar.Text.Equals("Aceptar"))
                {
                    roles.Opc = 1;
                roles.Nombre = this.txtNombre.Text;
                roles.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                rolesH = new RolesHelper(roles);
                rolesH.Guardar();

                MessageBox.Show("Se ha registrado un nuevo Rol o puesto");
               
                }
                else
                {
                    datos = (DataTable)dtgRoles.DataSource;

                    int indice = dtgRoles.CurrentRow.Index;
                    DataRow fila = datos.Rows[indice];

                    roles.Opc = 4;
                    roles.Nombre = this.txtNombre.Text;
                    roles.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
                    roles.Id = int.Parse(fila["RolId"].ToString());
                    rolesH = new RolesHelper(roles);
                    rolesH.Actualizar();

                    MessageBox.Show("Se ha actualizó el Rol");

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
                    roles.Id = int.Parse(fila["RolId"].ToString());
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                roles = new Roles();
                roles.Opc = 3;
                roles.Nombre = this.txtBuscar.Text;
                rolesH = new RolesHelper(roles);
                datos = rolesH.Buscar();

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

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnAceptar.Text = "Actualizar";
                datos = (DataTable)dtgRoles.DataSource;

                int indice = dtgRoles.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
                this.txtNombre.Text = fila["Nombre_del_rol"].ToString();
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

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                datos = (DataTable)dtgRoles.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgRoles.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        roles = new Roles();
                        roles.Opc = 5;
                        roles.Id = int.Parse(fila["RolId"].ToString());
                        rolesH = new RolesHelper(roles);
                        rolesH.Eliminar();

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
    }
}
