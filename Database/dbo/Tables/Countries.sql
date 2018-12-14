CREATE TABLE [dbo].[Countries]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[Name]	NVARCHAR(255) NULL,
	[DateCreated]   DATETIME       NOT NULL,
	CONSTRAINT [PK_dbo.Countries] PRIMARY KEY CLUSTERED ([Id] ASC)
)
