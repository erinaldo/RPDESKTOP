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
    
    public partial class ro_marcaciones_x_empleado_x_incidentes_falt_Perm
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRegistro { get; set; }
        public decimal IdTurno { get; set; }
        public System.DateTime es_fecha_registro { get; set; }
        public string Id_catalogo_Cat { get; set; }
        public string Observacion { get; set; }
        public bool es_jornada_desfasada { get; set; }
        public Nullable<int> IdDisco { get; set; }
        public Nullable<int> IdRuta { get; set; }
        public Nullable<int> IdSala { get; set; }
    
        public virtual ro_disco ro_disco { get; set; }
        public virtual ro_ruta ro_ruta { get; set; }
        public virtual ro_sala ro_sala { get; set; }
    }
}
