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
    public partial class ElegirConsumo : Form
    {
        List<Consumo> consumos;
        Consumo c;
        public ElegirConsumo()
        {
            InitializeComponent();
        }

        public ElegirConsumo(List<Consumo> consumos)
        {
            this.consumos = consumos;
            InitializeComponent();
            ElegirConsumo_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElegirConsumo_Load()
        {
            dataGridView1.Columns["ID"].Width = 104;
            dataGridView1.Columns["FECHA"].Width = 104;
            dataGridView1.Columns["CANTIDAD"].Width = 103;
            dataGridView1.Columns["TOTAL"].Width = 103;
            dataGridView1.Rows.Clear();
            cargarTodos();
        }

        private void cargarTodos()
        {
            foreach (Consumo cuenta in consumos)
            {
                dataGridView2.Rows.Add(cuenta.Id, cuenta.Fecha.ToString(), cuenta.Cantidad.ToString(), cuenta.Costototal.ToString());
            }
        }


    }
}
