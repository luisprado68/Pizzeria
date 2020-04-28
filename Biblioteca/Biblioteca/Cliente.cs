using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
     
        private string domicilio;

        private Cliente()
        {
            this.domicilio = "Sin Domicilio";
        }

        public Cliente(string domicilio):this()
        {
            this.domicilio = domicilio;
        }

        public Cliente(string domicilio,string nombre,string apellido) : this(domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public  string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("{0} - {1} - {2}", Nombre,Apellido, this.domicilio);

            return datos.ToString();
        }
    }

}
