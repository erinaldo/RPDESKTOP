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
    
    public partial class ct_punto_cargo_grupo
    {
        public ct_punto_cargo_grupo()
        {
            this.ct_punto_cargo = new HashSet<ct_punto_cargo>();
            this.ct_cbtecble_Plantilla_det = new HashSet<ct_cbtecble_Plantilla_det>();
            this.ct_cbtecble_det = new HashSet<ct_cbtecble_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdPunto_cargo_grupo { get; set; }
        public string cod_Punto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public bool estado { get; set; }
        public string IdCtaCble { get; set; }
    
        public virtual ICollection<ct_punto_cargo> ct_punto_cargo { get; set; }
        public virtual ICollection<ct_cbtecble_Plantilla_det> ct_cbtecble_Plantilla_det { get; set; }
        public virtual ICollection<ct_cbtecble_det> ct_cbtecble_det { get; set; }
        public virtual ct_plancta ct_plancta { get; set; }
    }
}
