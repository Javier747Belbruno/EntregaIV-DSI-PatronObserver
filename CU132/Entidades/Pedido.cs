
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        public Pedido()
        {
            this.DetallePedidos = new HashSet<DetallePedido>();
        }
    
        public int nroPedido { get; set; }
        public Nullable<int> cantComensales { get; set; }
        public string detPedido { get; set; }
        public Nullable<int> factura { get; set; }
        public Nullable<System.DateTime> fechaHoraPed { get; set; }
        public int mesa { get; set; }
        public int historialEstado { get; set; }
    
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual HistorialEstado HistorialEstado { get; set; }
        public virtual Mesa Mesa { get; set; }
    }
}
