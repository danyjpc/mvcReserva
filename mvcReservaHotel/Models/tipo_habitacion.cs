//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcReservaHotel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_habitacion()
        {
            this.habitacion = new HashSet<habitacion>();
        }
    
        public int cod_tipo_habitacion { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habitacion> habitacion { get; set; }
    }
}
