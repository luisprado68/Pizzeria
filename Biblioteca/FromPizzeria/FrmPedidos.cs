using System;
using System.Windows.Forms;
using Biblioteca;

namespace FromPizzeria
{
    public partial class FrmPedidos : Form
    {
        public Pedido pedido;
        public Cliente cliente;
        public Pizza pizza;
        public Pizza aux;

        private int cantidad;
        private int cantidadPedido;
        private bool nuevaPizza;
        public FrmPedidos()
        {
            InitializeComponent();
            cantidad = 0;
            cantidadPedido = 0;
            nuevaPizza = false;
        }

        public FrmPedidos(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarPizza_Click(object sender, EventArgs e)
        {

            cantidadPedido = cantidad + cantidadPedido;

            pizza = new Pizza(decimal.Parse(this.textCantidad.Text), this.cmbGusto.Text, this.cmbCoccion.Text);
            //agrega la cantidad de objetos de piza solo hasta 8 el tamaño de array de objeto pizza

            if (cantidadPedido <= 8)
            {
                if (nuevaPizza)
                {
                    //si se ingresa mas pizzas si son iguales se suman la cantidad
                    if (pizza + aux)
                    {// borra la primera agregada
                        listPizza.Items.Clear();
                        listPizza.Items.Add(pizza.Mostrar());
                    }
                    else
                    {
                        listPizza.Items.Add(pizza.Mostrar());
                    }
                }

                if (!nuevaPizza)
                {
                    //agrego un ob pizza una vez
                    listPizza.Items.Add(pizza.Mostrar());
                    aux = pizza;
                    nuevaPizza = true;
                }


            }
            else
            {
                MessageBox.Show("Supero la cantidad de pizzas solo 8 por pedido!");
                // restamos la cantidad sumada que excedio para no acumular.
                cantidadPedido = cantidadPedido - cantidad;
            }
        }
        private void btnCargarPedido_Click(object sender, EventArgs e)
        {
            pedido = new Pedido(cliente, this.checkDomicilio.Checked);

            if (pedido + pizza)
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            cantidad++;

            if (cantidad <= 8)
            {
                textCantidad.Text = cantidad.ToString();
            }
            else
            {
                cantidad = 8;
                textCantidad.Text = cantidad.ToString();
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            cantidad--;

            if (cantidad >= 1)
            {
                textCantidad.Text = cantidad.ToString();
            }
            else
            {
                cantidad = 1;
                textCantidad.Text = cantidad.ToString();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarPizza_Click(object sender, EventArgs e)
        {

        }
    }

}
