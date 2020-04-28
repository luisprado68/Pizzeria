using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    public class Persona
    {
        private string nombre;
        private string apellido;
       
    

        public Persona()
        {
            this.nombre = "Sin Nombre";
            this.apellido = "Sin Apellido";
            
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, string apellido) : this(nombre)
        {
            this.apellido = apellido;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        
        

       
        

    }
}
