﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt018_Bus
    {
        XCXC_Rpt018_Data oData = new XCXC_Rpt018_Data();

        public List<XCXC_Rpt018_Info> get_list(int IdEmpresa, decimal IdCliente, bool no_mostrar_saldo_0, bool mostrar_anuladas, DateTime Fecha_corte)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdCliente, no_mostrar_saldo_0, mostrar_anuladas, Fecha_corte);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
