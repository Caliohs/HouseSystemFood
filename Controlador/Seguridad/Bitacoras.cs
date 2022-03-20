using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Bitacoras
    {

        private int idUser;
        private string accion;
        private string tabla;
        private DateTime fecha;
        private int opc;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Accion { get => accion; set => accion = value; }
        public string Tabla { get => tabla; set => tabla = value; }
        public int Opc { get => opc; set => opc = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Bitacoras(int idUser, string accion, string tabla, DateTime fecha,  int opc)
        {
            this.IdUser = idUser;
            this.Accion = accion;
            this.Tabla = tabla;
            this.Fecha = fecha;
            this.Opc = opc;
        }
        public Bitacoras()
        {
            this.IdUser = 0;
            this.Accion = "";
            this.Tabla = "";
            this.Fecha = DateTime.Today;
            this.Opc = 0;
        }
    }
}
