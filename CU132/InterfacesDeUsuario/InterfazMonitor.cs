using CU132.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CU132.InterfacesDeUsuario
{
    public partial class InterfazMonitor : Form, IObservadorDetallePedido
    {
        public InterfazMonitor()
        {
            InitializeComponent();
            AcomodarPantalla();
        }

        public void AcomodarPantalla()
        {
            this.StartPosition = 0;
            this.Left = 0;
            this.Top = 490;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }


        public void Visualizar(Dictionary<int, int> mapMesaCantidadProd, int sumaTotalProductos)
        {
            foreach (KeyValuePair<int, int> kvp in mapMesaCantidadProd)
                dataGridView1.Rows.Add(kvp.Key, kvp.Value);
        }
    }
}
