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
    
    public partial class Af_CatalogoTipo
    {
        public Af_CatalogoTipo()
        {
            this.Af_Catalogo = new HashSet<Af_Catalogo>();
        }
    
        public string IdTipoCatalogo { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Af_Catalogo> Af_Catalogo { get; set; }
    }
}