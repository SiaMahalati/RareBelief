CREATE TABLE [dbo].[NodeCities]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[CityId]		INT			   NULL,
	[NodeId]		INT			   NULL,
	CONSTRAINT [PK_dbo.NodeCities] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.NodeCities_dbo.Cities_CityId] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([Id]),
	CONSTRAINT [FK_dbo.NodeCities_dbo.Nodes_NodeId] FOREIGN KEY ([NodeId]) REFERENCES [dbo].[Nodes] ([Id])
)
