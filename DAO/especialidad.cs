//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class especialidad
    {
        public especialidad()
        {
            this.persona_medico = new HashSet<persona_medico>();
        }
    
        public int Id { get; set; }
        public string denominacion { get; set; }
    
        public virtual ICollection<persona_medico> persona_medico { get; set; }
    }
}
