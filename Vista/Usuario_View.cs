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
        public Usuario_View()
        {
            InitializeComponent();
        }

        private void Usuario_View_Load(object sender, EventArgs e)
        {
            cargarDatosDtg();
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
            Crear_Usuario();
        }
        public void Crear_Usuario()
        {
            //guarda un nuevo usuario
            try
            {

                usuario = new Usuario();
                usuario.Opc = 1;
                usuario.User = this.txtUsuario.Text;
                usuario.Nombre = this.txtNombre.Text;
                usuario.Puesto = this.txtPuesto.Text;
                usuario.Contraseña = Encriptar(); // se encripta la clave
                usuario.Estado = int.Parse(this.cmbEstado.SelectedIndex.ToString());
               // usuario.Id = 0;
                usuarioH = new UsuarioHelper(usuario);
                usuarioH.Guardar();
               
                MessageBox.Show("Se ha almacenado un nuevo Usuario");
                cargarDatosDtg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //aqui encripto la contraseña
        public string Encriptar()
        {
            
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(this.txtContraeña.Text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
