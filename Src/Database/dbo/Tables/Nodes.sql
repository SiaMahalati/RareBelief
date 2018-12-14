CREATE TABLE [dbo].[Nodes]
(
	[Id]	INT IDENTITY (1,1) NOT NULL,
	[Name]	NVARCHAR(255) NULL,
	[DateCreated]   DATETIME       NOT NULL,
	[ParentNodeId]		INT			   NULL,
	CONSTRAINT [PK_dbo.Node] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_dbo.Node_dbo.Node_ParentNodeId] FOREIGN KEY ([ParentNodeId]) REFERENCES [dbo].[Nodes] ([Id])
)
