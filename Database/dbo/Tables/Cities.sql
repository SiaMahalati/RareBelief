CREATE TABLE [dbo].[Cities]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[Name]	NVARCHAR(255) NULL,
	[DateCreated]   DATETIME       NOT NULL,
	[StateId]		INT			   NULL,
	CONSTRAINT [PK_dbo.Cities] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.City_dbo.States_StateId] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States] ([Id])
)