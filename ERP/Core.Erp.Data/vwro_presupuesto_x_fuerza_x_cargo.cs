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
    
    public partial class vwro_presupuesto_x_fuerza_x_cargo
    {
        public int IdEmpresa { get; set; }
        public int IdNomina { get; set; }
        public int IdFuerza { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int IdCargo { get; set; }
        public decimal CantidadEmpleados { get; set; }
        public double Presupuesto { get; set; }
        public string Observacion { get; set; }
        public int Dias_SyD_y_Feriado { get; set; }
        public int diasEfectivos { get; set; }
        public Nullable<double> BaseVariable { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSuccentroCosto { get; set; }
    }
}
