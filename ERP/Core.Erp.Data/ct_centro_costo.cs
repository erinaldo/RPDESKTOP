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
    
    public partial class ct_centro_costo
    {
        public ct_centro_costo()
        {
            this.ct_centro_costo1 = new HashSet<ct_centro_costo>();
            this.ct_cbtecble_Plantilla_det = new HashSet<ct_cbtecble_Plantilla_det>();
            this.ct_centro_costo_sub_centro_costo = new HashSet<ct_centro_costo_sub_centro_costo>();
            this.ct_cbtecble_det = new HashSet<ct_cbtecble_det>();
        }
    
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string CodCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string IdCentroCostoPadre { get; set; }
        public Nullable<decimal> IdCatalogo { get; set; }
        public string pc_EsMovimiento { get; set; }
        public int IdNivel { get; set; }
        public string pc_Estado { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
        public virtual ICollection<ct_centro_costo> ct_centro_costo1 { get; set; }
        public virtual ct_centro_costo ct_centro_costo2 { get; set; }
        public virtual ct_centro_costo_nivel ct_centro_costo_nivel { get; set; }
        public virtual ICollection<ct_cbtecble_Plantilla_det> ct_cbtecble_Plantilla_det { get; set; }
        public virtual ICollection<ct_centro_costo_sub_centro_costo> ct_centro_costo_sub_centro_costo { get; set; }
        public virtual ICollection<ct_cbtecble_det> ct_cbtecble_det { get; set; }
        public virtual ct_plancta ct_plancta { get; set; }
    }
}
