
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesa
    {
        public Mesa()
        {
            this.Pedidos = new HashSet<Pedido>();
        }
    
        public int numero { get; set; }
        public Nullable<int> capacidadComensales { get; set; }
        public Nullable<int> espacioQueOcupa { get; set; }
        public Nullable<int> forma { get; set; }
        public Nullable<int> filaEnPlano { get; set; }
        public Nullable<int> ordenEnPlano { get; set; }
        public int estado { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
