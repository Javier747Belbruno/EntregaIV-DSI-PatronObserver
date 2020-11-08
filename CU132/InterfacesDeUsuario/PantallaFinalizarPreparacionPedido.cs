using CU132.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU132
{
    public partial class PantallaFinalizarPreparacionPedido : Form
    {
        
        public PantallaFinalizarPreparacionPedido()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }
        

        private void btn_FinalizarPrepPedido_Click(object sender, EventArgs e)
        {
            btn_FinalizarPrepPedido.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.AllowUserToAddRows = false;
          
            tomarOpcionFinalizarPedido();

        }

        private void tomarOpcionFinalizarPedido(){
            abrirVentana();
        }

        private void abrirVentana()
        {
            GestorFinalizarPreparacionPedido.GetInstance().FinalizarPedido();
            
        }


        public void mostrarDatosDetallePedidoEnPreparacion(DateTime hora, int numeroMesa, string nombre, int cantidad)
        {
            dataGridView1.Rows.Add(hora, numeroMesa, nombre, cantidad);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
