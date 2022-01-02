CREATE TABLE [Gen].[Unit]
(
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [UnitCode]    NVARCHAR (50)  NOT NULL,
    [UnitName]    NVARCHAR (100) NULL,
    [Description] NVARCHAR (200) NULL,
    [IsActive]    BIT            CONSTRAINT [DF_Gen_Unit_IsActive] DEFAULT ((1)) NULL,
    [CreatedOn]   DATETIME       NULL,
    [UpdatedOn]   DATETIME       NULL,
    CONSTRAINT [PK_Gen_Unit] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UC_Gen_UnitCode] UNIQUE NONCLUSTERED ([UnitCode] ASC)
);