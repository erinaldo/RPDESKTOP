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
    
    public partial class tb_parametro_tipo
    {
        public tb_parametro_tipo()
        {
            this.tb_parametro = new HashSet<tb_parametro>();
        }
    
        public string IdTipoParam { get; set; }
        public string nom_TipoParam { get; set; }
    
        public virtual ICollection<tb_parametro> tb_parametro { get; set; }
    }
}
