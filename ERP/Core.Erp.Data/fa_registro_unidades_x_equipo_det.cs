//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_registro_unidades_x_equipo_det
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdFecha { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdUnidad_Medida { get; set; }
        public string IdTipo_Reg_cat { get; set; }
        public double Valor { get; set; }
        public Nullable<System.DateTime> fecha_reg { get; set; }
        public Nullable<System.DateTime> fecha_modi { get; set; }
    
        public virtual fa_registro_unidades_x_equipo fa_registro_unidades_x_equipo { get; set; }
    }
}
