using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystemFood.Controlador
{
    public class Categorias
    {
          
        private string nombre;
        private int estado;
        private int opc;
        private int id;
                
        public Categorias( string nombre,  int estado, int opc, int id )
        {
           
            this.nombre = nombre;         
            this.estado = estado;
            this.opc = opc;
            this.id = id;
        }
        public Categorias()
        {
           
            this.nombre = "";    
            this.estado = 1;
            this.opc = 0;
            this.id = 0;
        }

        
        public string Nombre { get => nombre; set => nombre = value; }    
        public int Estado { get => estado; set => estado = value; }
        public int Opc { get => opc; set => opc = value; }
        public int Id { get => id; set => id = value; }
    }
}
