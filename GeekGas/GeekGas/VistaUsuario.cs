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
    public partial class VistaUsuario : Form
    {
        Usuario u;
        public VistaUsuario()
        {
            InitializeComponent();
        }

        public VistaUsuario(Usuario u)
        {
            this.u = u;
            InitializeComponent();
        }


        private void VistaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
