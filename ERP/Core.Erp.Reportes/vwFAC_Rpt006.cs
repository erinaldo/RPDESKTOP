//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwFAC_Rpt006
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string pe_nombreCompleto { get; set; }
        public decimal IdDevolucion { get; set; }
        public string CodDevolucion { get; set; }
        public decimal IdNota { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdCbteVta { get; set; }
        public System.DateTime dv_fecha { get; set; }
        public string Estado { get; set; }
        public string dv_Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public Nullable<double> dv_total { get; set; }
        public Nullable<double> dv_iva { get; set; }
        public Nullable<double> dv_subtotal { get; set; }
        public string Ve_Vendedor { get; set; }
        public string vt_NumFactura { get; set; }
    }
}