
using CU132.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CU132.Gestores
{
    class GestorFinalizarPreparacionPedido
    {
        //Gestor Como Singleton.
        private GestorFinalizarPreparacionPedido() { }
        private static GestorFinalizarPreparacionPedido _instance;
        public static GestorFinalizarPreparacionPedido GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GestorFinalizarPreparacionPedido();
            }
            return _instance;
        }

        
        public void FinalizarPedido()
        {
            BuscarDetallesEnPreparacion();
        }

        public void BuscarDetallesEnPreparacion()
        {
            Estado enPreparacion = null;
            List<DetallePedido> detallePedidosEnPreparacion = new List<DetallePedido>();

            using (var contextDB = new EntitiesDataBase())
            {
                List<Estado> estadosDetallePedido = new List<Estado>();

                var Estados = contextDB.Estado.ToList();
                

                foreach (var estado in Estados)
                    if (estado.EsAmbitoDetallePedido())
                        estadosDetallePedido.Add(estado);

                if (estadosDetallePedido.Count != 0){
                    foreach (var estado in estadosDetallePedido)
                        if (estado.EsEnPreparacion())
                            enPreparacion = estado;
                }
                else { var error = "Error No existe Estado. Ver como tirar el error."; }

            }
            using (var contextDB = new EntitiesDataBase())
            {
                if (enPreparacion != null) {
               
                    var detallePedidos = contextDB.DetallePedidos.ToList();
                    foreach (var detallePedido in detallePedidos)
                        if (detallePedido.EstaEnPreparacion(enPreparacion))
                            detallePedidosEnPreparacion.Add(detallePedido);
                
                }

            detallePedidosEnPreparacion = ordenarSegunMayorTiempoDeEspera(detallePedidosEnPreparacion);

            //LOOP DETALLES PEDIDO EN PREPARACION

            

            foreach (var detallePedidoEnPrepa in detallePedidosEnPreparacion){
                var hora = detallePedidoEnPrepa.HistorialEstado.fechaHoraInicio.Value;
                buscarInfoDetallePedido(detallePedidoEnPrepa,hora);
            }
            }


        }

        public void buscarInfoDetallePedido(DetallePedido detallePedidoEnPrepa, DateTime hora)
        {
            var nombre="";
            var cantidad=0;
            var numeroMesa=0;


            nombre = detallePedidoEnPrepa.ProductoDeCarta.Producto.nombre;
            if (nombre == null)
                nombre = detallePedidoEnPrepa.Menu.nombre;

            cantidad = detallePedidoEnPrepa.cantidad;

            numeroMesa = buscarMesaDelDetalleEnPreparacion(detallePedidoEnPrepa);

            //get Pantalla.
            PantallaFinalizarPreparacionPedido lastOpenedForm = Application.OpenForms.Cast<PantallaFinalizarPreparacionPedido>().Last();
            lastOpenedForm.mostrarDatosDetallePedidoEnPreparacion(hora, numeroMesa, nombre,cantidad);
            
        }

        private int buscarMesaDelDetalleEnPreparacion(DetallePedido detallePedidoEnPrepa)
        {
            int numeroMesa = detallePedidoEnPrepa.Pedidos.Mesa.numero;
            return numeroMesa;
        }

        public List<DetallePedido> ordenarSegunMayorTiempoDeEspera(List<DetallePedido> listaDetallePedido)
        {
            listaDetallePedido.Sort();
            return listaDetallePedido;
        }

        
    }
}
