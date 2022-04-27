IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210927145356_InitialCreate')
BEGIN
    CREATE TABLE [Persona1] (
        [Id] int NOT NULL IDENTITY,
        [Nombres] varchar(200) NOT NULL,
        [Apellidos] varchar(200) NOT NULL,
        [TipoDocumento] int NOT NULL,
        [NoDocumento] varchar(50) NOT NULL,
        [FechaNacimiento] datetime2 NOT NULL,
        [NoContacto] varchar(50) NOT NULL,
        [Email] varchar(300) NOT NULL,
        [Direccion] varchar(300) NOT NULL,
        [Activo] bit NOT NULL,
        [Eliminado] bit NOT NULL,
        [UsuarioRegistra] int NULL,
        [UsuarioElimina] int NULL,
        [UsuarioUltimaModificacion] int NULL,
        [FechaRegistro] datetime2 NOT NULL,
        [FechaEliminado] datetime2 NULL,
        [FechaUltimaModificacion] datetime2 NULL,
        CONSTRAINT [PK_Persona1] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210927145356_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210927145356_InitialCreate', N'5.0.10');
END;
GO

COMMIT;
GO

