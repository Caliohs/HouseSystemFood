using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseSystemFood.Modelo;

namespace HouseSystemFood.Controlador
{
    public class UsuarioHelper
    {
        Datos cnGeneral = null;
        Usuario objUsuario = null;
        DataTable tblDatos = null;

        public UsuarioHelper(Usuario parObjUsuario)
        {
            objUsuario = parObjUsuario;
        }
              
        public DataTable validarLogin()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];
        //        private string user;
        //private string nombre;
        //private string puesto;
        //private string contraeña;
        //private int estado;

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Usuario";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = objUsuario.User;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Puesto";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objUsuario.Puesto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Contraseña";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objUsuario.Contraseña;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Estado";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuario.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Opc";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objUsuario.Opc;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@Id";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = objUsuario.Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[6];          
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Usuario";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = objUsuario.User;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Puesto";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objUsuario.Puesto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Contrasena";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objUsuario.Contraseña;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Estado";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objUsuario.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Opc";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objUsuario.Opc;

            

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Listar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuario.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SpUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }

}
