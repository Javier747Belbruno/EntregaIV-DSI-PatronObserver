
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.ProductoDeCarta = new HashSet<ProductoDeCarta>();
        }
    
        public int id_producto { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<int> foto { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> receta { get; set; }
        public Nullable<int> sectorComanda { get; set; }
        public Nullable<int> tiempoPresen { get; set; }
    
        public virtual ICollection<ProductoDeCarta> ProductoDeCarta { get; set; }
    }
}
