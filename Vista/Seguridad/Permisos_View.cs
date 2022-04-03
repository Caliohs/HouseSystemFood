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
        private Roles roles;
        private RolesHelper rolesH;
        public int IdRol;
        public int UserId;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public Permisos_View()
        
        {
            InitializeComponent();
        }
        public Permisos_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }
        public Permisos_View(Roles obj)
        {
            InitializeComponent();
            this.lbRol.Text =  obj.Nombre;
            IdRol = obj.Id;
        }

        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void PermisosCmb_View_Load(object sender, EventArgs e)
        {

            cargarDatosDtg();
            
        }
        public void cargarCmbRoles()
        {
            try
            {
                roles = new Roles();
                roles.Opc = 2;
                rolesH = new RolesHelper(roles);
                datos = rolesH.Listar();

                string[] dt = new string[datos.Rows.Count];

                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    dt[i] = datos.Rows[i]["Nombre_del_rol"].ToString();

                }
                this.cmbRoles.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cuando se ingrea desde Roles
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
        
        //cuando se ingrea desde el menu principal
        public void cargarDatosDtgPermisos()
        {
            try
            {

                permisos = new Permisos();
                permisos.Opc = 5;
                permisosH = new PermisosHelper(permisos);
                datos = permisosH.ListarPermisos(this.cmbRoles.Text);

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

        //cambia el estado activo o Inactivo
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
                         RegistarEnBitacora("UPDATE");
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

        public void RegistarEnBitacora(string accion)
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 1;
                bitacoras.IdUser = UserId;
                bitacoras.Accion = accion;
                bitacoras.Tabla = "PERMISOS";
                bitacoras.Fecha = DateTime.Today;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //carga los permisos del rol seleccionado
        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbRol.Text = this.cmbRoles.Text;
            cargarDatosDtgPermisos();
        }

        //desbloquea el combo para seleccionar un rol
        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkLock.Checked.Equals(false))
            {
                this.cmbRoles.Enabled = true;
                cargarCmbRoles();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
