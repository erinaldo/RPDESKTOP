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
    
    public partial class imp_gastosxImport
    {
        public imp_gastosxImport()
        {
            this.imp_gastosxImport_x_Empresa = new HashSet<imp_gastosxImport_x_Empresa>();
            this.imp_ordencompra_ext_x_imp_gastosxImport_det = new HashSet<imp_ordencompra_ext_x_imp_gastosxImport_det>();
        }
    
        public int IdGastoImp { get; set; }
        public string CodGastoImp { get; set; }
        public string ga_decripcion { get; set; }
        public string ga_estado { get; set; }
    
        public virtual ICollection<imp_gastosxImport_x_Empresa> imp_gastosxImport_x_Empresa { get; set; }
        public virtual ICollection<imp_ordencompra_ext_x_imp_gastosxImport_det> imp_ordencompra_ext_x_imp_gastosxImport_det { get; set; }
    }
}
