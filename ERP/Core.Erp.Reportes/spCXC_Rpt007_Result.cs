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
    
    public partial class spCXC_Rpt007_Result
    {
        public int Orden { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string IdCobro_tipo { get; set; }
        public string Su_Descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string numDocumento { get; set; }
        public decimal IdCliente { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public Nullable<int> DiasVencidos { get; set; }
        public string IdEstadoCobro { get; set; }
        public Nullable<double> Monto { get; set; }
        public Nullable<double> TotalCobrado { get; set; }
        public Nullable<double> Valor_Vencido { get; set; }
        public Nullable<double> Valor_x_Vencer { get; set; }
        public string Tipo { get; set; }
        public string Documento_Grupo { get; set; }
    }
}