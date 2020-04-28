using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string pass;
        private Puesto puesto;

        Usuario()
        {
            this.nombreUsuario = "admin";
            this.pass = "admin";
        }

        public Usuario(string nombre,string apellido,Puesto puesto):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.puesto = puesto;
            
        }

        public Usuario(string nombre,string apellido,Puesto puesto,string nombreUsuario, string pass):this(nombre,apellido,puesto)
        {
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;
            this.puesto = puesto;
        }

        public string NomUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }

        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public Puesto PustoUsuario
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }

        public enum Puesto
        {

            Cocina,
            Delivery,
            AtencionPublico
        }
    }
}
