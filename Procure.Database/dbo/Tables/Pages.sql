CREATE TABLE [dbo].[Pages] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [ParentId] INT             NULL,
    [PageName] NVARCHAR (255)  NULL,
    [PageUrl]  NVARCHAR (1000) NULL,
    [PageIcon] NVARCHAR (255)  NULL,
    [IsRoot]   BIT             NULL,
    [IsParent] BIT             NULL,
    [IsChild]  BIT             NULL,
    [IsActive] BIT             NULL,
    CONSTRAINT [PK_Pages] PRIMARY KEY CLUSTERED ([Id] ASC)
);

