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
    
    public partial class imp_orden_compra_ext_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public double od_cantidad { get; set; }
        public double od_costo { get; set; }
        public double od_por_descuento { get; set; }
        public double od_descuento { get; set; }
        public double od_costo_final { get; set; }
        public double od_subtotal { get; set; }
        public double od_cantidad_recepcion { get; set; }
        public double od_costo_convertido { get; set; }
        public double od_total_fob { get; set; }
        public double od_factor_costo { get; set; }
        public double od_costo_bodega { get; set; }
        public double od_costo_total { get; set; }
    
        public virtual imp_orden_compra_ext imp_orden_compra_ext { get; set; }
    }
}