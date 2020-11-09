
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HistorialEstado
    {
        public HistorialEstado()
        {
            this.DetallePedidos = new HashSet<DetallePedido>();
            this.Pedidos = new HashSet<Pedido>();
        }

        public int nroHistorialEstado { get; set; }
        public Nullable<System.DateTime> fechaHoraFin { get; set; }
        public Nullable<System.DateTime> fechaHoraInicio { get; set; }
        public int estado { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public void setFechaHoraFin(DateTime horaFinalizacion)
        {
            using (var contextDB = new EntitiesDataBase())
            {
                var result = contextDB.HistorialEstado.SingleOrDefault(h => h.nroHistorialEstado == this.nroHistorialEstado);
                if (result != null)
                {
                    result.fechaHoraFin = horaFinalizacion;
                    contextDB.SaveChanges();
                }
            }
        }
    }
}
