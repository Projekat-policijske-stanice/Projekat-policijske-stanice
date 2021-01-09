CREATE TABLE [dbo].[Vehicles] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)   NOT NULL,
    [Type]        NVARCHAR (50)   NOT NULL,
    [Consumption] DECIMAL (18, 2) NOT NULL,
    [Correctness] NVARCHAR (50)   NOT NULL,
    [Condition]   NVARCHAR (20)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
