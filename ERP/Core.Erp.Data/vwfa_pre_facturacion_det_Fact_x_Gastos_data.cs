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
    
    public partial class vwfa_pre_facturacion_det_Fact_x_Gastos_data
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public int secuencia { get; set; }
        public decimal IdCuota { get; set; }
        public int secuencia_cuota { get; set; }
        public string co_factura { get; set; }
        public string co_observacion { get; set; }
        public double co_total { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<double> subtotal_sin_iva { get; set; }
        public double co_Por_iva { get; set; }
        public Nullable<double> valor_iva { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public Nullable<double> Total { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public Nullable<int> IdTipoMovi_grupo { get; set; }
        public string tg_descripcion { get; set; }
    }
}