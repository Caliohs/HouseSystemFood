using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Reportes
    {
        private int opc;
        private int moneda;
        private DateTime fechaInicial;
        private DateTime fechaFinal;

        public Reportes(int opc,int moneda, DateTime fechaInicial, DateTime fechaFinal)
        {
            this.opc = opc;
            this.moneda = moneda;
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
        }

        public Reportes()
        {
            this.opc = 0;
            this.moneda = 0;
            this.fechaInicial = DateTime.Today; ;
            this.fechaFinal = DateTime.Today ;
        }

        public int Opc { get => opc; set => opc = value; }
        public DateTime FechaInicial { get => fechaInicial; set => fechaInicial = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int Moneda { get => moneda; set => moneda = value; }
    }
}
