using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Permisos
    {
          
        private string nombre;
        private int estado;
        private int opc;
        private int id;
        
        public Permisos( string nombre,  int estado, int opc, int id )
        {
           
            this.nombre = nombre;         
            this.estado = estado;
            this.opc = opc;
            this.id = id;
        }
        public Permisos()
        {
           
            this.nombre = "";    
            this.estado = 1;
            this.opc = 0;
            this.id = 0;

            Roles Roles = new Roles();
            Menus Menus = new Menus();
        }

        public int? Rolid { get; set; }
        public virtual Roles Roles { get; set; }

        public int? Menuid { get; set; }
        public virtual Menus Menus { get; set; }

        public string Nombre { get => nombre; set => nombre = value; }    
        public int Estado { get => estado; set => estado = value; }
        public int Opc { get => opc; set => opc = value; }
        public int Id { get => id; set => id = value; }
    }
}
