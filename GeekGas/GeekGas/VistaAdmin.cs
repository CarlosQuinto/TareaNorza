using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeekGas
{
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.ShowDialog();
        }

        private void btnGenerarFacturas_Click(object sender, EventArgs e)
        {
            BusquedaUsuarios bu = new BusquedaUsuarios();
            bu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
