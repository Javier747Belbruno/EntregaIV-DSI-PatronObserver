
namespace CU132.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public Menu()
        {
            this.DetallePedidos = new HashSet<DetallePedido>();
        }
    
        public int id_menu { get; set; }
        public int cantidadMinimaComensales { get; set; }
        public string comentarios { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaVigencia { get; set; }
        public Nullable<int> foto { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
