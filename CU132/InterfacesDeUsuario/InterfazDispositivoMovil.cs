using CU132.Interfaces;
using CU132.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU132.InterfacesDeUsuario
{
    public partial class InterfazDispositivoMovil : Form, IObservadorDetallePedido
    {
        public InterfazDispositivoMovil()
        {
            InitializeComponent();
            this.StartPosition = 0;
            this.Left = 935;
            this.Top = 40;
        }

        public void Visualizar(int sumaProductos)
        {
            lblNumeroPlatos.Text = sumaProductos.ToString();
            pictureBoxBell.Image = Resources.YouTube_Bell_Icon_PNG_Photos;
            dataGridView1.Rows.Add("Todas las Mesas", sumaProductos);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
