USE [PrimerParcial]
GO

/****** Object:  Table [dbo].[PARTIDO]    Script Date: 29/9/2024 21:15:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PARTIDO](
	[ID_PARTIDO] [int] IDENTITY(1,1) NOT NULL,
	[ID_DEPORTE] [int] NOT NULL,
	[EQUIPO_LOCAL] [varchar](50) NOT NULL,
	[EQUIPO_VISITANTE] [varchar](50) NOT NULL,
	[FECHA_REGISTRO] [datetime] NOT NULL,
	[FECHA_PARTIDO] [datetime] NOT NULL,
	[MARCADOR_LOCAL] [int] NOT NULL,
	[MARCADOR_VISITANTE] [int] NOT NULL,
 CONSTRAINT [PK_PARTIDO] PRIMARY KEY CLUSTERED 
(
	[ID_PARTIDO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD  CONSTRAINT [FK_PARTIDO_DEPORTE] FOREIGN KEY([ID_DEPORTE])
REFERENCES [dbo].[DEPORTE] ([ID_DEPORTE])
GO

ALTER TABLE [dbo].[PARTIDO] CHECK CONSTRAINT [FK_PARTIDO_DEPORTE]
GO

