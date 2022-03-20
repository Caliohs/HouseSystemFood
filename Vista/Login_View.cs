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
        private Bitacoras bitacoras;
        private BitacorasHelper bitacorasH;

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
                        user.Id = int.Parse(fila["UsuariosId"].ToString());
                        MessageBox.Show("Bienvenid@ " + user.Nombre.ToString(), "¡Hola!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //registro en bitacora
                        RegistarEnBitacora();
                        Principal inicio = new Principal(user);
                        inicio.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Datos de inicio de sesion incorrectos","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Debe completar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
        //registro el evento
        public void RegistarEnBitacora()
        {
            try
            {
                bitacoras = new Bitacoras();
                //registro el evento
                bitacoras.Opc = 2;
                bitacoras.IdUser = user.Id;
                bitacoras.Accion = "LOGIN";
                bitacoras.Fecha = DateTime.Now;
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

