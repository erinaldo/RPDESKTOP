//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion_Grafinpren
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_guia_remision_graf
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string Num_OP { get; set; }
        public Nullable<decimal> Num_Cotizacion { get; set; }
        public Nullable<System.DateTime> fecha_Cotizacion { get; set; }
        public int IdEquipo { get; set; }
    }
}
