﻿using System;
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
        double cantidad;
        double costo;

        public VistaUsuario()
        {
            InitializeComponent();
        }

        public VistaUsuario(Usuario u)
        {
            this.u = u;
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + u.Nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text= "1 LT - $12.15";
            b.Width = 190;
            pt.Controls.Add(b);
            cantidad += 1;
            costo += 12.15;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VistaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "45 LT - $1012.50";
            b.Width = 190;
            pt.Controls.Add(b);
            cantidad += 45;
            costo += 1012.50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "10 KG - $225.00";
            b.Width = 190;
            pt.Controls.Add(b);
            cantidad += 10;
            costo += 225.00;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "30 LT - $675.00";
            b.Width = 190;
            pt.Controls.Add(b);
            cantidad += 30;
            costo += 675.00;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pt.Controls.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pt.Controls.Count < 0)
            {

            }
            else
            {
                Consumo c = new Consumo();
                c.Cantidad = cantidad;
                c.Costototal = costo;
                c.Fecha = DateTime.Now;
                c.IdUsuario = u.Id;
                c.CrearTicket(c);
                cantidad = 0;
                costo = 0;
                pt.Controls.Clear();
            }
        }

    }
}
