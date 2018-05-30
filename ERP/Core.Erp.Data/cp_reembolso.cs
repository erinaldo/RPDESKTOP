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
    
    public partial class cp_reembolso
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdReembolso { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string TipoIdProveedor { get; set; }
        public string IdentificacionProveedor { get; set; }
        public string TipoDoc_CodSRI { get; set; }
        public string Establecimiento { get; set; }
        public string Punto_Emision { get; set; }
        public string Secuencial { get; set; }
        public string Autorizacion { get; set; }
        public Nullable<System.DateTime> Fecha_Emision { get; set; }
        public Nullable<double> TarifaIVAcero { get; set; }
        public Nullable<double> TarifaIVADiferentecero { get; set; }
        public Nullable<double> TarifaNoObjetoIVA { get; set; }
        public Nullable<double> MontoICE { get; set; }
        public Nullable<double> MontoIVA { get; set; }
        public Nullable<double> baseImponible { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual cp_orden_giro cp_orden_giro { get; set; }
        public virtual cp_proveedor cp_proveedor { get; set; }
    }
}