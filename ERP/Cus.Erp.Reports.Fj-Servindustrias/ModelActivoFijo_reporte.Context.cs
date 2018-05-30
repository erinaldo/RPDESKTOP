﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cus.Erp.Reports.FJ
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesActivoFijo_Reporte_FJ : DbContext
    {
        public EntitiesActivoFijo_Reporte_FJ()
            : base("name=EntitiesActivoFijo_Reporte_FJ")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwACTF_FJ_Rpt002> vwACTF_FJ_Rpt002 { get; set; }
    
        public virtual ObjectResult<spACTF_Rpt001_Result> spACTF_Rpt001(Nullable<int> idEmpresa, Nullable<System.DateTime> fecha_corte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var fecha_corteParameter = fecha_corte.HasValue ?
                new ObjectParameter("Fecha_corte", fecha_corte) :
                new ObjectParameter("Fecha_corte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spACTF_Rpt001_Result>("spACTF_Rpt001", idEmpresaParameter, fecha_corteParameter);
        }
    
        public virtual ObjectResult<spACTF_FJ_Rpt003_Result> spACTF_FJ_Rpt003(Nullable<int> idEmpresa, Nullable<System.DateTime> fechaI, Nullable<System.DateTime> fechaF, Nullable<bool> estadoUbicacion)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var fechaIParameter = fechaI.HasValue ?
                new ObjectParameter("FechaI", fechaI) :
                new ObjectParameter("FechaI", typeof(System.DateTime));
    
            var fechaFParameter = fechaF.HasValue ?
                new ObjectParameter("FechaF", fechaF) :
                new ObjectParameter("FechaF", typeof(System.DateTime));
    
            var estadoUbicacionParameter = estadoUbicacion.HasValue ?
                new ObjectParameter("estadoUbicacion", estadoUbicacion) :
                new ObjectParameter("estadoUbicacion", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spACTF_FJ_Rpt003_Result>("spACTF_FJ_Rpt003", idEmpresaParameter, fechaIParameter, fechaFParameter, estadoUbicacionParameter);
        }
    }
}
