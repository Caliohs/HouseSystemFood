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
        private int rolId;
        private string contraseña;
        private int estado;
        private int opc;
        private int id;



        public Usuario(string user, string nombre, int rolId, string contraseña, int estado, int opc, int id )
        {
            this.user = user;
            this.nombre = nombre;
            this.rolId = rolId;
            this.contraseña = contraseña;
            this.estado = estado;
            this.opc = opc;
            this.id = id;
        }
        public Usuario()
        {
            this.user = "";
            this.nombre = "";
            this.rolId = 0;
            this.contraseña = "";
            this.estado = 1;
            this.opc = 0;
            this.id = 0;
        }

        public string User { get => user; set => user = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int RolId { get => rolId; set => rolId = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Opc { get => opc; set => opc = value; }
        public int Id { get => id; set => id = value; }
    }
}
