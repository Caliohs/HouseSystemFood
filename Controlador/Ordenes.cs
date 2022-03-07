using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Ordenes
    {
        private int id;
        private int num_Orden;
        private int idProducto;       
        private int cantidad;
        private int total;
        private int num_Mesa;
        private int opc;

        public Ordenes(int id, int num_Orden, int idProducto, int cantidad, int total, int num_Mesa, int opc)
        {
            this.id = id;
            this.num_Orden = num_Orden;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.total = total;
            this.num_Mesa = num_Mesa;
            this.opc = opc;
        }

        public Ordenes()
        {
            this.id = 0;
            this.num_Orden = 0;
            this.idProducto = 0;
            this.cantidad = 0;
            this.total = 0;
            this.num_Mesa = 0;
            this.opc = 0;
        }

        public int Id { get => id; set => id = value; }
        public int Num_Orden { get => num_Orden; set => num_Orden = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total { get => total; set => total = value; }
        public int Num_Mesa { get => num_Mesa; set => num_Mesa = value; }
        public int Opc { get => opc; set => opc = value; }

        


    }
}
