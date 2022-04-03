using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Gastos
    {
        private string tipo;
        private string justificacion;
        private string moneda;
        private int monto;
        private DateTime fecha;
        private int id;
        private int opc;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Justificacion { get => justificacion; set => justificacion = value; }
        public int Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }
        public int Opc { get => opc; set => opc = value; }
        public string Moneda { get => moneda; set => moneda = value; }

        public Gastos(string tipo, string justificacion, string moneda, int monto, DateTime fecha, int id, int opc)
        {
            this.Tipo = tipo;
            this.Justificacion = justificacion;
            this.Moneda = moneda;
            this.Monto = monto;
            this.Fecha = fecha;
            this.Id = id;
            this.Opc = opc;
        }

        public Gastos()
        {
            this.Tipo = "";
            this.Justificacion = "";
            this.Moneda = "";
            this.Monto = 0;
            this.Fecha = DateTime.Today;
            this.Id = 0;
            this.Opc = 0;
        }
    }
}
