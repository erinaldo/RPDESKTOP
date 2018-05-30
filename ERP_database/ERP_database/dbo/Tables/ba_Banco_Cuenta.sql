﻿CREATE TABLE [dbo].[ba_Banco_Cuenta] (
    [IdEmpresa]                INT             NOT NULL,
    [IdBanco]                  INT             NOT NULL,
    [ba_descripcion]           VARCHAR (150)   NOT NULL,
    [ba_Tipo]                  VARCHAR (50)    NOT NULL,
    [ba_Num_Cuenta]            VARCHAR (50)    NOT NULL,
    [ba_num_digito_cheq]       INT             NOT NULL,
    [IdCtaCble]                VARCHAR (20)    NOT NULL,
    [IdUsuario]                VARCHAR (50)    NULL,
    [Fecha_Transac]            DATETIME        NULL,
    [IdUsuarioUltMod]          VARCHAR (50)    NULL,
    [Fecha_UltMod]             DATETIME        NULL,
    [nom_pc]                   VARCHAR (50)    NULL,
    [ip]                       VARCHAR (50)    NULL,
    [Estado]                   CHAR (1)        NOT NULL,
    [IdUsuarioUltAnu]          VARCHAR (20)    NULL,
    [Fecha_UltAnu]             DATETIME        NULL,
    [MotiAnula]                VARCHAR (200)   NULL,
    [Reporte]                  VARBINARY (MAX) NULL,
    [ReporteSolo_Cheque]       VARBINARY (MAX) NULL,
    [MostrarVistaPreviaCheque] BIT             NULL,
    [Imprimir_Solo_el_cheque]  BIT             NULL,
    [IdBanco_Financiero]       INT             NULL,
    CONSTRAINT [PK_ba_Banco_Cuenta] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdBanco] ASC),
    CONSTRAINT [FK_ba_Banco_Cuenta_ct_plancta] FOREIGN KEY ([IdEmpresa], [IdCtaCble]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_ba_Banco_Cuenta_tb_banco] FOREIGN KEY ([IdBanco_Financiero]) REFERENCES [dbo].[tb_banco] ([IdBanco]),
    CONSTRAINT [FK_ba_Banco_Cuenta_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);

