//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cus.Erp.Reports.Naturisa
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCOMP_Rpt003
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string cm_tipo { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string tm_descripcion { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public double SubTotal { get; set; }
        public double dm_precio { get; set; }
        public string dm_observacion { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public string em_nombre { get; set; }
        public string em_ruc { get; set; }
        public string em_telefonos { get; set; }
        public string em_direccion { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public Nullable<bool> do_ManejaIva { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_unidad { get; set; }
        public Nullable<int> IdMotivo_Inv { get; set; }
        public string Desc_mov_inv { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public string nom_unidad_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public Nullable<double> SubTotal_sinConversion { get; set; }
        public string CodMoviInven { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
    }
}
