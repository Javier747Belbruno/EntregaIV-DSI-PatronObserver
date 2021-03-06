
namespace CU132.Entidades
{
    using System;
    using System.Linq;

    public partial class DetallePedido : IComparable
    {
        public int nroDetallePedido { get; set; }
        public string detDetallePedido { get; set; }
        public int cantidad { get; set; }
        public Nullable<System.DateTime> hora { get; set; }
        public Nullable<int> tiempo { get; set; }
        public int nroPedido { get; set; }
        public int historialEstado { get; set; }
        public Nullable<int> menu { get; set; }
        public Nullable<int> productoDeCarta { get; set; }
    
        public virtual HistorialEstado HistorialEstado { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ProductoDeCarta ProductoDeCarta { get; set; }
        public virtual Pedido Pedidos { get; set; }

        public bool EstaEnPreparacion(Estado enPreparacion) {
            var historialEstadoUltimo = obtenerUltimoEstado();
            if (historialEstadoUltimo.Estado.Equals(enPreparacion) && historialEstadoUltimo.fechaHoraFin == null)
                return true;
            return false;
        }

        public bool EstaListoParaServir(Estado listoParaServir)
        {
            var historialEstadoUltimo = obtenerUltimoEstado();
            if (historialEstadoUltimo.Estado.Equals(listoParaServir) && historialEstadoUltimo.fechaHoraFin == null)
                return true;
            return false;
        }

        /* El DetallePedido siempre va a estar ligado al último Historial */
        public HistorialEstado obtenerUltimoEstado() {
            return HistorialEstado;
        }

        public int CompareTo(object objAComparar)
        { 
        if (objAComparar == null) return 1;

        DetallePedido detallePedidoParametro = objAComparar as DetallePedido;
        if (detallePedidoParametro != null)
            return this.HistorialEstado.fechaHoraInicio.Value.CompareTo(detallePedidoParametro.HistorialEstado.fechaHoraInicio.Value);
        else
           throw new ArgumentException("El objeto no es un DetallePedido");
        }

        public void Finalizar(DateTime horaFinalizacion, Estado estado)
        {
            setearFinUltimoHistoria(horaFinalizacion, estado);
        }

        public void setearFinUltimoHistoria(DateTime hora, Estado estado)
        {
            HistorialEstado.setFechaHoraFin(hora);
            CrearHistoria(estado,hora);
        }

        private void CrearHistoria(Estado estado, DateTime hora)
        {
           
            using (var contextDB = new EntitiesDataBase())
            {
                HistorialEstado nuevaHistoriaEstado 
                    = new HistorialEstado { fechaHoraFin = null,
                                            fechaHoraInicio = hora,
                                            estado= estado.id_estado };
                contextDB.HistorialEstado.Add(nuevaHistoriaEstado);
                contextDB.SaveChanges();

                var result = contextDB.DetallePedidos.SingleOrDefault(dp => dp.nroDetallePedido == this.nroDetallePedido);
                if (result != null)
                {
                    result.HistorialEstado = nuevaHistoriaEstado;
                    contextDB.SaveChanges();
                }
            }
        }
    }
}
