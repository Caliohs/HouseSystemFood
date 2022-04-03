using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Cierres
    {
        private int id;
        private int inicialColon;
        private float inicialDolar;
        private int finalColon;
        private float finalDolar;
        private int ventasColon;
        private float ventasDolar;
        private int retiroColon;
        private float retiroDolar;
        private int diferenciasColon;
        private float diferenciasDolar;
        private DateTime fechaCierre;
        private int opc;

        public int Id { get => id; set => id = value; }
        public int InicialColon { get => inicialColon; set => inicialColon = value; }
        public float InicialDolar { get => inicialDolar; set => inicialDolar = value; }
        public int FinalColon { get => finalColon; set => finalColon = value; }
        public float FinalDolar { get => finalDolar; set => finalDolar = value; }
        public int VentasColon { get => ventasColon; set => ventasColon = value; }
        public float VentasDolar { get => ventasDolar; set => ventasDolar = value; }
        public int RetiroColon { get => retiroColon; set => retiroColon = value; }
        public float RetiroDolar { get => retiroDolar; set => retiroDolar = value; }
        public int DiferenciasColon { get => diferenciasColon; set => diferenciasColon = value; }
        public float DiferenciasDolar { get => diferenciasDolar; set => diferenciasDolar = value; }
        public DateTime FechaCierre { get => fechaCierre; set => fechaCierre = value; }
        public int Opc { get => opc; set => opc = value; }

        public Cierres(int id, int inicialColon, float inicialDolar, int finalColon, float finalDolar, int ventasColon, float ventasDolar, int retiroColon, float retiroDolar, int diferenciasColon, float diferenciasDolar, DateTime fechaCierre, int opc)
        {
            this.Id = id;
            this.InicialColon = inicialColon;
            this.InicialDolar = inicialDolar;
            this.FinalColon = finalColon;
            this.FinalDolar = finalDolar;
            this.VentasColon = ventasColon;
            this.VentasDolar = ventasDolar;
            this.RetiroColon = retiroColon;
            this.RetiroDolar = retiroDolar;
            this.DiferenciasColon = diferenciasColon;
            this.DiferenciasDolar = diferenciasDolar;
            this.FechaCierre = fechaCierre;
            this.Opc = opc;
        }
        public Cierres()
        {
            this.Id = 0;
            this.InicialColon = 0;
            this.InicialDolar = 0;
            this.FinalColon = 0;
            this.FinalDolar = 0;
            this.VentasColon = 0;
            this.VentasDolar = 0;
            this.RetiroColon = 0;
            this.RetiroDolar = 0;
            this.DiferenciasColon = 0;
            this.DiferenciasDolar = 0;
            this.FechaCierre = DateTime.Today;
            this.Opc = 0;
        }
    }
}
