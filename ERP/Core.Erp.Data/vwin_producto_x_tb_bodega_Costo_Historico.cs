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
    
    public partial class vwin_producto_x_tb_bodega_Costo_Historico
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string cod_sucursal { get; set; }
        public string nom_sucursal { get; set; }
        public int IdBodega { get; set; }
        public string cod_bodega { get; set; }
        public string nom_bodega { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public int IdFecha { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime fecha { get; set; }
        public double costo { get; set; }
        public double Stock_a_la_fecha { get; set; }
        public string Observacion { get; set; }
        public Nullable<System.DateTime> fecha_trans { get; set; }
    }
}