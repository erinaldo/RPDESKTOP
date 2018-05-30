﻿CREATE TABLE [dbo].[Af_Activo_fijo] (
    [IdEmpresa]                INT            NOT NULL,
    [IdActivoFijo]             INT            NOT NULL,
    [CodActivoFijo]            VARCHAR (50)   NULL,
    [Af_Nombre]                VARCHAR (500)  NOT NULL,
    [IdActivoFijoTipo]         INT            NULL,
    [IdCategoriaAF]            INT            NULL,
    [IdSucursal]               INT            NULL,
    [IdCatalogo_Marca]         VARCHAR (35)   NULL,
    [IdCatalogo_Modelo]        VARCHAR (35)   NULL,
    [Af_NumSerie]              VARCHAR (50)   NULL,
    [IdCatalogo_Color]         VARCHAR (35)   NULL,
    [IdTipoCatalogo_Ubicacion] VARCHAR (35)   NULL,
    [Af_fecha_compra]          DATETIME       NOT NULL,
    [Af_fecha_ini_depre]       DATETIME       NOT NULL,
    [Af_fecha_fin_depre]       DATETIME       NOT NULL,
    [Af_Costo_historico]       FLOAT (53)     NOT NULL,
    [Af_costo_compra]          FLOAT (53)     NOT NULL,
    [Af_Depreciacion_acum]     FLOAT (53)     NOT NULL,
    [Af_Vida_Util]             INT            NOT NULL,
    [Af_Meses_depreciar]       INT            NOT NULL,
    [Af_porcentaje_deprec]     FLOAT (53)     NOT NULL,
    [Af_observacion]           VARCHAR (1000) NULL,
    [Af_NumPlaca]              VARCHAR (50)   NULL,
    [Af_Anio_fabrica]          INT            NULL,
    [Estado]                   CHAR (1)       NOT NULL,
    [MotiAnula]                VARCHAR (100)  NULL,
    [Af_foto]                  IMAGE          NULL,
    [Af_DescripcionCorta]      VARCHAR (500)   NULL,
    [Af_Codigo_Barra]          VARCHAR (50)   NULL,
    [Af_DescripcionTecnica]    VARCHAR (1000)  NULL,
    [Estado_Proceso]           VARCHAR (35)   NULL,
    [Af_ValorSalvamento]       FLOAT (53)     NULL,
    [Af_ValorResidual]         FLOAT (53)     NULL,
    [IdUsuario]                VARCHAR (20)   NULL,
    [Fecha_Transac]            DATETIME       NULL,
    [IdUsuarioUltMod]          VARCHAR (20)   NULL,
    [Fecha_UltMod]             DATETIME       NULL,
    [IdUsuarioUltAnu]          VARCHAR (20)   NULL,
    [Fecha_UltAnu]             DATETIME       NULL,
    [Af_NumSerie_Motor]        VARCHAR (50)   NULL,
    [Af_NumSerie_Chasis]       VARCHAR (50)   NULL,
    CONSTRAINT [PK_Af_Activo_fijo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdActivoFijo] ASC),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Activo_fijo_Categoria] FOREIGN KEY ([IdEmpresa], [IdCategoriaAF]) REFERENCES [dbo].[Af_Activo_fijo_Categoria] ([IdEmpresa], [IdCategoriaAF]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Activo_fijo_tipo] FOREIGN KEY ([IdEmpresa], [IdActivoFijoTipo]) REFERENCES [dbo].[Af_Activo_fijo_tipo] ([IdEmpresa], [IdActivoFijoTipo]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Catalogo] FOREIGN KEY ([IdTipoCatalogo_Ubicacion]) REFERENCES [dbo].[Af_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Catalogo1] FOREIGN KEY ([IdCatalogo_Marca]) REFERENCES [dbo].[Af_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Catalogo2] FOREIGN KEY ([IdCatalogo_Modelo]) REFERENCES [dbo].[Af_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Catalogo3] FOREIGN KEY ([IdCatalogo_Color]) REFERENCES [dbo].[Af_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Af_Activo_fijo_Af_Catalogo4] FOREIGN KEY ([Estado_Proceso]) REFERENCES [dbo].[Af_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_Af_Activo_fijo_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa]),
    CONSTRAINT [FK_Af_Activo_fijo_tb_sucursal] FOREIGN KEY ([IdEmpresa], [IdSucursal]) REFERENCES [dbo].[tb_sucursal] ([IdEmpresa], [IdSucursal])
);


