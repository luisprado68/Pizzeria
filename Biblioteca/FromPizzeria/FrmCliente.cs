using System;
using System.Windows.Forms;
using Biblioteca;

namespace FromPizzeria
{
    public partial class FrmCliente : Form
    {

        public Cliente cliente;

        // constructor de form cliente que setea el cliente;
        public FrmCliente()
        {
            InitializeComponent();

        }
        // este construtor guarda la lista de clientes recibida por el menu
        public FrmCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }



        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(this.textNombre.Text, this.textApellido.Text, this.textDireccion.Text);

            this.DialogResult = DialogResult.OK;
            //clientes.Add(new Cliente("Martin", "Prado", "Pringles 2925"));

            //MessageBox.Show(this.clientes[0].Mostrar());
            //listClientes.Items.Add(clientes[0].Mostrar());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
