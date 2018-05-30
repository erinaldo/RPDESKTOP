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
    
    public partial class ro_rdep
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int AnioFiscal { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public double suelSal { get; set; }
        public double sobSuelComRemu { get; set; }
        public double partUtil { get; set; }
        public double intGrabGen { get; set; }
        public double impRentEmpl { get; set; }
        public double decimTer { get; set; }
        public double decimCuar { get; set; }
        public double fondoReserva { get; set; }
        public double salarioDigno { get; set; }
        public double otrosIngRenGrav { get; set; }
        public double ingGravConEsteEmpl { get; set; }
        public double sisSalNet { get; set; }
        public double apoPerIess { get; set; }
        public double aporPerIessConOtrosEmpls { get; set; }
        public double deducVivienda { get; set; }
        public double deducSalud { get; set; }
        public double deducEduca { get; set; }
        public double deducAliement { get; set; }
        public double deducVestim { get; set; }
        public double exoDiscap { get; set; }
        public double exoTerEd { get; set; }
        public double basImp { get; set; }
        public double impRentCaus { get; set; }
        public double valRetAsuOtrosEmpls { get; set; }
        public double valImpAsuEsteEmpl { get; set; }
        public double valRet { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ro_empleado ro_empleado { get; set; }
    }
}
