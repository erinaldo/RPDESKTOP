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
    
    public partial class vwcom_ordencompra_local_det_x_MoviInven_SaldoItem
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_CantidadOC { get; set; }
        public double dm_cantidad_Inv { get; set; }
        public Nullable<double> SaldoxRecibir { get; set; }
        public string pr_nombre { get; set; }
        public decimal IdProveedor { get; set; }
        public string Estado { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string oc_NumDocumento { get; set; }
        public string oc_observacion { get; set; }
        public string Solicitante { get; set; }
        public string MotivoAnulacion { get; set; }
        public string MotivoReprobacion { get; set; }
        public Nullable<System.DateTime> co_fechaReproba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public Nullable<System.DateTime> co_fecha_aprobacion { get; set; }
    }
}