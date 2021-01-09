CREATE TABLE [dbo].[Policemen] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (30) NOT NULL,
    [Surname] NVARCHAR (50) NOT NULL,
    [JMBG]    NVARCHAR (13) NOT NULL,
    [Shift]   NVARCHAR (20) NOT NULL,
    [Status]  NVARCHAR (20) NOT NULL,
    [Gender]  NVARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);