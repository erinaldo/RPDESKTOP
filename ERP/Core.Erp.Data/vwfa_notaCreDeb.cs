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
    
    public partial class vwfa_notaCreDeb
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string Tipo { get; set; }
        public decimal IdNota { get; set; }
        public string CodNota { get; set; }
        public string CreDeb { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumNota_Impresa { get; set; }
        public string NumAutorizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime no_fecha { get; set; }
        public Nullable<System.DateTime> no_fecha_venc { get; set; }
        public string no_dev_venta { get; set; }
        public int IdTipoNota { get; set; }
        public string sc_observacion { get; set; }
        public string Estado { get; set; }
        public Nullable<double> flete { get; set; }
        public Nullable<double> interes { get; set; }
        public Nullable<double> valor1 { get; set; }
        public Nullable<double> valor2 { get; set; }
        public int IdCaja { get; set; }
        public Nullable<int> IdPuntoVta { get; set; }
        public double sc_subtotal { get; set; }
        public double sc_iva { get; set; }
        public double sc_total { get; set; }
        public double valor_aplicado { get; set; }
        public double saldo { get; set; }
        public string nom_cliente { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_descripcion { get; set; }
        public string Ve_Vendedor { get; set; }
        public string NaturalezaNota { get; set; }
        public string IdCtaCble { get; set; }
    }
}