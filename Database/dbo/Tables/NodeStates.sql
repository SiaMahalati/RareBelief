CREATE TABLE [dbo].[NodeStates]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[StateId]		INT			   NULL,
	[NodeId]		INT			   NULL,
	CONSTRAINT [PK_dbo.NodeStates] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.NodeStates_dbo.States_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States] ([Id]),
	CONSTRAINT [FK_dbo.NodeStates_dbo.Nodes_NodeId] FOREIGN KEY ([NodeId]) REFERENCES [dbo].[Nodes] ([Id])
)
