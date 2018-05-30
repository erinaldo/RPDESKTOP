//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class com_dev_compra
    {
        public com_dev_compra()
        {
            this.com_dev_compra_det = new HashSet<com_dev_compra_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string Tipo { get; set; }
        public System.DateTime dv_fecha { get; set; }
        public double dv_flete { get; set; }
        public string dv_observacion { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string AfectaCosto { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual ICollection<com_dev_compra_det> com_dev_compra_det { get; set; }
    }
}
