using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca;

namespace FromPizzeria
{
    public partial class FrmPrincipal : Form
    {
        FrmCliente FrmCli;
        FrmPedidos frmPedidos;
        private Queue<Pedido> pedidos;
        public List<Cliente> clientes;


        public FrmPrincipal()
        {
            InitializeComponent();
            //Aca inicializamos los constructores!!
            pedidos = new Queue<Pedido>();
            clientes = new List<Cliente>();
            clientes.Add(new Cliente("Luis", "Prado", "Juncal 2925"));
            clientes.Add(new Cliente("Martin", "Prado", "Pringles 2925"));
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            AgregarClientes();
            agregarPedido();

        }

        public void AgregarClientes()
        {
            listClientes.Items.Clear();// limpiamos la lista 

            foreach (Cliente item in this.clientes)
            {
                if (clientes.Count != 0)
                {
                    listClientes.Items.Add(item.Mostrar());
                }

            }
        }

        public void agregarPedido()
        {
            listPedidos.Items.Clear();// limpiamos la lista 

            foreach (Pedido item in this.pedidos)
            {
                if (clientes.Count != 0)
                {
                    listPedidos.Items.Add(item.Mostrar());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmCli = new FrmCliente();
            FrmCli.ShowDialog();

            if (FrmCli.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El Cliente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                clientes.Add(FrmCli.cliente);
                AgregarClientes();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Se ejecuta en cierto lapso de tiempo.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listClientes.SelectedIndex.ToString());
            // obtine el indice del cliente y lo paso al formulario pedido

            if (listClientes.SelectedIndex == -1)
            {

                MessageBox.Show("No eligio ningun cliente!");
            }
            else
            {
                frmPedidos = new FrmPedidos(clientes[listClientes.SelectedIndex]);
                frmPedidos.ShowDialog();

                if (frmPedidos.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El Pedido fue agregado satisfactoriamente",
                                                 "Confirmacion",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                    pedidos.Enqueue(frmPedidos.pedido);
                    agregarPedido();
                }
            }

        }
    }
}
