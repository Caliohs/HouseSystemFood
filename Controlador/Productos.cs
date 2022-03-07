using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Productos
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int precio;
        private int stock;
        private int idCat;
        private int estado;
        private int opc;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdCat { get => idCat; set => idCat = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Opc { get => opc; set => opc = value; }

        public Productos(int id, string nombre, string descripcion, int precio, int stock, int idCat, int estado, int opc)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
            this.IdCat = idCat;
            this.Estado = estado;
            this.Opc = opc;
        }

        public Productos()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Descripcion = "";
            this.Precio = 0;
            this.Stock = 0;
            this.IdCat = 0;
            this.Estado = 0;
            this.Opc = 0;
        }


    }
}
