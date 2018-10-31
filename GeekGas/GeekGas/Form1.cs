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
    public partial class Form1 : Form
    {
        
        Usuario u = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtCuenta.Text.Equals("admin") && txtContrasena.Text.Equals("123456"))
            {
                VistaAdmin va = new VistaAdmin();
                va.Show();
                this.Hide();
            }
            else 
            { 
                if (u.Login(txtCuenta.Text, txtContrasena.Text).Id > 0) 
                {
                    VistaUsuario vu = new VistaUsuario(u.Login(txtCuenta.Text, txtContrasena.Text));
                    vu.Show();
                    this.Hide();
                
                }
            }

        }

        
    }
}
