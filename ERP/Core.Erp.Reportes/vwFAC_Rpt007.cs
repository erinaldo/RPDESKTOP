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
    
    public partial class vwFAC_Rpt007
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string numComprobante { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string Ve_Vendedor { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public System.DateTime vt_fech_venc { get; set; }
        public decimal vt_plazo { get; set; }
        public string vt_tipo_venta { get; set; }
        public string vt_Observacion { get; set; }
        public int IdPeriodo { get; set; }
        public int vt_anio { get; set; }
        public int vt_mes { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public decimal IdProducto { get; set; }
        public string nombreProducto { get; set; }
        public string vt_autorizacion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public Nullable<int> pe_telefonoCasa { get; set; }
    }
}