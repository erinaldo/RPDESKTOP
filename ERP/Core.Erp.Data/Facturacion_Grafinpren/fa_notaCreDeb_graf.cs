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
    
    public partial class fa_notaCreDeb_graf
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public string num_op { get; set; }
        public Nullable<System.DateTime> fecha_op { get; set; }
        public string num_cotizacion { get; set; }
        public Nullable<System.DateTime> fecha_cotizacion { get; set; }
        public Nullable<int> IdEquipo { get; set; }
        public Nullable<double> porc_comision { get; set; }
    }
}
