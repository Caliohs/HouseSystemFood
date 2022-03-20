using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HouseSystemFood.Controlador;

namespace HouseSystemFood.Vista
{
    public partial class Usuario_View : Form
    {

        private DataTable datos;
        private Usuario usuario;
        private UsuarioHelper usuarioH;
        private Roles roles;
        private RolesHelper rolesH;
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

        public int UserId;
        public Usuario_View()
        {
            InitializeComponent();
        }
        public Usuario_View(Usuario obj)
        {
            InitializeComponent();
            UserId = obj.Id;
        }


        private void Usuario_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
            cargarCmbRoles();
        }
        public void cargarDatosDtg()
        {
            try
            {
                usuario = new Usuario();
                usuario.Opc = 2;
                usuarioH = new UsuarioHelper(usuario);
                datos = usuarioH.Listar();

                if (datos.Rows.Count > 0)
                {
                    dtgUsuario.DataSource = datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar_Usuario();
        }

        public void Guardar_Usuario()
        {
            //guarda un nuevo usuario
            try
            { 
            
                //obtengo elrol Id
                datos = rolesH.GetRolId(this.cmbRoles.Text);            
                string[] dt = new string[datos.Rows.Count];           
                dt[0] = datos.Rows[0]["RolId"].ToString();         

                if (this.txtContraeña.Text.Equals(this.txtConfirmar.Text))
                {
                    usuario = new Usuario();                
                    usuario.User = this.txtUsuario.Text;
                    usuario.Nombre = this.txtNombre.Text;
                    usuario.RolId = int.Parse(dt[0]);
                    usuario.Contraseña = Encriptar(this.txtContraeña.Text); // se encripta la clave
                    usuario.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());

                    if (this.btnAceptar.Text.Equals("Aceptar"))
                    {
                        usuario.Opc = 1;
                        usuarioH = new UsuarioHelper(usuario);
                        usuarioH.Guardar();
                        //registro el evento
                        RegistarEnBitacora("INSERT");
                        MessageBox.Show("Se ha almacenado un nuevo Usuario");
                    }
                    else
                    {
                        datos = (DataTable)dtgUsuario.DataSource;
                        int indice = dtgUsuario.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        usuario.Opc = 4;                      
                        usuario.Id = int.Parse(fila["UsuariosId"].ToString());
                        usuarioH = new UsuarioHelper(usuario);
                        usuarioH.Actualizar();
                        //registro el evento
                        RegistarEnBitacora("UPDATE");
                        MessageBox.Show("Se ha actualizó el Usuario");

                        this.btnAceptar.Text = "Aceptar";
                    }
                    
                }
                else
                {
                    MessageBox.Show("La contraseña y la confirmación no coinceden");
                }
                cargarDatosDtg();
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
                usuario = new Usuario();
                usuario.Opc = 3;
                usuario.Nombre = this.txtBuscar.Text;
                usuarioH = new UsuarioHelper(usuario);
                datos = usuarioH.Buscar();             
                if (datos.Rows.Count > 0)
                {
                    dtgUsuario.DataSource = datos;
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
                datos = (DataTable)dtgUsuario.DataSource;

                int indice = dtgUsuario.CurrentRow.Index;
                DataRow fila = datos.Rows[indice];
                this.txtUsuario.Text = fila["Usuario"].ToString();
                this.txtNombre.Text = fila["Nombre"].ToString();
                this.cmbRoles.Text = fila["Nombre_del_rol"].ToString();
                this.txtContraeña.Text = fila["Contrasena"].ToString();
                this.txtConfirmar.Text = fila["Contrasena"].ToString();
               

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

                datos = (DataTable)dtgUsuario.DataSource;
                if (datos == null)
                {
                    MessageBox.Show("No hay registros por Eliminar");

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo);
                    if (result.Equals(DialogResult.Yes))
                    {
                        int indice = dtgUsuario.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];

                        usuario = new Usuario();
                        usuario.Opc = 5;
                        usuario.Id = int.Parse(fila["UsuariosId"].ToString());
                        usuarioH = new UsuarioHelper(usuario);
                        usuarioH.Eliminar();
                        //registro el evento
                        RegistarEnBitacora("DELETE");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //aqui encripto la contraseña
        public string Encriptar(string clave)
        {

            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(clave));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
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
                bitacoras.Tabla = "USUARIOS";
                bitacoras.Fecha = DateTime.Today;
                bitacorasH = new BitacorasHelper(bitacoras);
                bitacorasH.InsertarEnBitacora();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }

}
