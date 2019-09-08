CREATE TABLE [dbo].[Exercises] (
    [Id]              UNIQUEIDENTIFIER NOT NULL,
    [Name]            NVARCHAR (MAX)   NULL,
    [Description]     NVARCHAR (MAX)   NULL,
    [VideoUrl]        NVARCHAR (MAX)   NULL,
    [MusclesInvolved] NVARCHAR (MAX)   NULL,
    [Equipment]       NVARCHAR (MAX)   NULL,
    [ExerciseId]      UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Exercises] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Exercises_Exercises_ExerciseId] FOREIGN KEY ([ExerciseId]) REFERENCES [dbo].[Exercises] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Exercises_ExerciseId]
    ON [dbo].[Exercises]([ExerciseId] ASC);

