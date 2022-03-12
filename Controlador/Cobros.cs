using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Cobros
    {
        private int id;
        private int num_Orden;
        private int subtotal;
        private int descuento;       
        private float iva;
        private int total;
        private string metodoPago;
        private DateTime fechaVenta;
        private int usuarioId;
        private int opc;

        public int Id { get => id; set => id = value; }
        public int Num_Orden { get => num_Orden; set => num_Orden = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public float Iva { get => iva; set => iva = value; }
        public int Total { get => total; set => total = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public int Opc { get => opc; set => opc = value; }

        public Cobros(int id, int num_Orden, int subtotal, int descuento, float iva, int total, string metodoPago, DateTime fechaVenta, int usuarioId, int opc)
        {
            this.Id = id;
            this.Num_Orden = num_Orden;
            this.Subtotal = subtotal;
            this.Descuento = descuento;
            this.Iva = iva;
            this.Total = total;
            this.MetodoPago = metodoPago;
            this.FechaVenta = fechaVenta;
            this.UsuarioId = usuarioId;
            this.Opc = opc;
        }
        public Cobros()
        {
            this.Id = 0;
            this.Num_Orden = 0;
            this.Subtotal = 0;
            this.Descuento = 0;
            this.Iva = 0;
            this.Total = 0;
            this.MetodoPago = "";
            this.FechaVenta = DateTime.Now;
            this.UsuarioId = 0;
            this.Opc = 0;
        }

    }
}
