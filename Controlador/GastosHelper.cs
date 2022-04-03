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
    public class GastosHelper
    {
        Datos cnGeneral = null;
        Gastos obj = null;
        DataTable tblDatos = null;

        public GastosHelper(Gastos parObj)
        {
            obj = parObj;
        }
                    
        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[6];          
               
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Tipo";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Tipo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Justificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 100;
                parParameter[1].SqlValue = obj.Justificacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Moneda";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 10;
                parParameter[2].SqlValue = obj.Moneda;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Monto";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Monto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Fecha";
                parParameter[4].SqlDbType = SqlDbType.Date;
                parParameter[4].SqlValue = obj.Fecha;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Opc";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = obj.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPGastos");

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
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPGastos");

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
                parParameter[1].ParameterName = "@Justificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].SqlValue = obj.Justificacion;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPGastos");

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

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Tipo";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Tipo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Justificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Justificacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Moneda";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 10;
                parParameter[2].SqlValue = obj.Moneda;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Monto";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Monto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Fecha";
                parParameter[4].SqlDbType = SqlDbType.DateTime;
                parParameter[4].SqlValue = obj.Fecha;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Opc";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = obj.Opc;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@Id";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = obj.Id;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPGastos");

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


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPGastos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

       
    }

}
