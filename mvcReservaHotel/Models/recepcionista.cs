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
    
    public partial class recepcionista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public recepcionista()
        {
            this.reservacion = new HashSet<reservacion>();
        }
    
        public int cod_usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nombre_usuario { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservacion> reservacion { get; set; }
    }
}
