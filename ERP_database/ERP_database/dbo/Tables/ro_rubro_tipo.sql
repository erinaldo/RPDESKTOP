﻿CREATE TABLE [dbo].[ro_rubro_tipo] (
    [IdEmpresa]                  INT           NOT NULL,
    [IdRubro]                    VARCHAR (50)  NOT NULL,
    [rub_codigo]                 VARCHAR (50)  NOT NULL,
    [ru_codRolGen]               VARCHAR (30)  NOT NULL,
    [ru_descripcion]             VARCHAR (50)  NOT NULL,
    [NombreCorto]                VARCHAR (50)  NOT NULL,
    [ru_tipo]                    CHAR (1)      NOT NULL,
    [ru_estado]                  CHAR (1)      NOT NULL,
    [ru_orden]                   INT           NOT NULL,
    [rub_concep]                 BIT           NOT NULL,
    [rub_tipcal]                 INT           NOT NULL,
    [rub_ctacon]                 VARCHAR (20)  NULL,
    [rub_grupo]                  INT           NULL,
    [rub_provision]              BIT           NOT NULL,
    [rub_noafecta]               BIT           NOT NULL,
    [rub_nocontab]               BIT           NOT NULL,
    [rub_guarda_rol]             BIT           NOT NULL,
    [rub_aplica_IESS]            BIT           NOT NULL,
    [rub_Contabiliza_x_empleado] BIT           NOT NULL,
    [rub_Acuerdo_Descuento]      VARCHAR (MAX) NULL,
    [IdUsuario]                  VARCHAR (20)  NULL,
    [Fecha_Transac]              DATETIME      NULL,
    [IdUsuarioUltMod]            VARCHAR (20)  NULL,
    [Fecha_UltMod]               DATETIME      NULL,
    [IdUsuarioUltAnu]            VARCHAR (20)  NULL,
    [Fecha_UltAnu]               DATETIME      NULL,
    [nom_pc]                     VARCHAR (50)  NULL,
    [ip]                         VARCHAR (50)  NULL,
    [rub_acumula]                BIT           NOT NULL,
    CONSTRAINT [PK_ro_rubro_tipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRubro] ASC),
    CONSTRAINT [FK_ro_rubro_tipo_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);








