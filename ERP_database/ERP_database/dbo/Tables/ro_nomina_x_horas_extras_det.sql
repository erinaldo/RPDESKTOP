﻿CREATE TABLE [dbo].[ro_nomina_x_horas_extras_det] (
    [IdEmpresa]                 INT          NOT NULL,
    [IdHorasExtras]             INT          NOT NULL,
    [IdEmpleado]                NUMERIC (18) NOT NULL,
    [IdCalendario]              INT          NOT NULL,
    [IdTurno]                   NUMERIC (18) NOT NULL,
    [IdHorario]                 NUMERIC (18) NOT NULL,
    [FechaRegistro]             DATETIME     NOT NULL,
    [time_entrada1]             TIME (0)     NULL,
    [time_entrada2]             TIME (0)     NULL,
    [time_salida1]              TIME (0)     NULL,
    [time_salida2]              TIME (0)     NULL,
    [hora_extra25]              FLOAT (53)   NOT NULL,
    [hora_extra50]              FLOAT (53)   NOT NULL,
    [hora_extra100]             FLOAT (53)   NOT NULL,
    [Valor25]                   FLOAT (53)   NOT NULL,
    [Valor50]                   FLOAT (53)   NOT NULL,
    [Valor100]                  FLOAT (53)   NOT NULL,
    [Sueldo_base]               FLOAT (53)   NOT NULL,
    [hora_atraso]               FLOAT (53)   NOT NULL,
    [hora_temprano]             FLOAT (53)   NOT NULL,
    [hora_trabajada]            FLOAT (53)   NOT NULL,
    [es_HorasExtrasAutorizadas] BIT          NOT NULL,
    CONSTRAINT [PK_ro_nomina_x_horas_extras_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdHorasExtras] ASC, [IdEmpleado] ASC, [IdCalendario] ASC),
    CONSTRAINT [FK_ro_nomina_x_horas_extras_det_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_nomina_x_horas_extras_det_ro_horario] FOREIGN KEY ([IdEmpresa], [IdHorario]) REFERENCES [dbo].[ro_horario] ([IdEmpresa], [IdHorario]),
    CONSTRAINT [FK_ro_nomina_x_horas_extras_det_ro_nomina_x_horas_extras] FOREIGN KEY ([IdEmpresa], [IdHorasExtras]) REFERENCES [dbo].[ro_nomina_x_horas_extras] ([IdEmpresa], [IdHorasExtras]),
    CONSTRAINT [FK_ro_nomina_x_horas_extras_det_ro_turno] FOREIGN KEY ([IdEmpresa], [IdTurno]) REFERENCES [dbo].[ro_turno] ([IdEmpresa], [IdTurno]),
    CONSTRAINT [FK_ro_nomina_x_horas_extras_det_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);





