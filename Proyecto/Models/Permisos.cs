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
    
    public partial class Permisos
    {
        public string Cod_Per { get; set; }
        public string Numero_SP { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Aprobador { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Solicitud_Permisos Solicitud_Permisos { get; set; }
    }
}
