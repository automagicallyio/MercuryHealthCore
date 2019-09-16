CREATE TABLE [dbo].[FoodLogEntries] (
    [Id]                   INT             IDENTITY (1, 1) NOT NULL,
    [MemberProfileId]      INT             NULL,
    [Description]          NVARCHAR (MAX)  NULL,
    [Quantity]             REAL            NOT NULL,
    [MealTime]             DATETIME2 (7)   NOT NULL,
    [Tags]                 NVARCHAR (MAX)  NULL,
    [Calories]             INT             NOT NULL,
    [ProteinInGrams]       DECIMAL (18, 2) NOT NULL,
    [FatInGrams]           DECIMAL (18, 2) NOT NULL,
    [CarbohydratesInGrams] DECIMAL (18, 2) NOT NULL,
    [SodiumInGrams]        DECIMAL (18, 2) NOT NULL,
    [Color] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_FoodLogEntries] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FoodLogEntries_MemberProfile_MemberProfileId] FOREIGN KEY ([MemberProfileId]) REFERENCES [dbo].[MemberProfile] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FoodLogEntries_MemberProfileId]
    ON [dbo].[FoodLogEntries]([MemberProfileId] ASC);

