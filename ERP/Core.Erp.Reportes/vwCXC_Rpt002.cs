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
    
    public partial class vwCXC_Rpt002
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdAnticipo { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public Nullable<int> IdEmpresa_Cobro { get; set; }
        public Nullable<int> IdSucursal_cobro { get; set; }
        public Nullable<decimal> IdCobro_cobro { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public double cr_TotalCobro { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }
    }
}