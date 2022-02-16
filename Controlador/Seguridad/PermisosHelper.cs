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

                SqlParameter[] parParameter = new SqlParameter[3];          
               
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Nombre_del_modulo";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Nombre;
              
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Estado";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Estado;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@RolId";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Rolid;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@MenuId";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Menuid;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Opc";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Opc;

            

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPPermisos");

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
