using System;
using System.Windows.Forms;
using Biblioteca;

namespace FromPizzeria
{
    public partial class Login : Form
    {
        private Usuario usuario;
        public Login()
        {
            InitializeComponent();
            //textPass.PasswordChar = '*';
            //textPass.MaxLength = 10;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Login_Load(object sender, EventArgs e)
        {
            usuario = new Usuario("Luis", "Prado", Usuario.Puesto.AtencionPublico);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == usuario.NomUsuario && textPass.Text == usuario.Pass)
            {
                MessageBox.Show("Bienvenido " + usuario.Nombre);
                this.Hide();

                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos ");
            }
        }
    }
}
