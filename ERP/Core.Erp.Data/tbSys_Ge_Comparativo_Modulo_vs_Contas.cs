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
    
    public partial class tbSys_Ge_Comparativo_Modulo_vs_Contas
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string cod_sucu { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<decimal> IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public string vt_Observacion { get; set; }
        public Nullable<double> Debito_Vta { get; set; }
        public Nullable<double> Credito_Vta { get; set; }
        public Nullable<System.DateTime> cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<double> Debito_Conta { get; set; }
        public double Credito_Conta { get; set; }
        public string pc_Cuenta { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public Nullable<int> secuencia { get; set; }
        public string TIPO { get; set; }
        public string referencia { get; set; }
    }
}
