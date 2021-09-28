USE [CadastroPersonagens]
GO

/****** Object: Table [dbo].[Personagens] Script Date: 27/09/2021 18:29:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personagens] (
    [PersonagemID]   INT            IDENTITY (1, 1) NOT NULL,
    [NomePersonagem] NVARCHAR (MAX) NULL,
    [CenarioID]      NVARCHAR (MAX) NULL
);


