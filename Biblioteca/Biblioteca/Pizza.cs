using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pizza
    {
        private decimal cantidad;
        private string gusto;
        private string tipoCoccion;

        public Pizza(decimal cantidad, string gusto,string tipoCoccion)
        {
            this.tipoCoccion = tipoCoccion;
            this.gusto = gusto;
            this.cantidad = cantidad;

        }

        public decimal getCantidad()
        {
            return this.cantidad;
        }


        public static bool operator ==(Pizza a, Pizza b)
        {
            if(!(a is null))
            {
                return a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion;
            }
            return false;
            // Lo de arriba es lo mismo que lo de abajo.
            //bool flag = a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion;
            //return flag;
        }

        public static bool operator !=(Pizza a, Pizza b)
        {
            return !(a == b);
            // Lo de arriba es lo mismo que lo de abajo.
            //bool flag = !(a == b);
            //return flag;
        }

        public static bool operator +(Pizza a, Pizza b)
        {
            if(a == b)
            {
                a.cantidad += b.cantidad;
                //a.cantidad = a.cantidad + b.cantidad;
                return true;
            }

            return false;

        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("{0} - {1} - {2} ", this.cantidad, this.gusto, this.tipoCoccion);

            return datos.ToString();
        }

    }
}
