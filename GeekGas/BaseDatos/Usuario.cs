using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseDatos
{
    public class Usuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string cuenta;

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private string rfc;

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public Boolean Login(string cuenta, string contraseña) { 
            

            return true;
        }
    }
}
