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
   
    public class ProductosHelper
    {
        Datos cnGeneral = null;
        Productos obj = null;
        DataTable tblDatos = null;

        public ProductosHelper(Productos parObj)
        {
            obj = parObj;
        }
              
        
        public DataTable Guardar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];          
               
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Nombre";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Descripcion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Precio";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Precio;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Stock";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Stock;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@IdCat";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = obj.IdCat;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Estado";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = obj.Estado;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@Opc";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = obj.Opc;

            
               

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

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


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

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

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

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

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@Nombre";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 30;
                parParameter[0].SqlValue = obj.Nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = obj.Descripcion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Precio";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = obj.Precio;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Stock";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = obj.Stock;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@IdCat";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = obj.IdCat;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@Estado";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = obj.Estado;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@Opc";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = obj.Opc;


                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@Id";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = obj.Id;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

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


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable ListarDtgProductos(string nombre)
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
                parParameter[1].SqlValue = nombre;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPProductos");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

    }

}
