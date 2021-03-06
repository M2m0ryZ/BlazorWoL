IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Host] (
    [Id] int NOT NULL IDENTITY,
    [Hostname] nvarchar(255) NULL,
    [Caption] nvarchar(255) NOT NULL,
    [MacAddress] varbinary(6) NOT NULL,
    CONSTRAINT [PK_Host] PRIMARY KEY ([Id])
);

GO

CREATE UNIQUE INDEX [IX_Host_Hostname] ON [Host] ([Hostname]) WHERE [Hostname] IS NOT NULL;

GO

CREATE UNIQUE INDEX [IX_Host_MacAddress] ON [Host] ([MacAddress]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191211184319_CreateInitialSchema', N'3.1.0');

GO
