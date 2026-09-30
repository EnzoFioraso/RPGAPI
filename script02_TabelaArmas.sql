BEGIN TRANSACTION;
CREATE TABLE [TB_ARMAS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_ARMAS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] ON;
INSERT INTO [TB_ARMAS] ([Id], [Dano], [Nome])
VALUES (1, 20, 'Ak47'),
(2, 15, 'Pistola'),
(3, 17, 'Desert'),
(4, 21, 'Doze'),
(5, 11, 'Espada'),
(6, 9, 'Arco'),
(7, 1, 'Escudo');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260924003515_MigracaoArmas', N'10.0.12');

COMMIT;
GO

