//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class in_recepcion_material_cab
    {
        public in_recepcion_material_cab()
        {
            this.in_recepcion_material_det = new HashSet<in_recepcion_material_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdRecepcionMaterial { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public string NumRecepcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string EstadoRecepcion { get; set; }
        public string Observacion { get; set; }
    
        public virtual ICollection<in_recepcion_material_det> in_recepcion_material_det { get; set; }
    }
}
