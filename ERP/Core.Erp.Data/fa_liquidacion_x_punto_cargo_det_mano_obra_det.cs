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
    
    public partial class fa_liquidacion_x_punto_cargo_det_mano_obra_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int mo_secuencia { get; set; }
        public decimal IdActividad { get; set; }
        public string observacion { get; set; }
    
        public virtual fa_liquidacion_x_punto_cargo_det_mano_obra fa_liquidacion_x_punto_cargo_det_mano_obra { get; set; }
    }
}
