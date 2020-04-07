DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Usuario]') AND [c].[name] = N'Activo');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [dbo].[Usuario] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Usuario] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Usuario] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Usuario] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[TelefonoTipo]') AND [c].[name] = N'Activo');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[TelefonoTipo] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [dbo].[TelefonoTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[TelefonoTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Sucursal]') AND [c].[name] = N'Activo');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Sucursal] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [dbo].[Sucursal] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Sucursal] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Sucursal] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Sucursal] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Rol]') AND [c].[name] = N'Activo');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Rol] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [dbo].[Rol] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Rol] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Rol] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Rol] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Provincia]') AND [c].[name] = N'Activo');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Provincia] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [dbo].[Provincia] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Provincia] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Partido]') AND [c].[name] = N'Activo');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Partido] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [dbo].[Partido] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Partido] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Pais]') AND [c].[name] = N'Activo');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Pais] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [dbo].[Pais] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Pais] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Localidad]') AND [c].[name] = N'Activo');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Localidad] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [dbo].[Localidad] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Localidad] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Empresa]') AND [c].[name] = N'Activo');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Empresa] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [dbo].[Empresa] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Empresa] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Empresa] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Empresa] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[DomicilioTipo]') AND [c].[name] = N'Activo');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[DomicilioTipo] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [dbo].[DomicilioTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[DomicilioTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[DocumentoTipo]') AND [c].[name] = N'Activo');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[DocumentoTipo] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [dbo].[DocumentoTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[DocumentoTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[CondicionPago]') AND [c].[name] = N'Activo');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[CondicionPago] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [dbo].[CondicionPago] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[CondicionPago] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[CondicionIva]') AND [c].[name] = N'Activo');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[CondicionIva] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [dbo].[CondicionIva] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[CondicionIva] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Compania]') AND [c].[name] = N'Activo');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Compania] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [dbo].[Compania] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Compania] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Compania] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Compania] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteTipo]') AND [c].[name] = N'Activo');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteTipo] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [dbo].[ClienteTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ClienteTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteSubTipo]') AND [c].[name] = N'Activo');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteSubTipo] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [dbo].[ClienteSubTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ClienteSubTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteRubro]') AND [c].[name] = N'Activo');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteRubro] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [dbo].[ClienteRubro] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ClienteRubro] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteCategoria]') AND [c].[name] = N'Activo');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteCategoria] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [dbo].[ClienteCategoria] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ClienteCategoria] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Cliente]') AND [c].[name] = N'Activo');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [dbo].[Cliente] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Cliente] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Cliente] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Cliente] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloUnidadMedida]') AND [c].[name] = N'Activo');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloUnidadMedida] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [dbo].[ArticuloUnidadMedida] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloUnidadMedida] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloTipo]') AND [c].[name] = N'Activo');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloTipo] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [dbo].[ArticuloTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloSubTipo]') AND [c].[name] = N'Activo');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloSubTipo] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [dbo].[ArticuloSubTipo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloSubTipo] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloRubro]') AND [c].[name] = N'Activo');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloRubro] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [dbo].[ArticuloRubro] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloRubro] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloMarca]') AND [c].[name] = N'Activo');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloMarca] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [dbo].[ArticuloMarca] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloMarca] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloLinea]') AND [c].[name] = N'Activo');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloLinea] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [dbo].[ArticuloLinea] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloLinea] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloCategoria]') AND [c].[name] = N'Activo');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloCategoria] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [dbo].[ArticuloCategoria] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[ArticuloCategoria] ADD DEFAULT 1 FOR [Activo];

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Articulo]') AND [c].[name] = N'Activo');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Articulo] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [dbo].[Articulo] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[Articulo] ADD DEFAULT 1 FOR [Activo];

GO

ALTER TABLE [dbo].[Articulo] ADD [AudFechaBaja] datetime2 NULL;

GO

ALTER TABLE [dbo].[Articulo] ADD [AudUsuarioBaja] nvarchar(128) NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[AlicuotaIva]') AND [c].[name] = N'Activo');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[AlicuotaIva] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [dbo].[AlicuotaIva] ALTER COLUMN [Activo] bit NOT NULL;
ALTER TABLE [dbo].[AlicuotaIva] ADD DEFAULT 1 FOR [Activo];

GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20191205131032_V03';

GO

ALTER TABLE [dbo].[Articulo] DROP CONSTRAINT [FK_Articulo_AlicuotaIva_IdAlicuotaIvaDiferencial];

GO

DROP INDEX [IX_Articulo_IdAlicuotaIvaDiferencial] ON [dbo].[Articulo];

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[DocumentoTipo]') AND [c].[name] = N'Codigo');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[DocumentoTipo] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [dbo].[DocumentoTipo] DROP COLUMN [Codigo];

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[AlicuotaIva]') AND [c].[name] = N'Alicuota');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[AlicuotaIva] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [dbo].[AlicuotaIva] DROP COLUMN [Alicuota];

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[CondicionPago]') AND [c].[name] = N'Dias');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[CondicionPago] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [dbo].[CondicionPago] ALTER COLUMN [Dias] int NOT NULL;

GO

ALTER TABLE [dbo].[Articulo] ADD [AlicuotaIvaDiferencialId] bigint NULL;

GO

CREATE INDEX [IX_Articulo_AlicuotaIvaDiferencialId] ON [dbo].[Articulo] ([AlicuotaIvaDiferencialId]);

GO

ALTER TABLE [dbo].[Articulo] ADD CONSTRAINT [FK_Articulo_AlicuotaIva_AlicuotaIvaDiferencialId] FOREIGN KEY ([AlicuotaIvaDiferencialId]) REFERENCES [dbo].[AlicuotaIva] ([IdAlicuotaIva]) ON DELETE NO ACTION;

GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20191203124610_V02';

GO

DROP TABLE [dbo].[Articulo];

GO

DROP TABLE [dbo].[ClienteDomicilio];

GO

DROP TABLE [dbo].[ClienteTelefono];

GO

DROP TABLE [dbo].[Logs];

GO

DROP TABLE [dbo].[RolRecurso];

GO

DROP TABLE [dbo].[Usuario];

GO

DROP TABLE [dbo].[AlicuotaIva];

GO

DROP TABLE [dbo].[ArticuloCategoria];

GO

DROP TABLE [dbo].[ArticuloLinea];

GO

DROP TABLE [dbo].[ArticuloMarca];

GO

DROP TABLE [dbo].[ArticuloRubro];

GO

DROP TABLE [dbo].[ArticuloSubTipo];

GO

DROP TABLE [dbo].[ArticuloUnidadMedida];

GO

DROP TABLE [dbo].[Domicilio];

GO

DROP TABLE [dbo].[Cliente];

GO

DROP TABLE [dbo].[Telefono];

GO

DROP TABLE [dbo].[RecursoSistema];

GO

DROP TABLE [dbo].[Rol];

GO

DROP TABLE [dbo].[ArticuloTipo];

GO

DROP TABLE [dbo].[Localidad];

GO

DROP TABLE [dbo].[DomicilioTipo];

GO

DROP TABLE [dbo].[ClienteCategoria];

GO

DROP TABLE [dbo].[CondicionIva];

GO

DROP TABLE [dbo].[CondicionPago];

GO

DROP TABLE [dbo].[ClienteRubro];

GO

DROP TABLE [dbo].[ClienteSubTipo];

GO

DROP TABLE [dbo].[Sucursal];

GO

DROP TABLE [dbo].[DocumentoTipo];

GO

DROP TABLE [dbo].[TelefonoTipo];

GO

DROP TABLE [dbo].[Partido];

GO

DROP TABLE [dbo].[ClienteTipo];

GO

DROP TABLE [dbo].[Empresa];

GO

DROP TABLE [dbo].[Provincia];

GO

DROP TABLE [dbo].[Compania];

GO

DROP TABLE [dbo].[Pais];

GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20191128223016_V01';

GO

