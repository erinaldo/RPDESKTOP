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
    
    public partial class vwCXC_Rpt011
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public string Su_Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public int Idtipo_cliente { get; set; }
        public string Descripcion_tip_cliente { get; set; }
        public Nullable<double> Total_Debe { get; set; }
        public Nullable<double> Total_Haber { get; set; }
    }
}
