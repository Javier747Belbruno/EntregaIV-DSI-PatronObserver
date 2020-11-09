
namespace CU132.Entidades
{
    using System.Collections.Generic;
    
    public partial class Estado
    {
        
        public Estado()
        {
            this.HistorialEstado = new HashSet<HistorialEstado>();
            this.Mesa = new HashSet<Mesa>();
        }
    
        public int id_estado { get; set; }
        public string ambito { get; set; }
        public string nombre { get; set; }
  
        public virtual ICollection<HistorialEstado> HistorialEstado { get; set; }
        public virtual ICollection<Mesa> Mesa { get; set; }


        public bool EsAmbitoDetallePedido(){
            if (ambito == "DetallePedido")
                return true;
            return false;
        }

        public bool EsEnPreparacion(){
            if (nombre == "En preparacion")
                return true;
            return false;
        }

        public bool EsListoParaServir(){
            if (nombre == "Listo para servir")
                return true;
            return false;
        }

        public bool EsNotificado()
        {
            if (nombre == "Notificado")
                return true;
            return false;
        }

        // Se sobreescribe el metodo heredado de objeto que compara dos Estados.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Estado e = (Estado)obj;
            return ambito.Equals(e.ambito) && nombre.Equals(e.nombre);
        }
    }
}
