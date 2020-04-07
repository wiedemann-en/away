DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Usuario]') AND [c].[name] = N'AudFechaBaja');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [dbo].[Usuario] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Usuario]') AND [c].[name] = N'AudUsuarioBaja');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [dbo].[Usuario] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Sucursal]') AND [c].[name] = N'AudFechaBaja');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Sucursal] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [dbo].[Sucursal] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Sucursal]') AND [c].[name] = N'AudUsuarioBaja');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Sucursal] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [dbo].[Sucursal] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Rol]') AND [c].[name] = N'AudFechaBaja');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Rol] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [dbo].[Rol] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Rol]') AND [c].[name] = N'AudUsuarioBaja');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Rol] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [dbo].[Rol] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Empresa]') AND [c].[name] = N'AudFechaBaja');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Empresa] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [dbo].[Empresa] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Empresa]') AND [c].[name] = N'AudUsuarioBaja');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Empresa] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [dbo].[Empresa] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Compania]') AND [c].[name] = N'AudFechaBaja');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Compania] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [dbo].[Compania] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Compania]') AND [c].[name] = N'AudUsuarioBaja');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Compania] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [dbo].[Compania] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Cliente]') AND [c].[name] = N'AudFechaBaja');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [dbo].[Cliente] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Cliente]') AND [c].[name] = N'AudUsuarioBaja');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [dbo].[Cliente] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Articulo]') AND [c].[name] = N'AudFechaBaja');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Articulo] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [dbo].[Articulo] DROP COLUMN [AudFechaBaja];

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Articulo]') AND [c].[name] = N'AudUsuarioBaja');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Articulo] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [dbo].[Articulo] DROP COLUMN [AudUsuarioBaja];

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Usuario]') AND [c].[name] = N'Activo');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [dbo].[Usuario] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[TelefonoTipo]') AND [c].[name] = N'Activo');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[TelefonoTipo] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [dbo].[TelefonoTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Sucursal]') AND [c].[name] = N'Activo');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Sucursal] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [dbo].[Sucursal] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Rol]') AND [c].[name] = N'Activo');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Rol] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [dbo].[Rol] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Provincia]') AND [c].[name] = N'Activo');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Provincia] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [dbo].[Provincia] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Partido]') AND [c].[name] = N'Activo');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Partido] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [dbo].[Partido] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Pais]') AND [c].[name] = N'Activo');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Pais] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [dbo].[Pais] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Localidad]') AND [c].[name] = N'Activo');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Localidad] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [dbo].[Localidad] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Empresa]') AND [c].[name] = N'Activo');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Empresa] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [dbo].[Empresa] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[DomicilioTipo]') AND [c].[name] = N'Activo');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[DomicilioTipo] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [dbo].[DomicilioTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[DocumentoTipo]') AND [c].[name] = N'Activo');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[DocumentoTipo] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [dbo].[DocumentoTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[CondicionPago]') AND [c].[name] = N'Activo');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[CondicionPago] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [dbo].[CondicionPago] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[CondicionIva]') AND [c].[name] = N'Activo');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[CondicionIva] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [dbo].[CondicionIva] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Compania]') AND [c].[name] = N'Activo');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Compania] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [dbo].[Compania] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteTipo]') AND [c].[name] = N'Activo');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteTipo] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [dbo].[ClienteTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteSubTipo]') AND [c].[name] = N'Activo');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteSubTipo] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [dbo].[ClienteSubTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteRubro]') AND [c].[name] = N'Activo');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteRubro] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [dbo].[ClienteRubro] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ClienteCategoria]') AND [c].[name] = N'Activo');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ClienteCategoria] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [dbo].[ClienteCategoria] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Cliente]') AND [c].[name] = N'Activo');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [dbo].[Cliente] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloUnidadMedida]') AND [c].[name] = N'Activo');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloUnidadMedida] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [dbo].[ArticuloUnidadMedida] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloTipo]') AND [c].[name] = N'Activo');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloTipo] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [dbo].[ArticuloTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloSubTipo]') AND [c].[name] = N'Activo');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloSubTipo] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [dbo].[ArticuloSubTipo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloRubro]') AND [c].[name] = N'Activo');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloRubro] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [dbo].[ArticuloRubro] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloMarca]') AND [c].[name] = N'Activo');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloMarca] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [dbo].[ArticuloMarca] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloLinea]') AND [c].[name] = N'Activo');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloLinea] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [dbo].[ArticuloLinea] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[ArticuloCategoria]') AND [c].[name] = N'Activo');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[ArticuloCategoria] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [dbo].[ArticuloCategoria] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[Articulo]') AND [c].[name] = N'Activo');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[Articulo] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [dbo].[Articulo] ALTER COLUMN [Activo] bit NOT NULL;

GO

DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[AlicuotaIva]') AND [c].[name] = N'Activo');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[AlicuotaIva] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [dbo].[AlicuotaIva] ALTER COLUMN [Activo] bit NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191205131032_V03', N'2.2.6-servicing-10079');

GO

