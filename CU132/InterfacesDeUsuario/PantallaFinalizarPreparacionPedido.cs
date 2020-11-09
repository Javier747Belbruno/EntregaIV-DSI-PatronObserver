using CU132.Gestores;
using CU132.InterfacesDeUsuario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CU132
{
    public partial class PantallaFinalizarPreparacionPedido : Form
    {
        
        public PantallaFinalizarPreparacionPedido()
        {
            InitializeComponent();
            AcomodarPantallaYSusElementos();

            //Inicio de los observadores.
            InterfazMonitor interfazMonitor = new InterfazMonitor();
            interfazMonitor.Show(); 

            InterfazDispositivoMovil interfazDispositivoMovil = new InterfazDispositivoMovil();
            interfazDispositivoMovil.Show();

        }

        private void AcomodarPantallaYSusElementos()
        {
            //Posicion
            this.StartPosition = 0;
            this.Left = 0;
            this.Top = 40;

            dataGridView1.Visible = false;
            btnSeleccionarDetallesPedidos.Visible = false;
            dataGridView1.Columns[5].Visible = false;
            lblResultado.Visible = false;
            lblCargando.Visible = false;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        

        private void btn_FinalizarPrepPedido_Click(object sender, EventArgs e)
        {
            btn_FinalizarPrepPedido.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.AllowUserToAddRows = false;
            btnSeleccionarDetallesPedidos.Visible = true;
            btnSeleccionarDetallesPedidos.Enabled = false;
            lblCargando.Visible = true;
            dataGridView1.Enabled = false;

            tomarOpcionFinalizarPedido();

        }

        private void tomarOpcionFinalizarPedido(){
            abrirVentana();
        }

        private void abrirVentana(){
            GestorFinalizarPreparacionPedido.GetInstance().FinalizarPedido();
        }


        public void mostrarDatosDetallePedidoEnPreparacion(DateTime hora, int numeroMesa, string nombre, int cantidad, int id_detallePedidoEnPrepa)
        {
            lblCargando.Visible = false;
            btnSeleccionarDetallesPedidos.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Add(hora, numeroMesa, nombre, cantidad,false, id_detallePedidoEnPrepa);
        }

        public void informarPantallaDatosNoEncontrados()
        {
            lblCargando.Text = "No existen detalles de pedidos en preparación";
        }

        private void btnSeleccionarDetallesPedidos_Click(object sender, EventArgs e)
        {
            int filasSeleccionadas = 0;
            List<int> id_detalles_Seleccionados = new List<int>();
           
            foreach (DataGridViewRow row in dataGridView1.Rows){
                
                bool rowSelected = (bool)row.Cells[4].Value;

                if (rowSelected) {
                    filasSeleccionadas++;
                    id_detalles_Seleccionados.Add((int)row.Cells[5].Value);
                 }
            }
            if (filasSeleccionadas!=0)
            {
                var confirmResult = MessageBox.Show("Se seleccionó " + filasSeleccionadas + " detalle/s de pedido/s , desea continuar?"
                                                        , "Confirmación"
                                                    , MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    tomarConfirmacionElaboracion(id_detalles_Seleccionados);
                }
                
            }
            else {
                var confirmResult = MessageBox.Show("No se ha seleccionado ningún Detalle de Pedido"
                                                    , "Atención"
                                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tomarConfirmacionElaboracion(List<int> id_detalles_Seleccionados)
        {
            GestorFinalizarPreparacionPedido.GetInstance().ConfirmacionElaboracion(id_detalles_Seleccionados);
            this.dataGridView1.Visible = false;
            this.btnSeleccionarDetallesPedidos.Visible = false;
        }

        public void Resultado(String result) {
            lblResultado.Visible = true;
            lblResultado.Text = result;
        }

    }
}
