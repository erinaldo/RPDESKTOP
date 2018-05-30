﻿CREATE TABLE [dbo].[in_movi_inve] (
    [IdEmpresa]                      INT            NOT NULL,
    [IdSucursal]                     INT            NOT NULL,
    [IdBodega]                       INT            NOT NULL,
    [IdMovi_inven_tipo]              INT            NOT NULL,
    [IdNumMovi]                      NUMERIC (18)   NOT NULL,
    [CodMoviInven]                   VARCHAR (25)   NULL,
    [cm_tipo]                        CHAR (1)       NOT NULL,
    [cm_observacion]                 VARCHAR (1000) NULL,
    [cm_fecha]                       DATETIME       NOT NULL,
    [IdCbteCble_Tipo]                INT            NULL,
    [IdCbteCble]                     NUMERIC (18)   NULL,
    [IdCtaCble]                      VARCHAR (20)   NULL,
    [cm_anio]                        INT            NULL,
    [cm_mes]                         INT            NULL,
    [IdUsuario]                      VARCHAR (20)   NULL,
    [Fecha_Transac]                  DATETIME       NULL,
    [IdUsuarioUltModi]               VARCHAR (20)   NULL,
    [Fecha_UltMod]                   DATETIME       NULL,
    [IdusuarioUltAnu]                VARCHAR (20)   NULL,
    [Fecha_UltAnu]                   DATETIME       NULL,
    [nom_pc]                         VARCHAR (50)   NULL,
    [ip]                             VARCHAR (30)   NULL,
    [Estado]                         CHAR (1)       NOT NULL,
    [IdCentroCosto]                  VARCHAR (20)   NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20)   NULL,
    [IdProvedor]                     NUMERIC (18)   NULL,
    [NumDocumentoRelacionado]        VARCHAR (25)   NULL,
    [NumFactura]                     VARCHAR (25)   NULL,
    [IdEmpresa_x_Anu]                INT            NULL,
    [IdSucursal_x_Anu]               INT            NULL,
    [IdBodega_x_Anu]                 INT            NULL,
    [IdMovi_inven_tipo_x_Anu]        INT            NULL,
    [IdNumMovi_x_Anu]                NUMERIC (18)   NULL,
    [MotivoAnulacion]                VARCHAR (100)  NULL,
    [IdEstadoDespacho_cat]           VARCHAR (15)   NULL,
    [Fecha_despacho]                 DATETIME       NULL,
    [IdMotivo_Inv]                   INT            NULL,
    CONSTRAINT [PK_in_movi_inve] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC, [IdBodega] ASC, [IdMovi_inven_tipo] ASC, [IdNumMovi] ASC),
    CONSTRAINT [FK_in_movi_inve_ct_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto]) REFERENCES [dbo].[ct_centro_costo] ([IdEmpresa], [IdCentroCosto]),
    CONSTRAINT [FK_in_movi_inve_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo]),
    CONSTRAINT [FK_in_movi_inve_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_in_movi_inve_in_Catalogo] FOREIGN KEY ([IdEstadoDespacho_cat]) REFERENCES [dbo].[in_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_in_movi_inve_in_Motivo_Inven] FOREIGN KEY ([IdEmpresa], [IdMotivo_Inv]) REFERENCES [dbo].[in_Motivo_Inven] ([IdEmpresa], [IdMotivo_Inv]),
    CONSTRAINT [FK_in_movi_inve_in_movi_inve] FOREIGN KEY ([IdEmpresa_x_Anu], [IdSucursal_x_Anu], [IdBodega_x_Anu], [IdMovi_inven_tipo_x_Anu], [IdNumMovi_x_Anu]) REFERENCES [dbo].[in_movi_inve] ([IdEmpresa], [IdSucursal], [IdBodega], [IdMovi_inven_tipo], [IdNumMovi]),
    CONSTRAINT [FK_in_movi_inve_in_movi_inven_tipo] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_movi_inve_tb_bodega] FOREIGN KEY ([IdEmpresa], [IdSucursal], [IdBodega]) REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega]),
    CONSTRAINT [FK_in_movi_inve_tb_mes] FOREIGN KEY ([cm_mes]) REFERENCES [dbo].[tb_mes] ([idMes])
);




