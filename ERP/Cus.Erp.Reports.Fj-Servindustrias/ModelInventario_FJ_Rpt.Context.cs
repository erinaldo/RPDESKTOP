﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
    
    public partial class EntitiesInventario_FJ_Rpt : DbContext
    {
        public EntitiesInventario_FJ_Rpt()
            : base("name=EntitiesInventario_FJ_Rpt")
        {
        }
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwINV_FJ_Rpt005> vwINV_FJ_Rpt005 { get; set; }
        public DbSet<vwINV_FJ_Rpt002> vwINV_FJ_Rpt002 { get; set; }
        public DbSet<vwINV_FJ_Rpt003> vwINV_FJ_Rpt003 { get; set; }
        public DbSet<vwINV_FJ_Rpt004> vwINV_FJ_Rpt004 { get; set; }
        public DbSet<vwINV_FJ_Rpt006> vwINV_FJ_Rpt006 { get; set; }
        public DbSet<vwINV_FJ_Rpt001> vwINV_FJ_Rpt001 { get; set; }
        public DbSet<vwINV_FJ_Rpt007> vwINV_FJ_Rpt007 { get; set; }
        public DbSet<vwINV_FJ_Rpt008> vwINV_FJ_Rpt008 { get; set; }
    
        public virtual ObjectResult<spINV_FJ_Rpt003_Result> spINV_FJ_Rpt003(Nullable<int> idEmpresa, Nullable<int> idSucursalIni, Nullable<int> idSucursalFin, Nullable<int> idBodegaIni, Nullable<int> idBodegaFin, Nullable<decimal> idProductoIni, Nullable<decimal> idProductoFin, Nullable<System.DateTime> fechaCorteIni, string idCentro_Costo, string idSubcentro_Costo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idSucursalIniParameter = idSucursalIni.HasValue ?
                new ObjectParameter("IdSucursalIni", idSucursalIni) :
                new ObjectParameter("IdSucursalIni", typeof(int));
    
            var idSucursalFinParameter = idSucursalFin.HasValue ?
                new ObjectParameter("IdSucursalFin", idSucursalFin) :
                new ObjectParameter("IdSucursalFin", typeof(int));
    
            var idBodegaIniParameter = idBodegaIni.HasValue ?
                new ObjectParameter("IdBodegaIni", idBodegaIni) :
                new ObjectParameter("IdBodegaIni", typeof(int));
    
            var idBodegaFinParameter = idBodegaFin.HasValue ?
                new ObjectParameter("IdBodegaFin", idBodegaFin) :
                new ObjectParameter("IdBodegaFin", typeof(int));
    
            var idProductoIniParameter = idProductoIni.HasValue ?
                new ObjectParameter("IdProductoIni", idProductoIni) :
                new ObjectParameter("IdProductoIni", typeof(decimal));
    
            var idProductoFinParameter = idProductoFin.HasValue ?
                new ObjectParameter("IdProductoFin", idProductoFin) :
                new ObjectParameter("IdProductoFin", typeof(decimal));
    
            var fechaCorteIniParameter = fechaCorteIni.HasValue ?
                new ObjectParameter("FechaCorteIni", fechaCorteIni) :
                new ObjectParameter("FechaCorteIni", typeof(System.DateTime));
    
            var idCentro_CostoParameter = idCentro_Costo != null ?
                new ObjectParameter("IdCentro_Costo", idCentro_Costo) :
                new ObjectParameter("IdCentro_Costo", typeof(string));
    
            var idSubcentro_CostoParameter = idSubcentro_Costo != null ?
                new ObjectParameter("IdSubcentro_Costo", idSubcentro_Costo) :
                new ObjectParameter("IdSubcentro_Costo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spINV_FJ_Rpt003_Result>("spINV_FJ_Rpt003", idEmpresaParameter, idSucursalIniParameter, idSucursalFinParameter, idBodegaIniParameter, idBodegaFinParameter, idProductoIniParameter, idProductoFinParameter, fechaCorteIniParameter, idCentro_CostoParameter, idSubcentro_CostoParameter);
        }
    
        public virtual ObjectResult<spINV_FJ_Rpt002_Result> spINV_FJ_Rpt002(Nullable<int> idEmpresa, Nullable<int> idSucursalIni, Nullable<int> idSucursalFin, Nullable<int> idBodegaIni, Nullable<int> idBodegaFin, Nullable<decimal> idProductoIni, Nullable<decimal> idProductoFin, Nullable<System.DateTime> fechaCorteIni, string idCentro_costo, string idSubCentro_costo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idSucursalIniParameter = idSucursalIni.HasValue ?
                new ObjectParameter("IdSucursalIni", idSucursalIni) :
                new ObjectParameter("IdSucursalIni", typeof(int));
    
            var idSucursalFinParameter = idSucursalFin.HasValue ?
                new ObjectParameter("IdSucursalFin", idSucursalFin) :
                new ObjectParameter("IdSucursalFin", typeof(int));
    
            var idBodegaIniParameter = idBodegaIni.HasValue ?
                new ObjectParameter("IdBodegaIni", idBodegaIni) :
                new ObjectParameter("IdBodegaIni", typeof(int));
    
            var idBodegaFinParameter = idBodegaFin.HasValue ?
                new ObjectParameter("IdBodegaFin", idBodegaFin) :
                new ObjectParameter("IdBodegaFin", typeof(int));
    
            var idProductoIniParameter = idProductoIni.HasValue ?
                new ObjectParameter("IdProductoIni", idProductoIni) :
                new ObjectParameter("IdProductoIni", typeof(decimal));
    
            var idProductoFinParameter = idProductoFin.HasValue ?
                new ObjectParameter("IdProductoFin", idProductoFin) :
                new ObjectParameter("IdProductoFin", typeof(decimal));
    
            var fechaCorteIniParameter = fechaCorteIni.HasValue ?
                new ObjectParameter("FechaCorteIni", fechaCorteIni) :
                new ObjectParameter("FechaCorteIni", typeof(System.DateTime));
    
            var idCentro_costoParameter = idCentro_costo != null ?
                new ObjectParameter("IdCentro_costo", idCentro_costo) :
                new ObjectParameter("IdCentro_costo", typeof(string));
    
            var idSubCentro_costoParameter = idSubCentro_costo != null ?
                new ObjectParameter("IdSubCentro_costo", idSubCentro_costo) :
                new ObjectParameter("IdSubCentro_costo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spINV_FJ_Rpt002_Result>("spINV_FJ_Rpt002", idEmpresaParameter, idSucursalIniParameter, idSucursalFinParameter, idBodegaIniParameter, idBodegaFinParameter, idProductoIniParameter, idProductoFinParameter, fechaCorteIniParameter, idCentro_costoParameter, idSubCentro_costoParameter);
        }
    
        public virtual ObjectResult<spINV_FJ_Rpt009_Result> spINV_FJ_Rpt009(Nullable<int> idEmpresa, Nullable<int> idSucursal_ini, Nullable<int> idSucursal_fin, Nullable<int> idBodega_ini, Nullable<int> idBodega_fin, Nullable<decimal> idProducto_ini, Nullable<decimal> idProducto_fin, Nullable<System.DateTime> fecha_ini, Nullable<System.DateTime> fecha_fin, string idUsuario, Nullable<bool> no_Mostrar_valores_en_0, Nullable<bool> mostrar_detallado)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idSucursal_iniParameter = idSucursal_ini.HasValue ?
                new ObjectParameter("IdSucursal_ini", idSucursal_ini) :
                new ObjectParameter("IdSucursal_ini", typeof(int));
    
            var idSucursal_finParameter = idSucursal_fin.HasValue ?
                new ObjectParameter("IdSucursal_fin", idSucursal_fin) :
                new ObjectParameter("IdSucursal_fin", typeof(int));
    
            var idBodega_iniParameter = idBodega_ini.HasValue ?
                new ObjectParameter("IdBodega_ini", idBodega_ini) :
                new ObjectParameter("IdBodega_ini", typeof(int));
    
            var idBodega_finParameter = idBodega_fin.HasValue ?
                new ObjectParameter("IdBodega_fin", idBodega_fin) :
                new ObjectParameter("IdBodega_fin", typeof(int));
    
            var idProducto_iniParameter = idProducto_ini.HasValue ?
                new ObjectParameter("IdProducto_ini", idProducto_ini) :
                new ObjectParameter("IdProducto_ini", typeof(decimal));
    
            var idProducto_finParameter = idProducto_fin.HasValue ?
                new ObjectParameter("IdProducto_fin", idProducto_fin) :
                new ObjectParameter("IdProducto_fin", typeof(decimal));
    
            var fecha_iniParameter = fecha_ini.HasValue ?
                new ObjectParameter("Fecha_ini", fecha_ini) :
                new ObjectParameter("Fecha_ini", typeof(System.DateTime));
    
            var fecha_finParameter = fecha_fin.HasValue ?
                new ObjectParameter("Fecha_fin", fecha_fin) :
                new ObjectParameter("Fecha_fin", typeof(System.DateTime));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var no_Mostrar_valores_en_0Parameter = no_Mostrar_valores_en_0.HasValue ?
                new ObjectParameter("No_Mostrar_valores_en_0", no_Mostrar_valores_en_0) :
                new ObjectParameter("No_Mostrar_valores_en_0", typeof(bool));
    
            var mostrar_detalladoParameter = mostrar_detallado.HasValue ?
                new ObjectParameter("Mostrar_detallado", mostrar_detallado) :
                new ObjectParameter("Mostrar_detallado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spINV_FJ_Rpt009_Result>("spINV_FJ_Rpt009", idEmpresaParameter, idSucursal_iniParameter, idSucursal_finParameter, idBodega_iniParameter, idBodega_finParameter, idProducto_iniParameter, idProducto_finParameter, fecha_iniParameter, fecha_finParameter, idUsuarioParameter, no_Mostrar_valores_en_0Parameter, mostrar_detalladoParameter);
        }
    }
}