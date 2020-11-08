﻿using CU132.Gestores;
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
            dataGridView1.Visible = false;
            btnSeleccionarDetallesPedidos.Visible = false;
        }
        

        private void btn_FinalizarPrepPedido_Click(object sender, EventArgs e)
        {
            btn_FinalizarPrepPedido.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.AllowUserToAddRows = false;
            btnSeleccionarDetallesPedidos.Visible = true;

            tomarOpcionFinalizarPedido();

        }

        private void tomarOpcionFinalizarPedido(){
            abrirVentana();
        }

        private void abrirVentana()
        {
            GestorFinalizarPreparacionPedido.GetInstance().FinalizarPedido();
            
        }


        public void mostrarDatosDetallePedidoEnPreparacion(DateTime hora, int numeroMesa, string nombre, int cantidad, int id_detallePedidoEnPrepa)
        {
            dataGridView1.Rows.Add(hora, numeroMesa, nombre, cantidad,false, id_detallePedidoEnPrepa);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnSeleccionarDetallesPedidos_Click(object sender, EventArgs e)
        {
            int filasSeleccionadas = 0;
            List<int> id_detalles_Seleccionados = new List<int>();
            dataGridView1.Columns[5].Visible = true;
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
            var a = id_detalles_Seleccionados;
            GestorFinalizarPreparacionPedido.GetInstance().ConfirmacionElaboracion(id_detalles_Seleccionados);
        }
    }
}
