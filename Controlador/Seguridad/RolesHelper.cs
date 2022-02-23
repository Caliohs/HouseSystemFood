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
    public class RolesHelper
    {
        Datos cnGeneral = null;
        Roles obj = null;
        DataTable tblDatos = null;

        public RolesHelper(Roles parObj)
        {
            obj = parObj;
        }
              
        
        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];          
               
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Nombre";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Nombre;
              
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Estado";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Estado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Opc";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Opc;

            

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

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
                parParameter[0].SqlValue = obj.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Buscar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = obj.Nombre;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Actualizar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = obj.Nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Estado";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Estado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Id";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Eliminar()
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
                parParameter[1].ParameterName = "@Id";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Id;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRoles");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }

}
