﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
   public class ro_empleado_x_parametro_x_pago_variable_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_Tipo { get; set; }
       public decimal IdEmpleado { get; set;  }
       public bool Estado { get; set; }
       public string IdUsuario { get; set; }
       public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
       public string IdUsuarioUltModi { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string MotivoAnulacion { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public bool icono_eliminar { get; set; }
       public bool check { get; set; }

       public Nullable<int> IdFuerza { get; set; }
       public string fu_descripcion { get; set; }
       public string pe_apellido { get; set; }
       public string pe_nombre { get; set; }
       public string pe_nombreCompleto { get; set; }
       public string pe_cedulaRuc { get; set; }
       public List<ro_empleado_x_parametro_x_pago_variable_Det_Info> Lista { get; set; }
    }
}
