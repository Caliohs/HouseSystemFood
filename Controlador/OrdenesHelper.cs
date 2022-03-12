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
   
    public class OrdenesHelper
    {
        Datos cnGeneral = null;
        Ordenes obj = null;
        DataTable tblDatos = null;

        public OrdenesHelper(Ordenes parObj)
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
                parParameter[0].ParameterName = "@Num_Orden";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = obj.Num_Orden;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@IdProducto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.IdProducto;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Cantidad";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Cantidad;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Total";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Total;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Num_Mesa";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = obj.Num_Mesa;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Opc";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = obj.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

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


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

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
                parParameter[1].ParameterName = "@Num_Mesa";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Num_Mesa;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable ListarOrden()
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
                parParameter[1].ParameterName = "@Num_Orden";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Num_Orden;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //no hacer
        //public DataTable Actualizar()
        //{

        //    tblDatos = new DataTable();

        //    try
        //    {
        //        cnGeneral = new Datos();

        //        SqlParameter[] parParameter = new SqlParameter[7];

        //        parParameter[0] = new SqlParameter();
        //        parParameter[0].ParameterName = "@Num_Orden";
        //        parParameter[0].SqlDbType = SqlDbType.Int;
        //        parParameter[0].SqlValue = obj.Num_Orden;

        //        parParameter[1] = new SqlParameter();
        //        parParameter[1].ParameterName = "@IdProducto";
        //        parParameter[1].SqlDbType = SqlDbType.Int;
        //        parParameter[1].SqlValue = obj.IdProducto;

        //        parParameter[2] = new SqlParameter();
        //        parParameter[2].ParameterName = "@Cantidad";
        //        parParameter[2].SqlDbType = SqlDbType.Int;
        //        parParameter[2].SqlValue = obj.Cantidad;

        //        parParameter[3] = new SqlParameter();
        //        parParameter[3].ParameterName = "@Total";
        //        parParameter[3].SqlDbType = SqlDbType.Int;
        //        parParameter[3].SqlValue = obj.Total;

        //        parParameter[4] = new SqlParameter();
        //        parParameter[4].ParameterName = "@Num_Mesa";
        //        parParameter[4].SqlDbType = SqlDbType.Int;
        //        parParameter[4].SqlValue = obj.Num_Mesa;

        //        parParameter[5] = new SqlParameter();
        //        parParameter[5].ParameterName = "@Id";
        //        parParameter[5].SqlDbType = SqlDbType.Int;
        //        parParameter[5].SqlValue = obj.Id;

        //        parParameter[6] = new SqlParameter();
        //        parParameter[6].ParameterName = "@Opc";
        //        parParameter[6].SqlDbType = SqlDbType.Int;
        //        parParameter[6].SqlValue = obj.Opc;


        //        tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");


        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //    return tblDatos;
        //}

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
                parParameter[1].ParameterName = "@Num_Orden";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = obj.Num_Orden;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPOrdenes");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    
    }

}
