﻿

CREATE PROCEDURE [dbo].[spRo_procesa_Rol] (
@IdEmpresa int,
@IdNomina numeric,
@IdNominaTipo numeric,
@IdPEriodo numeric,
@IdUsuario varchar(50),
@Observacion varchar(500)
)
AS

--declare
--@IdEmpresa int,
--@IdNomina numeric,
--@IdNominaTipo numeric,
--@IdPEriodo numeric,
--@IdUsuario varchar(50),
--@observacion varchar(500)
--set @IdEmpresa =1
--set @IdNomina =1
--set @IdNominaTipo =2
--set @IdPEriodo= 201803
--set @IdUsuario ='admin'
--set @observacion= 'prueba'

BEGIN

declare
@Fi date,
@Ff date,
@IdRubro_calculado varchar(50),
@Dias_trabajados int

----------------------------------------------------------------------------------------------------------------------------------------------
-------------obteniendo fecha del perido------------------- ----------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @Fi= pe_FechaIni, @Ff=pe_FechaFin from ro_periodo where IdEmpresa=@IdEmpresa and IdPeriodo=@IdPEriodo

----------------------------------------------------------------------------------------------------------------------------------------------
-------------preparando la cabecera del rol general-------- ----------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
if((select  COUNT(IdPeriodo) from ro_rol where IdEmpresa=@IdEmpresa and IdPeriodo=@IdPEriodo and IdNominaTipo=@IdNomina and IdNominaTipoLiqui=@IdNominaTipo)>0)
update ro_rol set UsuarioModifica=@IdUsuario, FechaModifica=GETDATE() where IdEmpresa=@IdEmpresa and IdPeriodo=@IdPEriodo and IdNominaTipo=@IdNomina and IdNominaTipoLiqui=@IdNominaTipo
else
insert into ro_rol
(IdEmpresa,		IdNominaTipo,		IdNominaTipoLiqui,		IdPeriodo,			Descripcion,				Observacion,				Cerrado,			FechaIngresa,
UsuarioIngresa,	FechaModifica,		UsuarioModifica,		FechaAnula,			UsuarioAnula,				MotivoAnula,				UsuarioCierre,		FechaCierre,
IdCentroCosto)
values
(@IdEmpresa		,@IdNomina			,@IdNominaTipo			,@IdPEriodo			,@observacion				,@observacion				,'N'				,GETDATE()
,@IdUsuario		,null				,null					,null				,null						,null						,null				,null
,null)

----------------------------------------------------------------------------------------------------------------------------------------------
-------------eliminando detalle--------------------------- ----------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
delete ro_rol_detalle_x_rubro_acumulado  where IdEmpresa=@IdEmpresa and IdPeriodo=@IdPEriodo and IdNominaTipo=@IdNomina and IdNominaTipoLiqui=@IdNominaTipo
delete ro_rol_detalle  where IdEmpresa=@IdEmpresa and IdPeriodo=@IdPEriodo and IdNominaTipo=@IdNomina and IdNominaTipoLiqui=@IdNominaTipo


----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando dias trabajados por empleado-----------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------

select @IdRubro_calculado= IdRubro_dias_trabajados from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros

insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select 

@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,cont.IdEmpleado		,@IdRubro_calculado	,'0' ,case when emp.em_status!='EST_PLQ' THEN	iif(cont.FechaInicio<=@Fi,DATEDIFF(day ,@fi, @Ff), DATEDIFF(day ,cont.FechaInicio, @Ff)) ELSE iif(emp.em_fechaSalida>=@Ff,DATEDIFF(day ,@fi, @Ff), DATEDIFF(day ,emp.em_fechaSalida, @Ff)) end
,1						,'Días trabajados'		, null						, null				,null									,null
FROM            dbo.ro_contrato AS cont INNER JOIN
                dbo.ro_empleado AS emp ON cont.IdEmpresa = emp.IdEmpresa AND cont.IdEmpleado = emp.IdEmpleado
where cont.IdEmpresa=@IdEmpresa 
and cont.IdNomina=@IdNomina
and cont.EstadoContrato='ECT_ACT'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)

----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando sueldo por días trabajados-------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_sueldo from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros

insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select 

@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,cont.IdEmpleado		,@IdRubro_calculado	,'1' ,cont.sueldo/30*( case when emp.em_status!='EST_PLQ' THEN	iif(cont.FechaInicio<=@Fi,DATEDIFF(day ,@Fi,@Ff), DATEDIFF(day ,cont.FechaInicio, @Ff)) ELSE iif(emp.em_fechaSalida>=@Ff,30, DATEDIFF(day ,emp.em_fechaSalida, @Ff)) end)
,1						,'Sueldo base'		, null						, null				,null									,null
FROM            dbo.ro_contrato AS cont INNER JOIN
                dbo.ro_empleado AS emp ON cont.IdEmpresa = emp.IdEmpresa AND cont.IdEmpleado = emp.IdEmpleado
where cont.IdEmpresa=@IdEmpresa 
and cont.IdNomina=@IdNomina
and cont.EstadoContrato='ECT_ACT'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)



----------------------------------------------------------------------------------------------------------------------------------------------
-------------buscando novedades del periodo e insertando al rol detalle-----------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------


insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select 
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,nov.IdEmpleado		,nov.IdRubro		,rub.ru_orden	,sum(nov.Valor)
,1						,rub.ru_descripcion		, null						, null				,null									,emp.IdPuntoCargo
FROM   dbo.ro_empleado AS emp INNER JOIN
dbo.ro_empleado_Novedad AS novc ON emp.IdEmpresa = novc.IdEmpresa AND emp.IdEmpleado = novc.IdEmpleado INNER JOIN
dbo.ro_empleado_novedad_det AS nov ON novc.IdEmpresa = nov.IdEmpresa AND novc.IdNovedad = nov.IdNovedad AND novc.IdEmpleado = nov.IdEmpleado INNER JOIN
dbo.ro_rubro_tipo AS rub ON nov.IdEmpresa = rub.IdEmpresa AND nov.IdRubro = rub.IdRubro
and nov.IdEmpresa=@IdEmpresa
and emp.IdEmpresa=@IdEmpresa
and nov.IdNomina_tipo=@IdNomina
and nov.IdNomina_Tipo_Liq=@IdNominaTipo
and nov.FechaPago between @Fi and @Ff
and nov.Estado='A'
and nov.EstadoCobro='PEN'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)
group by nov.IdEmpresa,nov.IdEmpleado,nov.IdRubro,rub.ru_orden,rub.ru_descripcion, emp.IdPuntoCargo

----------------------------------------------------------------------------------------------------------------------------------------------
-------------buscando cuota de prestamos e insertando al rol detalle-------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,pre.IdEmpleado		,pre.IdRubro		,rub.ru_orden	,pred.TotalCuota
,1						,pred.Observacion_det	, null						, null				,null									,emp.IdPuntoCargo
FROM            dbo.ro_prestamo AS pre INNER JOIN
                         dbo.ro_prestamo_detalle AS pred ON pre.IdEmpresa = pred.IdEmpresa AND pre.IdPrestamo = pred.IdPrestamo INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON pre.IdEmpresa = rub.IdEmpresa AND pre.IdRubro = rub.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON pre.IdEmpresa = emp.IdEmpresa AND pre.IdEmpleado = emp.IdEmpleado
and pre.IdEmpresa=@IdEmpresa
and emp.IdEmpresa=@IdEmpresa
and pred.IdNominaTipoLiqui=@IdNominaTipo
and pred.FechaPago between @Fi and @Ff
and pred.Estado='A'
and pred.EstadoPago='PEN'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)
----------------------------------------------------------------------------------------------------------------------------------------------
-------------buscando rubros fijos e insertando al rol detalle-------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------

insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,emp.IdEmpleado		,rub_fij.IdRubro	,rub.ru_orden	,rub_fij.Valor
,1						,rub.ru_descripcion	,	null						, null				,null									,emp.IdPuntoCargo
FROM            dbo.ro_rubro_tipo AS rub INNER JOIN
                         dbo.ro_empleado_x_ro_rubro AS rub_fij ON rub.IdEmpresa = rub_fij.IdEmpresa AND rub.IdRubro = rub_fij.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON rub_fij.IdEmpresa = emp.IdEmpresa AND rub_fij.IdEmpleado = emp.IdEmpleado
and rub_fij.IdEmpresa=@IdEmpresa
and emp.IdEmpresa=@IdEmpresa
and rub_fij.IdNomina_tipo=@IdNomina
and rub_fij.IdNomina_TipoLiqui=@IdNominaTipo
--and rub_fij.Estado='A'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)

----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando aporte personal------------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_iess_perso from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'101'			,CAST( sum(rol_det.Valor)*0.0945 as numeric(8,2))
,1						,'Aporte personal'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I' and rub.rub_aplica_IESS=1
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo




----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando fondo de reserva----------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_fondo_reserva from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'50'			,CAST( sum(rol_det.Valor)*0.0833 as numeric(8,2))  --CAST( sum(rol_det.Valor)*0.0945 as numeric(8,2))
,1						,'Fondos de reserva'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON rol_det.IdEmpresa = emp.IdEmpresa AND rol_det.IdEmpleado = emp.IdEmpleado
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I' and rub.rub_aplica_IESS=1
and DATEDIFF(day ,emp.em_fechaIngaRol,@Ff)>360
and  not exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='296')
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo

----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando decimo tercer sueldo-------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_DIII from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'52'			,sum(rol_det.Valor)/12
,1						,'Decimo tercer sueldo'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON rol_det.IdEmpresa = emp.IdEmpresa AND rol_det.IdEmpleado = emp.IdEmpleado
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I' and rub.rub_aplica_IESS=1
--and DATEDIFF(day ,emp.em_fechaIngaRol,@Ff)>360
and  not exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='290')
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo


----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando decimo cuarto sueldo-------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_DIV from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,emp.IdEmpleado		,@IdRubro_calculado	,'51'			,(386/360)*( case when emp.em_status!='EST_PLQ' THEN	iif(cont.FechaInicio<=@Fi,DATEDIFF(day ,@Fi,@Ff), DATEDIFF(day ,cont.FechaInicio, @Ff)) ELSE iif(emp.em_fechaSalida>=@Ff,30, DATEDIFF(day ,emp.em_fechaSalida, @Ff)) end)
,1						,'Decimo cuarto sueldo'	,	null						, null				,null									,null
FROM  dbo.ro_empleado emp, ro_contrato cont
where emp.IdEmpresa=cont.IdEmpresa
and emp.IdEmpleado=cont.IdEmpleado
and cont.EstadoContrato='ECT_ACT'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)
and  not exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='289')
group by emp.IdEmpresa,emp.IdEmpleado, emp.em_fechaSalida, cont.FechaInicio, cont.FechaFin, emp.em_status

----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando total ingreso por empleado-------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------

select @IdRubro_calculado= IdRubro_tot_ing from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)


select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'100'			,sum(rol_det.Valor)
,1						,'Total ingresos'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I'
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo





----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando total egreso por empleado--------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------

select @IdRubro_calculado= IdRubro_tot_egr from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'200'			,sum(rol_det.Valor)
,1						,'Total Egreso'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='E'
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo


----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculandoliquido a recibir--------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------

select @IdRubro_calculado= IdRubro_tot_pagar from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)

select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,IdEmpleado		,@IdRubro_calculado	,'1000'			,( [500] - [900])
,1						,'Liquido a recibir'	,	null						, null				,null									,null
FROM (
    SELECT 
        IdEmpresa,IdEmpleado,IdNominaTipo,IdNominaTipoLiqui ,IdPeriodo ,IdRubro, Valor
    FROM ro_rol_detalle
	 where IdEmpresa=@IdEmpresa
	 and IdNominaTipo=@IdNomina
	 and IdNominaTipoLiqui=@IdNominaTipo
	 and IdPeriodo=@IdPEriodo
) as s
PIVOT
(
   max([Valor])
    FOR [IdRubro] IN ([500],[900])
)AS pvt



----------------------------------------------------------------------------------------------------------------------------------------------
-------------INSERTANDO PROVISIONES----------------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando fondo de reserva----------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_prov_FR from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'60'			,sum(rol_det.Valor)*0.0833
,0						,'Fondos de reserva'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON rol_det.IdEmpresa = emp.IdEmpresa AND rol_det.IdEmpleado = emp.IdEmpleado
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I' and rub.rub_aplica_IESS=1
and DATEDIFF(day ,emp.em_fechaIngaRol,@Ff)>360
and  not exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='296')
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo

----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando decimo tercer sueldo-------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_prov_DIII from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,rol_det.IdEmpleado		,@IdRubro_calculado	,'61'			,sum(rol_det.Valor)/12
,0						,'Decimo tercer sueldo'	,	null						, null				,null									,null
FROM            dbo.ro_rol_detalle AS rol_det INNER JOIN
                         dbo.ro_rubro_tipo AS rub ON rol_det.IdEmpresa = rub.IdEmpresa AND rol_det.IdRubro = rub.IdRubro INNER JOIN
                         dbo.ro_empleado AS emp ON rol_det.IdEmpresa = emp.IdEmpresa AND rol_det.IdEmpleado = emp.IdEmpleado
where rol_det.IdEmpresa=@IdEmpresa
and rol_det.IdNominaTipo=@IdNomina
and rol_det.IdNominaTipoLiqui=@IdNominaTipo
and rol_det.IdPeriodo=@IdPEriodo
and rub.ru_tipo='I' and rub.rub_aplica_IESS=1
--and DATEDIFF(day ,emp.em_fechaIngaRol,@Ff)>360
and   exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='290')
group by rol_det.IdEmpresa,rol_det.IdEmpleado,rol_det.IdNominaTipo,rol_det.IdNominaTipoLiqui,rol_det.IdPeriodo


----------------------------------------------------------------------------------------------------------------------------------------------
-------------calculando decimo cuarto sueldo-------------------------------------------------------------------------------------------------<
----------------------------------------------------------------------------------------------------------------------------------------------
select @IdRubro_calculado= IdRubro_prov_DIV from ro_rubros_calculados where IdEmpresa=@IdEmpresa-- obteniendo el idrubro desde parametros
insert into ro_rol_detalle
(IdEmpresa,				IdNominaTipo,			IdNominaTipoLiqui,			IdPeriodo,			IdEmpleado,			IdRubro,			Orden,			Valor
,rub_visible_reporte,	Observacion,			TipoMovimiento,				IdCentroCosto		,IdCentroCosto_sub_centro_costo			,IdPunto_cargo)
select
@IdEmpresa				,@IdNomina				,@IdNominaTipo				,@IdPEriodo			,emp.IdEmpleado		,@IdRubro_calculado	,'51'			,(386/360)*( case when emp.em_status!='EST_PLQ' THEN	iif(cont.FechaInicio<=@Fi,DATEDIFF(day ,@Fi,@Ff), DATEDIFF(day ,cont.FechaInicio, @Ff)) ELSE iif(emp.em_fechaSalida>=@Ff,30, DATEDIFF(day ,emp.em_fechaSalida, @Ff)) end)
,0						,'Decimo cuarto sueldo'	,	null						, null				,null									,null
FROM  dbo.ro_empleado emp, ro_contrato cont
where emp.IdEmpresa=cont.IdEmpresa
and emp.IdEmpleado=cont.IdEmpleado
and cont.EstadoContrato='ECT_ACT'
and (emp.em_status='EST_ACT' or emp.em_fechaSalida between @Fi and @Ff)
and   exists(select acum.IdEmpleado from ro_empleado_x_rubro_acumulado acum 
where acum.IdEmpresa= @IdEmpresa
and acum.IdEmpresa=emp.IdEmpresa
and acum.IdEmpleado=emp.IdEmpleado
and acum.IdRubro='289')
group by emp.IdEmpresa,emp.IdEmpleado, emp.em_fechaSalida, cont.FechaInicio, cont.FechaFin, emp.em_status


END