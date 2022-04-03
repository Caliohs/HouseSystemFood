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
   
    public class CierresHelper
    {
        Datos cnGeneral = null;
        Cierres obj = null;
        DataTable tblDatos = null;

        public CierresHelper(Cierres parObj)
        {
            obj = parObj;
        }
              
        
        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[12];          
                          
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@InicialColon";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.InicialColon;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@InicialDolar";
                parParameter[1].SqlDbType = SqlDbType.Float;
                parParameter[1].SqlValue = obj.InicialDolar;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@FinalColon";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.FinalColon;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@FinalDolar";
                parParameter[3].SqlDbType = SqlDbType.Float;
                parParameter[3].SqlValue = obj.FinalDolar;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@VentasColon";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = obj.VentasColon;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@VentasDolar";
                parParameter[5].SqlDbType = SqlDbType.Float;
                parParameter[5].SqlValue = obj.VentasDolar;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@RetiroColon";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = obj.RetiroColon;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@RetiroDolar";
                parParameter[7].SqlDbType = SqlDbType.Float;
                parParameter[7].SqlValue = obj.RetiroDolar;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@DiferenciasColon";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = obj.DiferenciasColon;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@DiferenciasDolar";
                parParameter[9].SqlDbType = SqlDbType.Float;
                parParameter[9].SqlValue = obj.DiferenciasDolar;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@FechaCierre";
                parParameter[10].SqlDbType = SqlDbType.Date;
                parParameter[10].SqlValue = obj.FechaCierre;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@Opc";
                parParameter[11].SqlDbType = SqlDbType.Int;
                parParameter[11].SqlValue = obj.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCierres");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable CargarMontosIniciales()
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

            
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCierres");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable ActualizaMontosIniciales()
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
                parParameter[1].ParameterName = "@InicialColon"; // se usa como parametro ppara cambiar montos
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.InicialColon;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Id"; 
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCierres");

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
                parParameter[0].ParameterName = "@Opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@FechaCierre";
                parParameter[1].SqlDbType = SqlDbType.Date;
                parParameter[1].SqlValue = obj.FechaCierre;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCierres");

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

         

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCierres");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }



        //public DataTable Eliminar()
        //{

        //    tblDatos = new DataTable();

        //    try
        //    {
        //        cnGeneral = new Datos();

        //        SqlParameter[] parParameter = new SqlParameter[2];

        //        parParameter[0] = new SqlParameter();
        //        parParameter[0].ParameterName = "@Opc";
        //        parParameter[0].SqlDbType = SqlDbType.Int;
        //        parParameter[0].SqlValue = obj.Opc;

        //        parParameter[1] = new SqlParameter();
        //        parParameter[1].ParameterName = "@Num_Orden";
        //        parParameter[1].SqlDbType = SqlDbType.Int;
        //        parParameter[1].SqlValue = obj.Num_Orden;


        //        tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //    return tblDatos;
        //}

    }

}
