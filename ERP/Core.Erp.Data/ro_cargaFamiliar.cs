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
    
    public partial class ro_cargaFamiliar
    {
        public int IdEmpresa { get; set; }
        public int IdCargaFamiliar { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string TipoFamiliar { get; set; }
        public string Nombres { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaDefucion { get; set; }
        public bool capacidades_especiales { get; set; }
    
        public virtual ro_catalogo ro_catalogo { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
    }
}