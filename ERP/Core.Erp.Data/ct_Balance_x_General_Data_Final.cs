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
    
    public partial class ct_Balance_x_General_Data_Final
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public int IdNivelCta { get; set; }
        public string GrupoCble { get; set; }
        public Nullable<int> OrderGrupoCble { get; set; }
        public string gc_estado_financiero { get; set; }
        public string IdCtaCblePadre { get; set; }
        public double Saldo_Inicial { get; set; }
        public double Debito_Mes { get; set; }
        public double Credito_Mes { get; set; }
        public double Saldo { get; set; }
        public string pc_EsMovimiento { get; set; }
        public Nullable<int> gc_signo_operacion { get; set; }
        public Nullable<bool> CtaUtilidad { get; set; }
        public Nullable<double> Saldo_inicial_x_Movi { get; set; }
        public Nullable<double> Debito_Mes_x_Movi { get; set; }
        public Nullable<double> Credito_Mes_x_Movi { get; set; }
        public Nullable<double> Saldo_x_Movi { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_empresa { get; set; }
        public string IdGrupo_Mayor { get; set; }
        public string nom_grupo_mayor { get; set; }
        public Nullable<int> order_grupo_mayor { get; set; }
        public int orden_fila { get; set; }
        public Nullable<bool> Reg_x_CC { get; set; }
        public Nullable<double> Saldo_Inicial_deudor { get; set; }
        public Nullable<double> Saldo_Inicial_acreedor { get; set; }
        public Nullable<double> Saldo_fin_deudor { get; set; }
        public Nullable<double> Saldo_fin_acreedor { get; set; }
        public string pc_clave_corta { get; set; }
    }
}
