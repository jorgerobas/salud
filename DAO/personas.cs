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
    
    public partial class personas
    {
        public personas()
        {
            this.datos_contactos = new HashSet<datos_contactos>();
            this.obras_sociales = new HashSet<obras_sociales>();
        }
    
        public int Id { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> direccion_Id { get; set; }
    
        public virtual ICollection<datos_contactos> datos_contactos { get; set; }
        public virtual direcciones direcciones { get; set; }
        public virtual personas_medico personas_medico { get; set; }
        public virtual personas_paciente personas_paciente { get; set; }
        public virtual ICollection<obras_sociales> obras_sociales { get; set; }
    }
}
