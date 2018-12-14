CREATE TABLE [dbo].[NodeCountries]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[CountryId]		INT			   NULL,
	[NodeId]		INT			   NULL,
	CONSTRAINT [PK_dbo.NodeCountries] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.NodeCountries_dbo.Countries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([Id]),
	CONSTRAINT [FK_dbo.NodeCountries_dbo.Nodes_NodeId] FOREIGN KEY ([NodeId]) REFERENCES [dbo].[Nodes] ([Id])
)
