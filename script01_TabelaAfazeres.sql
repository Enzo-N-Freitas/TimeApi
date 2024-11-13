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
CREATE TABLE [TB_AFAZERES] (
    [Id] int NOT NULL IDENTITY,
    [NomeAfazer] varchar(200) NOT NULL,
    [Descricao] varchar(200) NOT NULL,
    [DataRegistro] datetime2 NULL,
    [DataAfazer] datetime2 NULL,
    [TipodeAfazer] int NOT NULL,
    CONSTRAINT [PK_TB_AFAZERES] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAfazer', N'DataRegistro', N'Descricao', N'NomeAfazer', N'TipodeAfazer') AND [object_id] = OBJECT_ID(N'[TB_AFAZERES]'))
    SET IDENTITY_INSERT [TB_AFAZERES] ON;
INSERT INTO [TB_AFAZERES] ([Id], [DataAfazer], [DataRegistro], [Descricao], [NomeAfazer], [TipodeAfazer])
VALUES (1, NULL, NULL, 'Varrer o chão, lavar o banheiro e tirar pó das estantes', 'Limpar a Casa', 1),
(2, NULL, NULL, 'Terminar a apresentação para a equipe da empresa', 'Terminar Apresentação', 3),
(3, NULL, NULL, 'Finalizar a API da aula de DS e entregar no prazo', 'Terminar a API', 2);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAfazer', N'DataRegistro', N'Descricao', N'NomeAfazer', N'TipodeAfazer') AND [object_id] = OBJECT_ID(N'[TB_AFAZERES]'))
    SET IDENTITY_INSERT [TB_AFAZERES] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241113232527_InitialCreate', N'9.0.0');

COMMIT;
GO

