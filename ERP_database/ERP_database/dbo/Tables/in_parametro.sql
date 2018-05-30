﻿CREATE TABLE [dbo].[in_parametro] (
    [IdEmpresa]                                         INT          NOT NULL,
    [IdMovi_inven_tipo_egresoBodegaOrigen]              INT          NULL,
    [IdMovi_inven_tipo_ingresoBodegaDestino]            INT          NULL,
    [Maneja_Stock_Negativo]                             VARCHAR (1)  NULL,
    [Usuario_Escoge_Motivo]                             VARCHAR (1)  NULL,
    [IdMovi_inven_tipo_egresoAjuste]                    INT          NULL,
    [IdMovi_inven_tipo_ingresoAjuste]                   INT          NULL,
    [IdCtaCble_Inven]                                   VARCHAR (20) NULL,
    [IdCtaCble_CostoInven]                              VARCHAR (20) NULL,
    [IdTipoCbte_CostoInven]                             INT          NULL,
    [IdTipoCbte_CostoInven_Reverso]                     INT          NULL,
    [IdMovi_Inven_tipo_x_anu_Ing]                       INT          NULL,
    [IdMovi_Inven_tipo_x_anu_Egr]                       INT          NULL,
    [IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa]            INT          NULL,
    [IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa]            INT          NULL,
    [ApruebaAjusteFisicoAuto]                           VARCHAR (1)  NULL,
    [IdEstadoAproba_x_Ing]                              VARCHAR (15) NULL,
    [IdEstadoAproba_x_Egr]                              VARCHAR (15) NULL,
    [IdMovi_Inven_tipo_x_Dev_Inv_x_Ing]                 INT          NULL,
    [IdMovi_Inven_tipo_x_Dev_Inv_x_Erg]                 INT          NULL,
    [P_Fecha_para_contabilizacion_ingr_egr]             VARCHAR (20) NULL,
    [P_se_valida_parametrizacion_x_producto]            BIT          NULL,
    [P_Al_Conta_CtaInven_Buscar_en]                     VARCHAR (15) NULL,
    [P_Al_Conta_CtaCosto_Buscar_en]                     VARCHAR (15) NULL,
    [P_IdCtaCble_transitoria_transf_inven]              VARCHAR (20) NULL,
    [P_IdProductoTipo_para_lote_0]                      INT          NULL,
    [P_se_crea_lote_0_al_crear_producto_matriz]         BIT          NULL,
    [IdMovi_inven_tipo_x_distribucion_ing]              INT          NULL,
    [IdMovi_inven_tipo_x_distribucion_egr]              INT          NULL,
    [P_IdMovi_inven_tipo_default_ing]                   INT          NULL,
    [P_IdMovi_inven_tipo_default_egr]                   INT          NULL,
    [P_IdMovi_inven_tipo_ingreso_x_compra]              INT          NULL,
    [P_Dias_menores_alerta_desde_fecha_actual_rojo]     INT          NULL,
    [P_Dias_menores_alerta_desde_fecha_actual_amarillo] INT          NULL,
    CONSTRAINT [PK_in_parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_in_parametro_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble_Inven]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_in_parametro_ct_plancta1] FOREIGN KEY ([IdEmpresa], [IdCtaCble_CostoInven]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_in_parametro_ct_plancta2] FOREIGN KEY ([IdEmpresa], [P_IdCtaCble_transitoria_transf_inven]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_in_parametro_in_Catalogo] FOREIGN KEY ([P_Al_Conta_CtaInven_Buscar_en]) REFERENCES [dbo].[in_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_in_parametro_in_Catalogo1] FOREIGN KEY ([P_Al_Conta_CtaCosto_Buscar_en]) REFERENCES [dbo].[in_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_in_parametro_in_Ing_Egr_Inven_estado_apro] FOREIGN KEY ([IdEstadoAproba_x_Ing]) REFERENCES [dbo].[in_Ing_Egr_Inven_estado_apro] ([IdEstadoAproba]),
    CONSTRAINT [FK_in_parametro_in_Ing_Egr_Inven_estado_apro1] FOREIGN KEY ([IdEstadoAproba_x_Egr]) REFERENCES [dbo].[in_Ing_Egr_Inven_estado_apro] ([IdEstadoAproba]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo] FOREIGN KEY ([IdEmpresa], [IdMovi_Inven_tipo_x_anu_Ing]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo1] FOREIGN KEY ([IdEmpresa], [IdMovi_Inven_tipo_x_anu_Egr]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo10] FOREIGN KEY ([IdEmpresa], [P_IdMovi_inven_tipo_default_ing]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo11] FOREIGN KEY ([IdEmpresa], [P_IdMovi_inven_tipo_default_egr]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo12] FOREIGN KEY ([IdEmpresa], [P_IdMovi_inven_tipo_ingreso_x_compra]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo2] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_egresoBodegaOrigen]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo3] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_egresoBodegaOrigen]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo4] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_ingresoAjuste]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo5] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_egresoAjuste]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo6] FOREIGN KEY ([IdEmpresa], [IdMovi_Inven_tipo_x_Dev_Inv_x_Ing]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo7] FOREIGN KEY ([IdEmpresa], [IdMovi_Inven_tipo_x_Dev_Inv_x_Erg]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo8] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_x_distribucion_ing]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_movi_inven_tipo9] FOREIGN KEY ([IdEmpresa], [IdMovi_inven_tipo_x_distribucion_egr]) REFERENCES [dbo].[in_movi_inven_tipo] ([IdEmpresa], [IdMovi_inven_tipo]),
    CONSTRAINT [FK_in_parametro_in_ProductoTipo] FOREIGN KEY ([IdEmpresa], [P_IdProductoTipo_para_lote_0]) REFERENCES [dbo].[in_ProductoTipo] ([IdEmpresa], [IdProductoTipo])
);











