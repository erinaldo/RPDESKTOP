//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ro_implemento_Trabajador_Tipo
    {
        public ro_implemento_Trabajador_Tipo()
        {
            this.ro_Implemento_Trabajador = new HashSet<ro_Implemento_Trabajador>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdTipoImplemento { get; set; }
        public string descripcion { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<ro_Implemento_Trabajador> ro_Implemento_Trabajador { get; set; }
    }
}
