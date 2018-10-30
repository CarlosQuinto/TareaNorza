using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseDatos
{
    class Consumo
    {

        private int id;
        private string rfc;
        private string domicilio;
        private string contrasena;
        private string cuenta;
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

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

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

    }



}
