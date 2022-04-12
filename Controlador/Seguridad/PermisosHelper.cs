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
    public class PermisosHelper
    {
        Datos cnGeneral = null;
        Permisos obj = null;
        DataTable tblDatos = null;
       

        public PermisosHelper(Permisos parObj)
        {
            obj = parObj;
        }
              
        
        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Id";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Id;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Nombre;
              
                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Estado";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Estado;
              
                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Opc";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Opc;

                

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Listar(int IdRol)
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@IdRol";
                parParameter[1].SqlDbType = SqlDbType.Int;            
                parParameter[1].SqlValue = IdRol;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Buscar(int Id)
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = obj.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@IdRol";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable ValidarPermisos()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@IdRol";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Rolid;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable ListarPermisos(string nombre)
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = nombre;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }

}
