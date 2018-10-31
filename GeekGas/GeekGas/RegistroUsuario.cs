using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDatos;

namespace GeekGas
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Nombre = txtNombre.Text;
            u.Cuenta = txtCuenta.Text;
            u.Contrasena = txtPassword.Text;
            u.Domicilio = txtDomicilio.Text;
            u.Rfc = txtRFC.Text;
            u.AgregarUsuario(u);
        }
    }
}
