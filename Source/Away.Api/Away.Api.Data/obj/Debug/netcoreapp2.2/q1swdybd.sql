IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [dbo].[AlicuotaIva] (
    [IdAlicuotaIva] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [Codigo] nvarchar(64) NOT NULL,
    CONSTRAINT [PK_AlicuotaIva] PRIMARY KEY ([IdAlicuotaIva])
);

GO

CREATE TABLE [dbo].[ArticuloCategoria] (
    [IdCategoria] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloCategoria] PRIMARY KEY ([IdCategoria])
);

GO

CREATE TABLE [dbo].[ArticuloLinea] (
    [IdLinea] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloLinea] PRIMARY KEY ([IdLinea])
);

GO

CREATE TABLE [dbo].[ArticuloMarca] (
    [IdMarca] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloMarca] PRIMARY KEY ([IdMarca])
);

GO

CREATE TABLE [dbo].[ArticuloRubro] (
    [IdRubro] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloRubro] PRIMARY KEY ([IdRubro])
);

GO

CREATE TABLE [dbo].[ArticuloTipo] (
    [IdTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloTipo] PRIMARY KEY ([IdTipo])
);

GO

CREATE TABLE [dbo].[ArticuloUnidadMedida] (
    [IdUnidadMedida] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ArticuloUnidadMedida] PRIMARY KEY ([IdUnidadMedida])
);

GO

CREATE TABLE [dbo].[ClienteCategoria] (
    [IdCategoria] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ClienteCategoria] PRIMARY KEY ([IdCategoria])
);

GO

CREATE TABLE [dbo].[ClienteRubro] (
    [IdRubro] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ClienteRubro] PRIMARY KEY ([IdRubro])
);

GO

CREATE TABLE [dbo].[ClienteTipo] (
    [IdTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_ClienteTipo] PRIMARY KEY ([IdTipo])
);

GO

CREATE TABLE [dbo].[Compania] (
    [IdCompania] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Compania] PRIMARY KEY ([IdCompania])
);

GO

CREATE TABLE [dbo].[CondicionIva] (
    [IdCondicionIva] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_CondicionIva] PRIMARY KEY ([IdCondicionIva])
);

GO

CREATE TABLE [dbo].[CondicionPago] (
    [IdCondicionPago] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [Dias] int NOT NULL,
    CONSTRAINT [PK_CondicionPago] PRIMARY KEY ([IdCondicionPago])
);

GO

CREATE TABLE [dbo].[DocumentoTipo] (
    [IdTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_DocumentoTipo] PRIMARY KEY ([IdTipo])
);

GO

CREATE TABLE [dbo].[DomicilioTipo] (
    [IdTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_DomicilioTipo] PRIMARY KEY ([IdTipo])
);

GO

CREATE TABLE [dbo].[Logs] (
    [IdLog] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL,
    [Tipo] char NOT NULL,
    [Origen] nvarchar(max) NOT NULL,
    [Descripcion] nvarchar(max) NOT NULL,
    [FechaCreacion] datetime2 NOT NULL DEFAULT (getutcdate()),
    [Detalle] nvarchar(max) NULL,
    [StackTrace] nvarchar(max) NULL,
    [Source] nvarchar(max) NULL,
    [TargetSite] nvarchar(max) NULL,
    CONSTRAINT [PK_Logs] PRIMARY KEY ([IdLog])
);

GO

CREATE TABLE [dbo].[Pais] (
    [IdPais] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [Codigo] nvarchar(3) NOT NULL,
    CONSTRAINT [PK_Pais] PRIMARY KEY ([IdPais])
);

GO

CREATE TABLE [dbo].[RecursoSistema] (
    [IdRecurso] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL,
    [AppState] nvarchar(128) NULL,
    [ApiName] nvarchar(128) NULL,
    [Permiso] nvarchar(16) NOT NULL,
    [Descripcion] nvarchar(255) NULL,
    [AppStatePadre] nvarchar(128) NULL,
    [RecursosDependientes] nvarchar(128) NULL,
    CONSTRAINT [PK_RecursoSistema] PRIMARY KEY ([IdRecurso])
);

GO

CREATE TABLE [dbo].[Rol] (
    [IdRol] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Rol] PRIMARY KEY ([IdRol])
);

GO

CREATE TABLE [dbo].[TelefonoTipo] (
    [IdTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    CONSTRAINT [PK_TelefonoTipo] PRIMARY KEY ([IdTipo])
);

GO

CREATE TABLE [dbo].[ArticuloSubTipo] (
    [IdSubTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdTipo] bigint NOT NULL,
    [Codigo] nvarchar(max) NULL,
    CONSTRAINT [PK_ArticuloSubTipo] PRIMARY KEY ([IdSubTipo]),
    CONSTRAINT [FK_ArticuloSubTipo_ArticuloTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[ArticuloTipo] ([IdTipo]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[ClienteSubTipo] (
    [IdSubTipo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdTipo] bigint NOT NULL,
    [Codigo] nvarchar(max) NULL,
    CONSTRAINT [PK_ClienteSubTipo] PRIMARY KEY ([IdSubTipo]),
    CONSTRAINT [FK_ClienteSubTipo_ClienteTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[ClienteTipo] ([IdTipo]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Empresa] (
    [IdEmpresa] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [RazonSocial] nvarchar(255) NOT NULL,
    [Cuit] nvarchar(16) NOT NULL,
    [IdCompania] bigint NOT NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Empresa] PRIMARY KEY ([IdEmpresa]),
    CONSTRAINT [FK_Empresa_Compania_IdCompania] FOREIGN KEY ([IdCompania]) REFERENCES [dbo].[Compania] ([IdCompania]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Provincia] (
    [IdProvincia] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdPais] bigint NOT NULL,
    CONSTRAINT [PK_Provincia] PRIMARY KEY ([IdProvincia]),
    CONSTRAINT [FK_Provincia_Pais_IdPais] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Pais] ([IdPais]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[RolRecurso] (
    [IdRol] bigint NOT NULL,
    [IdRecurso] bigint NOT NULL,
    CONSTRAINT [PK_RolRecurso] PRIMARY KEY ([IdRol], [IdRecurso]),
    CONSTRAINT [FK_RolRecurso_RecursoSistema_IdRecurso] FOREIGN KEY ([IdRecurso]) REFERENCES [dbo].[RecursoSistema] ([IdRecurso]) ON DELETE CASCADE,
    CONSTRAINT [FK_RolRecurso_Rol_IdRol] FOREIGN KEY ([IdRol]) REFERENCES [dbo].[Rol] ([IdRol]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[Telefono] (
    [IdTelefono] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL,
    [IdTipo] bigint NOT NULL,
    [CodigoArea] nvarchar(12) NOT NULL,
    [Numero] nvarchar(12) NOT NULL,
    CONSTRAINT [PK_Telefono] PRIMARY KEY ([IdTelefono]),
    CONSTRAINT [FK_Telefono_TelefonoTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[TelefonoTipo] ([IdTipo]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Sucursal] (
    [IdSucursal] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdCompania] bigint NOT NULL,
    [IdEmpresa] bigint NOT NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Sucursal] PRIMARY KEY ([IdSucursal]),
    CONSTRAINT [FK_Sucursal_Compania_IdCompania] FOREIGN KEY ([IdCompania]) REFERENCES [dbo].[Compania] ([IdCompania]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Sucursal_Empresa_IdEmpresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([IdEmpresa]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Partido] (
    [IdPartido] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdPais] bigint NOT NULL,
    [IdProvincia] bigint NOT NULL,
    CONSTRAINT [PK_Partido] PRIMARY KEY ([IdPartido]),
    CONSTRAINT [FK_Partido_Provincia_IdProvincia] FOREIGN KEY ([IdProvincia]) REFERENCES [dbo].[Provincia] ([IdProvincia]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Articulo] (
    [IdArticulo] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Codigo] nvarchar(50) NOT NULL,
    [Descripcion] nvarchar(max) NULL,
    [DescripcionCorta] nvarchar(max) NULL,
    [Familia] nvarchar(50) NOT NULL,
    [Grupo] nvarchar(50) NOT NULL,
    [IdTipo] bigint NOT NULL,
    [IdSubTipo] bigint NOT NULL,
    [IdRubro] bigint NOT NULL,
    [IdCategoria] bigint NOT NULL,
    [IdLinea] bigint NOT NULL,
    [IdMarca] bigint NOT NULL,
    [Presentacion] nvarchar(50) NULL,
    [Color] nvarchar(50) NULL,
    [CodigoEANBulto] nvarchar(max) NULL,
    [CodigoEANUnidad] nvarchar(max) NULL,
    [CodigoEANFraccion] nvarchar(max) NULL,
    [GestionaStock] bit NOT NULL,
    [UnidadesXBulto] int NOT NULL,
    [BultosXPallet] int NULL,
    [IdUnidadMedida] bigint NOT NULL,
    [IdAlicuotaIva] bigint NOT NULL,
    [IdAlicuotaIvaDiferencial] bigint NOT NULL,
    [ImpuestosInternosPorc] decimal(18,2) NULL,
    [ImpuestosInternosFijos] decimal(18,2) NULL,
    [PercepcionIIBB] decimal(18,2) NULL,
    [EsCompuesto] bit NOT NULL,
    [EsLibreDescripcion] bit NOT NULL,
    [EsDeOferta] bit NOT NULL,
    [IdCompania] bigint NULL,
    [IdEmpresa] bigint NULL,
    [IdSucursal] bigint NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    [AlicuotaIvaDiferencialId] bigint NULL,
    CONSTRAINT [PK_Articulo] PRIMARY KEY ([IdArticulo]),
    CONSTRAINT [FK_Articulo_AlicuotaIva_AlicuotaIvaDiferencialId] FOREIGN KEY ([AlicuotaIvaDiferencialId]) REFERENCES [dbo].[AlicuotaIva] ([IdAlicuotaIva]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_AlicuotaIva_IdAlicuotaIva] FOREIGN KEY ([IdAlicuotaIva]) REFERENCES [dbo].[AlicuotaIva] ([IdAlicuotaIva]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloCategoria_IdCategoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[ArticuloCategoria] ([IdCategoria]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_Compania_IdCompania] FOREIGN KEY ([IdCompania]) REFERENCES [dbo].[Compania] ([IdCompania]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_Empresa_IdEmpresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([IdEmpresa]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloLinea_IdLinea] FOREIGN KEY ([IdLinea]) REFERENCES [dbo].[ArticuloLinea] ([IdLinea]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloMarca_IdMarca] FOREIGN KEY ([IdMarca]) REFERENCES [dbo].[ArticuloMarca] ([IdMarca]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloRubro_IdRubro] FOREIGN KEY ([IdRubro]) REFERENCES [dbo].[ArticuloRubro] ([IdRubro]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloSubTipo_IdSubTipo] FOREIGN KEY ([IdSubTipo]) REFERENCES [dbo].[ArticuloSubTipo] ([IdSubTipo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_Sucursal_IdSucursal] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[Sucursal] ([IdSucursal]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[ArticuloTipo] ([IdTipo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Articulo_ArticuloUnidadMedida_IdUnidadMedida] FOREIGN KEY ([IdUnidadMedida]) REFERENCES [dbo].[ArticuloUnidadMedida] ([IdUnidadMedida]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Cliente] (
    [IdCliente] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Codigo] nvarchar(50) NOT NULL,
    [RazonSocial] nvarchar(100) NOT NULL,
    [IdTipoDocumento] bigint NOT NULL,
    [NumeroFiscal] nvarchar(13) NOT NULL,
    [Email] nvarchar(100) NULL,
    [NombreFantasia] nvarchar(100) NULL,
    [Rol] int NOT NULL,
    [IdCondicionIVA] bigint NOT NULL,
    [IdCondicionPago] bigint NULL,
    [PercibirIB] bit NULL,
    [AlicuotaIB] float NULL,
    [IvaDiferencial] bit NULL,
    [Grupo] nvarchar(50) NULL,
    [Zona] nvarchar(50) NULL,
    [IdTipo] bigint NULL,
    [IdSubTipo] bigint NULL,
    [IdRubro] bigint NULL,
    [IdCategoria] bigint NULL,
    [IdCompania] bigint NULL,
    [IdEmpresa] bigint NULL,
    [IdSucursal] bigint NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY ([IdCliente]),
    CONSTRAINT [FK_Cliente_ClienteCategoria_IdCategoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[ClienteCategoria] ([IdCategoria]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_Compania_IdCompania] FOREIGN KEY ([IdCompania]) REFERENCES [dbo].[Compania] ([IdCompania]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_CondicionIva_IdCondicionIVA] FOREIGN KEY ([IdCondicionIVA]) REFERENCES [dbo].[CondicionIva] ([IdCondicionIva]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_CondicionPago_IdCondicionPago] FOREIGN KEY ([IdCondicionPago]) REFERENCES [dbo].[CondicionPago] ([IdCondicionPago]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_Empresa_IdEmpresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([IdEmpresa]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_ClienteRubro_IdRubro] FOREIGN KEY ([IdRubro]) REFERENCES [dbo].[ClienteRubro] ([IdRubro]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_ClienteSubTipo_IdSubTipo] FOREIGN KEY ([IdSubTipo]) REFERENCES [dbo].[ClienteSubTipo] ([IdSubTipo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_Sucursal_IdSucursal] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[Sucursal] ([IdSucursal]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_ClienteTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[ClienteTipo] ([IdTipo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cliente_DocumentoTipo_IdTipoDocumento] FOREIGN KEY ([IdTipoDocumento]) REFERENCES [dbo].[DocumentoTipo] ([IdTipo]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [Apellido] nvarchar(max) NULL,
    [Email] nvarchar(128) NOT NULL,
    [PasswordHash] varbinary(max) NOT NULL,
    [PasswordSalt] varbinary(max) NOT NULL,
    [IdRol] bigint NOT NULL,
    [IdCompania] bigint NULL,
    [IdEmpresa] bigint NULL,
    [IdSucursal] bigint NULL,
    [AudFechaCreacion] datetime2 NOT NULL,
    [AudUsuarioCreacion] nvarchar(128) NOT NULL,
    [AudFechaModificacion] datetime2 NULL,
    [AudUsuarioModificacion] nvarchar(128) NULL,
    [AudFechaSincornizacion] datetime2 NULL,
    [AudUsuarioSincronizacion] nvarchar(128) NULL,
    [AudFechaBaja] datetime2 NULL,
    [AudUsuarioBaja] nvarchar(128) NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([IdUsuario]),
    CONSTRAINT [FK_Usuario_Compania_IdCompania] FOREIGN KEY ([IdCompania]) REFERENCES [dbo].[Compania] ([IdCompania]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Usuario_Empresa_IdEmpresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([IdEmpresa]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Usuario_Rol_IdRol] FOREIGN KEY ([IdRol]) REFERENCES [dbo].[Rol] ([IdRol]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Usuario_Sucursal_IdSucursal] FOREIGN KEY ([IdSucursal]) REFERENCES [dbo].[Sucursal] ([IdSucursal]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Localidad] (
    [IdLocalidad] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL DEFAULT 1,
    [Nombre] nvarchar(255) NOT NULL,
    [IdPais] bigint NOT NULL,
    [IdProvincia] bigint NOT NULL,
    [IdPartido] bigint NOT NULL,
    CONSTRAINT [PK_Localidad] PRIMARY KEY ([IdLocalidad]),
    CONSTRAINT [FK_Localidad_Partido_IdPartido] FOREIGN KEY ([IdPartido]) REFERENCES [dbo].[Partido] ([IdPartido]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[ClienteTelefono] (
    [IdCliente] bigint NOT NULL,
    [IdTelefono] bigint NOT NULL,
    CONSTRAINT [PK_ClienteTelefono] PRIMARY KEY ([IdCliente], [IdTelefono]),
    CONSTRAINT [FK_ClienteTelefono_Cliente_IdCliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente]) ON DELETE CASCADE,
    CONSTRAINT [FK_ClienteTelefono_Telefono_IdTelefono] FOREIGN KEY ([IdTelefono]) REFERENCES [dbo].[Telefono] ([IdTelefono]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[Domicilio] (
    [IdDomicilio] bigint NOT NULL IDENTITY,
    [Activo] bit NOT NULL,
    [IdTipo] bigint NOT NULL,
    [IdPais] bigint NOT NULL,
    [IdProvincia] bigint NOT NULL,
    [IdPartido] bigint NOT NULL,
    [IdLocalidad] bigint NOT NULL,
    [CodigoPostal] nvarchar(12) NULL,
    [Calle] nvarchar(128) NOT NULL,
    [Numero] nvarchar(12) NOT NULL,
    [Cuerpo] nvarchar(12) NULL,
    [Piso] nvarchar(12) NULL,
    [Departamento] nvarchar(12) NULL,
    CONSTRAINT [PK_Domicilio] PRIMARY KEY ([IdDomicilio]),
    CONSTRAINT [FK_Domicilio_Localidad_IdLocalidad] FOREIGN KEY ([IdLocalidad]) REFERENCES [dbo].[Localidad] ([IdLocalidad]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Domicilio_DomicilioTipo_IdTipo] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[DomicilioTipo] ([IdTipo]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[ClienteDomicilio] (
    [IdCliente] bigint NOT NULL,
    [IdDomicilio] bigint NOT NULL,
    CONSTRAINT [PK_ClienteDomicilio] PRIMARY KEY ([IdCliente], [IdDomicilio]),
    CONSTRAINT [FK_ClienteDomicilio_Cliente_IdCliente] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([IdCliente]) ON DELETE CASCADE,
    CONSTRAINT [FK_ClienteDomicilio_Domicilio_IdDomicilio] FOREIGN KEY ([IdDomicilio]) REFERENCES [dbo].[Domicilio] ([IdDomicilio]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Articulo_AlicuotaIvaDiferencialId] ON [dbo].[Articulo] ([AlicuotaIvaDiferencialId]);

GO

CREATE INDEX [IX_Articulo_IdAlicuotaIva] ON [dbo].[Articulo] ([IdAlicuotaIva]);

GO

CREATE INDEX [IX_Articulo_IdCategoria] ON [dbo].[Articulo] ([IdCategoria]);

GO

CREATE INDEX [IX_Articulo_IdCompania] ON [dbo].[Articulo] ([IdCompania]);

GO

CREATE INDEX [IX_Articulo_IdEmpresa] ON [dbo].[Articulo] ([IdEmpresa]);

GO

CREATE INDEX [IX_Articulo_IdLinea] ON [dbo].[Articulo] ([IdLinea]);

GO

CREATE INDEX [IX_Articulo_IdMarca] ON [dbo].[Articulo] ([IdMarca]);

GO

CREATE INDEX [IX_Articulo_IdRubro] ON [dbo].[Articulo] ([IdRubro]);

GO

CREATE INDEX [IX_Articulo_IdSubTipo] ON [dbo].[Articulo] ([IdSubTipo]);

GO

CREATE INDEX [IX_Articulo_IdSucursal] ON [dbo].[Articulo] ([IdSucursal]);

GO

CREATE INDEX [IX_Articulo_IdTipo] ON [dbo].[Articulo] ([IdTipo]);

GO

CREATE INDEX [IX_Articulo_IdUnidadMedida] ON [dbo].[Articulo] ([IdUnidadMedida]);

GO

CREATE INDEX [IX_ArticuloSubTipo_IdTipo] ON [dbo].[ArticuloSubTipo] ([IdTipo]);

GO

CREATE INDEX [IX_Cliente_IdCategoria] ON [dbo].[Cliente] ([IdCategoria]);

GO

CREATE INDEX [IX_Cliente_IdCompania] ON [dbo].[Cliente] ([IdCompania]);

GO

CREATE INDEX [IX_Cliente_IdCondicionIVA] ON [dbo].[Cliente] ([IdCondicionIVA]);

GO

CREATE INDEX [IX_Cliente_IdCondicionPago] ON [dbo].[Cliente] ([IdCondicionPago]);

GO

CREATE INDEX [IX_Cliente_IdEmpresa] ON [dbo].[Cliente] ([IdEmpresa]);

GO

CREATE INDEX [IX_Cliente_IdRubro] ON [dbo].[Cliente] ([IdRubro]);

GO

CREATE INDEX [IX_Cliente_IdSubTipo] ON [dbo].[Cliente] ([IdSubTipo]);

GO

CREATE INDEX [IX_Cliente_IdSucursal] ON [dbo].[Cliente] ([IdSucursal]);

GO

CREATE INDEX [IX_Cliente_IdTipo] ON [dbo].[Cliente] ([IdTipo]);

GO

CREATE INDEX [IX_Cliente_IdTipoDocumento] ON [dbo].[Cliente] ([IdTipoDocumento]);

GO

CREATE INDEX [IX_ClienteDomicilio_IdDomicilio] ON [dbo].[ClienteDomicilio] ([IdDomicilio]);

GO

CREATE INDEX [IX_ClienteSubTipo_IdTipo] ON [dbo].[ClienteSubTipo] ([IdTipo]);

GO

CREATE INDEX [IX_ClienteTelefono_IdTelefono] ON [dbo].[ClienteTelefono] ([IdTelefono]);

GO

CREATE INDEX [IX_Domicilio_IdLocalidad] ON [dbo].[Domicilio] ([IdLocalidad]);

GO

CREATE INDEX [IX_Domicilio_IdTipo] ON [dbo].[Domicilio] ([IdTipo]);

GO

CREATE INDEX [IX_Empresa_IdCompania] ON [dbo].[Empresa] ([IdCompania]);

GO

CREATE INDEX [IX_Localidad_IdPartido] ON [dbo].[Localidad] ([IdPartido]);

GO

CREATE INDEX [IX_Partido_IdProvincia] ON [dbo].[Partido] ([IdProvincia]);

GO

CREATE INDEX [IX_Provincia_IdPais] ON [dbo].[Provincia] ([IdPais]);

GO

CREATE INDEX [IX_RolRecurso_IdRecurso] ON [dbo].[RolRecurso] ([IdRecurso]);

GO

CREATE INDEX [IX_Sucursal_IdCompania] ON [dbo].[Sucursal] ([IdCompania]);

GO

CREATE INDEX [IX_Sucursal_IdEmpresa] ON [dbo].[Sucursal] ([IdEmpresa]);

GO

CREATE INDEX [IX_Telefono_IdTipo] ON [dbo].[Telefono] ([IdTipo]);

GO

CREATE INDEX [IX_Usuario_IdCompania] ON [dbo].[Usuario] ([IdCompania]);

GO

CREATE INDEX [IX_Usuario_IdEmpresa] ON [dbo].[Usuario] ([IdEmpresa]);

GO

CREATE INDEX [IX_Usuario_IdRol] ON [dbo].[Usuario] ([IdRol]);

GO

CREATE INDEX [IX_Usuario_IdSucursal] ON [dbo].[Usuario] ([IdSucursal]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191128222808_Initial', N'2.2.6-servicing-10079');

GO

