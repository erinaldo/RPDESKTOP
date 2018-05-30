﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt006_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string Centro_costo { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string tecnico_1 { get; set; }
        public string tecnico_2 { get; set; }
        public double subtotal_eg { get; set; }
        public double subtotal_in { get; set; }
        public double subtotal_mo { get; set; }
        public double subtotal_lo { get; set; }
        public double li_subtotal { get; set; }
        public double li_valor_iva { get; set; }
        public double li_total { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string li_num_orden { get; set; }
        public string li_reporte_mantenimiento { get; set; }
        public Nullable<System.DateTime> li_fecha_orden_mantenimiento { get; set; }
        public Nullable<System.DateTime> li_fecha_reporte_mantenimiento { get; set; }
        public string num_oc { get; set; }
        public Nullable<double> subtotal_fa { get; set; }
        public Nullable<double> iva_fa { get; set; }
        public Nullable<double> total_fa { get; set; }
        public Nullable<System.DateTime> vt_fecha { get; set; }
        public string vt_NumFactura { get; set; }
        public string estado_fac { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public string smes { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public Nullable<int> IdanioFiscal { get; set; }
    }
}
