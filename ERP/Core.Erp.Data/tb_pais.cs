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
    
    public partial class tb_pais
    {
        public tb_pais()
        {
            this.tb_provincia = new HashSet<tb_provincia>();
            this.tb_contacto = new HashSet<tb_contacto>();
            this.tb_contacto1 = new HashSet<tb_contacto>();
        }
    
        public string IdPais { get; set; }
        public string CodPais { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
        public virtual ICollection<tb_provincia> tb_provincia { get; set; }
        public virtual ICollection<tb_contacto> tb_contacto { get; set; }
        public virtual ICollection<tb_contacto> tb_contacto1 { get; set; }
    }
}
