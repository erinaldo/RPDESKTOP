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
    
    public partial class vwCOMP_NATU_Rpt007
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string IdTerminoPago { get; set; }
        public int Plazo { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Flete { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> IdSolicitante { get; set; }
        public decimal IdComprador { get; set; }
        public Nullable<decimal> IdDepartamento { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double por_desc { get; set; }
        public double valor_descuento { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        public double peso { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string sucursal { get; set; }
        public string empresa { get; set; }
        public string ruc_empresa { get; set; }
        public byte[] logo_empresa { get; set; }
        public string nom_proveedor { get; set; }
        public string ced_ruc_provee { get; set; }
        public string direc_provee { get; set; }
        public string telef_provee { get; set; }
        public string NomUnidad { get; set; }
        public string Nom_comprador { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_centro_costo { get; set; }
        public string nom_sub_centro_costo { get; set; }
        public string Detalle_x_Items { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string em_direccion { get; set; }
        public string nom_solicitante { get; set; }
        public string Descripcion { get; set; }
        public string Nom_TerminoPago { get; set; }
        public string departamento { get; set; }
        public string nom_EstadoCierre { get; set; }
        public string pr_codigo { get; set; }
    }
}
