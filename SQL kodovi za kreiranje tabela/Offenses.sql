CREATE TABLE [dbo].[Offenses] (
    [Date]        DATETIME NOT NULL,
    [VehicleId]   INT      NOT NULL,
    [PolicemanId] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Date] ASC, [VehicleId] ASC, [PolicemanId] ASC),
    CONSTRAINT [FK_Vehicle_Offense] FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[Vehicles] ([Id]),
    CONSTRAINT [FK_Policeman_Offense] FOREIGN KEY ([PolicemanId]) REFERENCES [dbo].[Policemen] ([Id])
);