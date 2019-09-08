CREATE TABLE [dbo].[MemberProfile] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [Birthdate]           DATETIME2 (7)  NOT NULL,
    [Gender]              INT            NOT NULL,
    [Bio]                 NVARCHAR (MAX) NULL,
    [WeightInKilograms]   INT            NOT NULL,
    [HeightInCentimeters] INT            NOT NULL,
    CONSTRAINT [PK_MemberProfile] PRIMARY KEY CLUSTERED ([Id] ASC)
);

