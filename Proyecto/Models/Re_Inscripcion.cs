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
    
    public partial class Re_Inscripcion
    {
        public string Cod_Re { get; set; }
        public string Tutor { get; set; }
        public string Estado { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
