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
    public class ReportesHelper
    {
        Datos cnGeneral = null;
        Reportes obj = null;
        DataTable tblDatos = null;

        public ReportesHelper(Reportes parObj)
        {
            obj = parObj;
        }
                    
        public DataTable Buscar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@FechaInicial";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = obj.FechaInicial;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@FechaFinal";
                parParameter[2].SqlDbType = SqlDbType.DateTime;
                parParameter[2].SqlValue = obj.FechaFinal;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Moneda";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Moneda;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPReportes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable calcularAcumulado(int tipo)
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = 4;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@FechaInicial";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = obj.FechaInicial;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@FechaFinal";
                parParameter[2].SqlDbType = SqlDbType.DateTime;
                parParameter[2].SqlValue = obj.FechaFinal;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Moneda";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Moneda;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Tipo";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = tipo;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPReportes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
       
    }

}
