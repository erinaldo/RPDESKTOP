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
    
    public partial class vwcp_conciliacion_x_cbte_cble
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public Nullable<int> IdTipocbte { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public string referencia { get; set; }
        public string tc_TipoCbte { get; set; }
        public Nullable<double> Valor_cbte { get; set; }
        public double Valor_cancelado_cbte { get; set; }
        public Nullable<double> valor_Saldo_cbte { get; set; }
        public decimal IdConciliacion { get; set; }
    }
}