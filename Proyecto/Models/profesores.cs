//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class profesores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public profesores()
        {
            this.Califica = new HashSet<Califica>();
        }
    
        public string Cod_P { get; set; }
        public string CI { get; set; }
        public string Horario_Atencion { get; set; }
        public string Curso { get; set; }
        public string contrasenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Califica> Califica { get; set; }
        public virtual Curso Curso1 { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
