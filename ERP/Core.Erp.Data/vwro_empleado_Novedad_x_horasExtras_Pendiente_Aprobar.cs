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
    
    public partial class vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRegistro { get; set; }
        public string IdRubro { get; set; }
        public System.DateTime es_fecha_registro { get; set; }
        public string Num_horasExtras { get; set; }
        public string Observacion { get; set; }
        public bool Estado_aprobacion { get; set; }
        public string ru_descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public Nullable<double> SueldoActual { get; set; }
        public int Calculo_Horas_extras_Sobre { get; set; }
        public int Max_num_horas_sab_dom { get; set; }
        public int IdTipoNomina { get; set; }
    }
}