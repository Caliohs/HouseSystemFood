﻿using System;
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
        private DataTable dataUser;
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
            
                //obtengo elrol Id para insertarlo en tabla usuarios
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
                        //Antes de registrar valido que exista el usuario
                        usuario.Opc = 7;
                        usuarioH = new UsuarioHelper(usuario);
                        dataUser = usuarioH.validarLogin(); 
                        //si existe
                        if (dataUser.Rows.Count > 0)
                        {
                            MessageBox.Show("Ya existe el usuario","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (validarCampos().Equals(1))        //si la bandera es 1 hay campos vacios y no hago el insert
                        {
                            MessageBox.Show("Debe completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else //hago el insert
                        {
                            usuario.Opc = 1;
                            usuarioH.Guardar();
                            //registro el evento
                            RegistarEnBitacora("INSERT");
                            cargarDatosDtg();
                            MessageBox.Show("Se ha almacenado un nuevo Usuario","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                       
                    }
                    else if(this.btnAceptar.Text.Equals("Actualizar"))
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
                        cargarDatosDtg();
                        MessageBox.Show("Se actualizó el Usuario","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnAceptar.Text = "Aceptar";
                        Limpiar();
                    }
                    else //cambiar clave
                    {
                        datos = (DataTable)dtgUsuario.DataSource;
                        int indice = dtgUsuario.CurrentRow.Index;
                        DataRow fila = datos.Rows[indice];
                        usuario.Opc = 8;
                        usuario.Id = int.Parse(fila["UsuariosId"].ToString());
                        usuarioH = new UsuarioHelper(usuario);
                        usuarioH.CambiarClave();
                        //registro el evento
                        RegistarEnBitacora("UPDATE-CLAVE");
                        cargarDatosDtg();
                        MessageBox.Show("Se cambio la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.btnAceptar.Text = "Aceptar";
                        Limpiar();
                    }
                    
                }
                else
                {
                    MessageBox.Show("La contraseña y la confirmación no coinceden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.txtUsuario.Enabled = false;
                this.txtContraeña.Enabled = false;
                this.txtConfirmar.Enabled = false;

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
                    MessageBox.Show("No hay registros por Eliminar","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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
                        cargarDatosDtg();
                        RegistarEnBitacora("DELETE");
                        MessageBox.Show("Se ha eliminado el registro","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
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

        public void Limpiar()
        {
            this.txtUsuario.Enabled = true;
            this.txtContraeña.Enabled = true;
            this.txtConfirmar.Enabled = true;
            this.txtUsuario.Clear();
            this.txtNombre.Clear();
            this.txtContraeña.Clear();
            this.txtConfirmar.Clear();
            this.cmbRoles.SelectedIndex = - 1;
            this.txtNombre.Enabled = true;
            this.cmbRoles.Enabled = true;
            this.cmbEstado.Enabled = true;

        }
    
        //valida los campos vacios y no permite una ejecucion
        public int validarCampos()
        {
            int bandera = 0;
            string [] dato = new string [6];
            
            dato[0]= this.txtNombre.Text;
            dato[1] = this.txtUsuario.Text;
            dato[2] = this.txtContraeña.Text;
            dato[3] = this.txtConfirmar.Text;
            dato[4] = this.cmbRoles.Text;
            dato[5] = this.cmbEstado.Text;
            for(int i=0; i<6; i++)
            {
                if (dato[i].Equals(""))
                {
                    bandera = 1;
                }
            }
            return bandera;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripCambiarClave_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Text = "Cambiar";
            datos = (DataTable)dtgUsuario.DataSource;

            int indice = dtgUsuario.CurrentRow.Index;
            DataRow fila = datos.Rows[indice];
            this.txtUsuario.Text = fila["Usuario"].ToString();                   
            this.txtUsuario.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cmbRoles.Enabled = false;
            this.cmbEstado.Enabled = false;

        }
    }

}
