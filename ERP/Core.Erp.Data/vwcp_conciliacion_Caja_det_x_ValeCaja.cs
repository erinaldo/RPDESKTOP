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
    
    public partial class vwcp_conciliacion_Caja_det_x_ValeCaja
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdCaja { get; set; }
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdEmpresa_op { get; set; }
        public Nullable<decimal> IdOrdenPago_op { get; set; }
        public string IdCtaCble { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }
        public string cm_Signo { get; set; }
        public string cm_beneficiario { get; set; }
        public int IdTipoMovi { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public int Secuencia_DetcajMovi { get; set; }
        public double cr_Valor { get; set; }
        public string nom_TipoMovi { get; set; }
        public string nom_Caja { get; set; }
        public string nom_EstadoCierre { get; set; }
        public string IdCtaCble_ValeCaja { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdEntidad { get; set; }
        public decimal IdPersona { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string IdBeneficiario { get; set; }
    }
}
