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
    
    public partial class com_GenerOCompra_Det
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public int IdDetTrans { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string Motivo { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Kg { get; set; }
        public string IdEstadoAprob { get; set; }
        public System.DateTime FechaRequer { get; set; }
        public Nullable<decimal> IdListadoMateriales { get; set; }
        public Nullable<int> IdDetalle { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> oc_IdEmpresa { get; set; }
        public Nullable<decimal> oc_IdOrdenCompra { get; set; }
        public string usuariosolicitante { get; set; }
    }
}
