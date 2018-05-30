﻿CREATE TABLE [dbo].[cp_orden_pago_con_cancelacion_data] (
    [IdUsuario]                 VARCHAR (20)  NOT NULL,
    [IdEmpresa]                 INT           NOT NULL,
    [IdTipo_op]                 VARCHAR (20)  NOT NULL,
    [Referencia]                VARCHAR (523) NULL,
    [Referencia2]               VARCHAR (34)  NULL,
    [IdOrdenPago]               NUMERIC (18)  NOT NULL,
    [Secuencia_OP]              INT           NOT NULL,
    [IdTipoPersona]             VARCHAR (20)  NULL,
    [IdPersona]                 NUMERIC (18)  NOT NULL,
    [IdEntidad]                 NUMERIC (18)  NULL,
    [Fecha_OP]                  DATETIME      NOT NULL,
    [Fecha_Fa_Prov]             DATETIME      NOT NULL,
    [Fecha_Venc_Fac_Prov]       DATETIME      NOT NULL,
    [Observacion]               VARCHAR (500) NOT NULL,
    [Nom_Beneficiario]          VARCHAR (200) NULL,
    [Girar_Cheque_a]            VARCHAR (200) NULL,
    [Valor_a_pagar]             FLOAT (53)    NOT NULL,
    [Valor_estimado_a_pagar_OP] FLOAT (53)    NOT NULL,
    [Total_cancelado_OP]        FLOAT (53)    NOT NULL,
    [Saldo_x_Pagar_OP]          FLOAT (53)    NOT NULL,
    [IdEstadoAprobacion]        VARCHAR (10)  NOT NULL,
    [IdFormaPago]               VARCHAR (20)  NOT NULL,
    [Fecha_Pago]                DATE          NULL,
    [IdCtaCble]                 VARCHAR (20)  NULL,
    [IdCentroCosto]             VARCHAR (20)  NULL,
    [IdSubCentro_Costo]         VARCHAR (20)  NULL,
    [Cbte_cxp]                  NUMERIC (18)  NULL,
    [Estado]                    VARCHAR (2)   NOT NULL,
    [Nom_Beneficiario_2]        VARCHAR (266) NULL,
    [IdEmpresa_cxp]             INT           NULL,
    [IdTipoCbte_cxp]            INT           NULL,
    [IdCbteCble_cxp]            NUMERIC (18)  NULL,
    [IdBanco]                   INT           NULL,
    CONSTRAINT [PK_cp_orden_pago_con_cancelacion_data] PRIMARY KEY CLUSTERED ([IdUsuario] ASC, [IdEmpresa] ASC, [IdOrdenPago] ASC, [Secuencia_OP] ASC)
);

