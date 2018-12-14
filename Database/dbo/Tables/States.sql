CREATE TABLE [dbo].[States]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[Name]	NVARCHAR(255) NULL,
	[DateCreated]   DATETIME       NOT NULL,
	[CountryId]		INT			   NULL,
	CONSTRAINT [PK_dbo.States] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.State_dbo.Countries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([Id])
)
