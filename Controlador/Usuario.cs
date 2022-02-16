using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Usuario
    {
      
       
        private string user;    
        private string nombre;
        private string puesto;
        private string contraseña;
        private int estado;
        private int opc;
        private int id;



        public Usuario(string user, string nombre, string puesto, string contraseña, int estado, int opc, int id )
        {
            this.user = user;
            this.nombre = nombre;
            this.puesto = puesto;
            this.contraseña = contraseña;
            this.estado = estado;
            this.opc = opc;
            this.id = id;
        }
        public Usuario()
        {
            this.user = "";
            this.nombre = "";
            this.puesto = "";
            this.contraseña = "";
            this.estado = 1;
            this.opc = 0;
            this.id = 0;
        }

        public string User { get => user; set => user = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Opc { get => opc; set => opc = value; }
        public int Id { get => id; set => id = value; }
    }
}
