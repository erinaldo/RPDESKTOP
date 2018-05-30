﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt001_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt001_Data oData = new XROL_Rpt001_Data();

        public List<XROL_Rpt001_Info> GetListConsultaGeneral(int idEmpresa,int idnomina, int iddivion)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa,idnomina, iddivion);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt001_Info>();
            }
        }

    
         public List<XROL_Rpt001_Info> GetListConsultaGeneral(int idEmpresa, int idnomina)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idnomina);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt001_Info>();
            }
        }


    }
}
