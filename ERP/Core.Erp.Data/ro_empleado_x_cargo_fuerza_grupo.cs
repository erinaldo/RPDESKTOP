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
    
    public partial class ro_empleado_x_cargo_fuerza_grupo
    {
        public int IdEmpresa { get; set; }
        public int IdNomina { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdPeriodo { get; set; }
        public int IdFuerza { get; set; }
        public int IdGrupo { get; set; }
        public int IdCargo { get; set; }
        public string Observacion { get; set; }
    
        public virtual ro_Grupo_empleado ro_Grupo_empleado { get; set; }
        public virtual ro_fuerza ro_fuerza { get; set; }
    }
}
