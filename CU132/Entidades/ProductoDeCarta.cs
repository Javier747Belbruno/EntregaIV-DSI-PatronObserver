
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductoDeCarta
    {
        public ProductoDeCarta()
        {
            this.DetallePedidos = new HashSet<DetallePedido>();
        }
    
        public int id_productoDeCarta { get; set; }
        public int esFavorito { get; set; }
        public string comentarios { get; set; }
        public Nullable<decimal> precio { get; set; }
        public int id_producto { get; set; }
    
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
