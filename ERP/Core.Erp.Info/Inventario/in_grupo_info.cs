﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.Inventario
{
   public  class in_grupo_info
    {
       public int IdEmpresa { get; set; }
       public string IdCategoria { get; set; }
       public int IdLinea { get; set; }
       public int IdGrupo { get; set; }
       public string cod_grupo { get; set; }
       public string nom_grupo { get; set; }
       public string Estado { get; set; }
       public string observacion { get; set; }
       public string IdUsuario { get; set; }
       public DateTime Fecha_Transac { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public string MotiAnula { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public DateTime Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public DateTime Fecha_UltAnu { get; set; }

       public in_grupo_info()
       {

       }


    }
}
