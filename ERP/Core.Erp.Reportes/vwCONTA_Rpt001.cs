//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCONTA_Rpt001
    {
        public int IdEmpresa { get; set; }
        public int IdAnioF { get; set; }
        public int IdPeriodo { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public string pc_Naturaleza { get; set; }
        public int IdNivel { get; set; }
        public string IdCtaCblePadre { get; set; }
        public double sc_saldo_anterior { get; set; }
        public double sc_debito_mes { get; set; }
        public double sc_credito_mes { get; set; }
        public double sc_saldoPeriodo { get; set; }
        public int sc_debito_acum { get; set; }
        public int sc_credito_acum { get; set; }
        public double sc_saldo_acum { get; set; }
        public string IdGrupoCble { get; set; }
        public string gc_GrupoCble { get; set; }
        public int gc_Orden { get; set; }
        public string gc_estado_financiero { get; set; }
        public string SIdPeriodo { get; set; }
    }
}
