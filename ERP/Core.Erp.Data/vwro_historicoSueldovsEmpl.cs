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
    
    public partial class vwro_historicoSueldovsEmpl
    {
        public string pe_nombreCompleto { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int Secuencia { get; set; }
        public double SueldoAnterior { get; set; }
        public double SueldoActual { get; set; }
        public double PorIncrementoSueldo { get; set; }
        public double ValorIncrementoSueldo { get; set; }
        public string Motivo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string de_descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
    }
}