using HouseSystemFood.Controlador;
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

namespace HouseSystemFood.Vista
{
    public partial class Login : Form
    {
        private Usuario user;
        private UsuarioHelper userH;
        private DataTable datos;

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUsuario.Text != "" && this.txtContraseña.Text != "")
                {

                    user = new Usuario();
                    user.User = this.txtUsuario.Text;
                    user.Contraseña = Encriptar(this.txtContraseña.Text).ToString();
                    user.Opc = 6;
                    userH = new UsuarioHelper(user);
                    datos = userH.validarLogin();

                    if (datos.Rows.Count > 0)
                    {
                        DataRow fila = datos.Rows[0];
                        user.Nombre = fila["Nombre"].ToString();
                        user.RolId = int.Parse(fila["RolId"].ToString());

                        Principal inicio = new Principal(user);
                        //Principal inicio = new Principal();
                        inicio.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Datos de inicio de sesion incorrectos");

                }
                else MessageBox.Show("Debe completar los campos");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

    }
 }

