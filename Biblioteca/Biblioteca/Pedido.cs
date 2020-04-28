using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pedido
    {
        private Cliente cliente;
        private bool envia;
        private DateTime horaIngreso;
        private DateTime horaRetira;
        private Pizza[] pizzas;


         public Pedido(Cliente c)
        {
            this.cliente = c;
            this.pizzas = new Pizza[8];

        }
        public Pedido(Cliente c,bool envia):this(c)
        {
            this.cliente = c;
            this.envia = envia;

        }
        public Pedido(Cliente c, DateTime horaIngreso,DateTime horaRetira):this(c)
        {
            this.horaIngreso = horaIngreso;
            this.horaRetira = horaRetira;
            
        }
        public DateTime GetIngreso()
        {
            return this.horaIngreso;
        }

        public DateTime GetRetiro()
        {
            return this.horaRetira;
        }

        public bool GetEnvia()
        {
            return this.envia;
        }
        
        public int getCantidadPizzas()
        {
           return this.pizzas.Length;
        }

        public static implicit operator Pedido(Cliente c)
        {
            Pedido aux = new Pedido(c);

            return aux;
        }

        public static bool operator +(Pedido pedido, Pizza pizza)
        {//ctrl + k +d
            //Primer buclle va a buscar en el array de pizzas si la pizza existe.

            for (int i = 0; i < pedido.pizzas.Length; i++)
            {
                if(pedido.pizzas[i] + pizza)
                {
                    return true;
                }

            }// si no es igual no la suma por tanto la agrega en el primer lugar libre del array de objetos pizza
            //Agregar la pizza en el lugar libre. sino hay lugar retorna falso.
            for (int i = 0; i < pedido.pizzas.Length; i++)
            {

                if (pedido.pizzas[i] is null)
                {

                    pedido.pizzas[i] = pizza;
                    return true;
                }
            }

            return false;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            string envio = "retira";
            if (this.GetEnvia())
            {
                 envio = "Envio a Domicilio";
            }
            
            datos.AppendFormat("{0} - {1} - {2} - {3}", this.cliente.Nombre, envio, this.GetIngreso(), this.GetRetiro());


            return datos.ToString();
        }


        



    }
}
