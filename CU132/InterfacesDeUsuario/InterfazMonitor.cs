using CU132.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CU132.InterfacesDeUsuario
{
    public partial class InterfazMonitor : Form, IObservadorDetallePedido
    {
        public InterfazMonitor()
        {
            InitializeComponent();
            //Posiciones
            this.StartPosition = 0;
            this.Left = 0;
            this.Top = 490;

        }


        public void Visualizar(int sumaProductos)
        {
            dataGridView1.Rows.Add("Todas las Mesas", sumaProductos);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
