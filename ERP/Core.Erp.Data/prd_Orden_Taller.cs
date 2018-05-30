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
    
    public partial class prd_Orden_Taller
    {
        public prd_Orden_Taller()
        {
            this.prd_DespachoDet = new HashSet<prd_DespachoDet>();
            this.prd_Ensamblado_CusCider = new HashSet<prd_Ensamblado_CusCider>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public string CodObra { get; set; }
        public int NumeroOT { get; set; }
        public string Codigo { get; set; }
        public decimal IdProducto { get; set; }
        public decimal CantidadPieza { get; set; }
        public decimal PesoUnitaro { get; set; }
        public decimal TotalPeso { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public System.DateTime FechaReg { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<decimal> IdListadoDiseno { get; set; }
        public Nullable<decimal> TotalLongitud { get; set; }
        public Nullable<decimal> LongitudUnitaria { get; set; }
    
        public virtual ICollection<prd_DespachoDet> prd_DespachoDet { get; set; }
        public virtual ICollection<prd_Ensamblado_CusCider> prd_Ensamblado_CusCider { get; set; }
    }
}
