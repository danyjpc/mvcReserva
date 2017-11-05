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
    
    public partial class reservacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reservacion()
        {
            this.hab_reser = new HashSet<hab_reser>();
        }
    
        public int cod_reservacion { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> cod_estado { get; set; }
        public Nullable<int> cod_usuario { get; set; }
        public Nullable<int> cod_cliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual estado estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hab_reser> hab_reser { get; set; }
        public virtual recepcionista recepcionista { get; set; }
    }
}
