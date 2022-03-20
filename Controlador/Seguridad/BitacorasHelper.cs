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
    public class BitacorasHelper
    {
        Datos cnGeneral = null;
        Bitacoras obj = null;
        DataTable tblDatos = null;

        public BitacorasHelper(Bitacoras parObj)
        {
            obj = parObj;
        }
                   
        public DataTable InsertarEnBitacora()
        {
            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@UserId";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.IdUser;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Accion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Accion;
              
                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Tabla";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = obj.Tabla;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Opc";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Opc;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Fecha";
                parParameter[4].SqlDbType = SqlDbType.Date;
                parParameter[4].SqlValue = obj.Fecha;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBitacoras");
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

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Tabla";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Tabla;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBitacoras");

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

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@UserId";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.IdUser;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Accion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].SqlValue = obj.Accion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Tabla";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].SqlValue = obj.Tabla;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Fecha";
                parParameter[4].SqlDbType = SqlDbType.Date;
                parParameter[4].SqlValue = obj.Fecha;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBitacoras");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    
    }

}
