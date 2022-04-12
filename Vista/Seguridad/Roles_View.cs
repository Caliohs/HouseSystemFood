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
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public int UserId;

        public Roles_View()
        {
            InitializeComponent();
        }
        public Roles_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Equals("") || this.cmbEstado.Text.Equals(""))
            {
                MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Guardar_Rol();
            }
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
                    cargarDatosDtg();
                    RegistarEnBitacora("INSERT");
                MessageBox.Show("Se ha registrado un nuevo Rol o puesto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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
                    cargarDatosDtg();
                    RegistarEnBitacora("UPDATE");
                    MessageBox.Show("Se actualizó el Rol", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.btnAceptar.Text = "Aceptar";
                }

                this.txtNombre.Text = "";
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
                    MessageBox.Show("No hay registros por Eliminar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgRoles.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        roles = new Roles();
                        roles.Opc = 5;
                        roles.Id = int.Parse(fila["RolId"].ToString());
                        rolesH = new RolesHelper(roles);
                        rolesH.Eliminar();
                        cargarDatosDtg();
                        RegistarEnBitacora("DELETE");
                        MessageBox.Show("Se ha eliminado el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                }
            }
            catch
            {

                MessageBox.Show("No se puede eliminar porque otro registro depende este", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "ROLES";
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
