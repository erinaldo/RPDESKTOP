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
    
    public partial class cp_cuotas_x_doc
    {
        public cp_cuotas_x_doc()
        {
            this.cp_cuotas_x_doc_det = new HashSet<cp_cuotas_x_doc_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdCuota { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public double Total_a_pagar { get; set; }
        public int Num_cuotas { get; set; }
        public int Dias_plazo { get; set; }
        public System.DateTime Fecha_inicio { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
    
        public virtual ICollection<cp_cuotas_x_doc_det> cp_cuotas_x_doc_det { get; set; }
    }
}
