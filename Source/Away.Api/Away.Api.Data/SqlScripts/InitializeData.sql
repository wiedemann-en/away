USE Away
GO

SET IDENTITY_INSERT dbo.Rol ON;
INSERT INTO dbo.Rol (IdRol, Activo, Nombre, AudFechaCreacion, AudUsuarioCreacion) VALUES (1, 1, 'Administrador General', GETDATE(), 'INIT');
SET IDENTITY_INSERT dbo.Rol OFF;

SET IDENTITY_INSERT dbo.RecursoSistema ON;
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (1, 1, 'ALICUOTAIVA', 'ALICUOTAIVA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (2, 1, 'ALICUOTAIVAFORM', 'ALICUOTAIVA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (3, 1, 'ARTICULOCATEGORIA', 'ARTICULOCATEGORIA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (4, 1, 'ARTICULOCATEGORIAFORM', 'ARTICULOCATEGORIA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (5, 1, 'ARTICULO', 'ARTICULO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (6, 1, 'ARTICULOFORM', 'ARTICULO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (7, 1, 'ARTICULOLINEA', 'ARTICULOLINEA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (8, 1, 'ARTICULOLINEAFORM', 'ARTICULOLINEA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (9, 1, 'ARTICULOMARCA', 'ARTICULOMARCA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (10, 1, 'ARTICULOMARCAFORM', 'ARTICULOMARCA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (11, 1, 'ARTICULORUBRO', 'ARTICULORUBRO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (12, 1, 'ARTICULORUBROFORM', 'ARTICULORUBRO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (13, 1, 'ARTICULOSUBTIPO', 'ARTICULOSUBTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (14, 1, 'ARTICULOSUBTIPOFORM', 'ARTICULOSUBTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (15, 1, 'ARTICULOTIPO', 'ARTICULOTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (16, 1, 'ARTICULOTIPOFORM', 'ARTICULOTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (17, 1, 'ARTICULOUNIDADMEDIDA', 'ARTICULOUNIDADMEDIDA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (18, 1, 'ARTICULOUNIDADMEDIDAFORM', 'ARTICULOUNIDADMEDIDA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (19, 1, 'CLIENTECATEGORIA', 'CLIENTECATEGORIA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (20, 1, 'CLIENTECATEGORIAFORM', 'CLIENTECATEGORIA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (21, 1, 'CLIENTE', 'CLIENTE', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (22, 1, 'CLIENTEFORM', 'CLIENTE', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (23, 1, 'CLIENTERUBRO', 'CLIENTERUBRO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (24, 1, 'CLIENTERUBROFORM', 'CLIENTERUBRO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (25, 1, 'CLIENTESUBTIPO', 'CLIENTESUBTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (26, 1, 'CLIENTESUBTIPOFORM', 'CLIENTESUBTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (27, 1, 'CLIENTETIPO', 'CLIENTETIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (28, 1, 'CLIENTETIPOFORM', 'CLIENTETIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (29, 1, 'COMPANIA', 'COMPANIA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (30, 1, 'COMPANIAFORM', 'COMPANIA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (31, 1, 'CONDICIONIVA', 'CONDICIONIVA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (32, 1, 'CONDICIONIVAFORM', 'CONDICIONIVA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (33, 1, 'CONDICIONPAGO', 'CONDICIONPAGO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (34, 1, 'CONDICIONPAGOFORM', 'CONDICIONPAGO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (35, 1, 'CONTACTO', 'CONTACTO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (36, 1, 'CONTACTOFORM', 'CONTACTO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (37, 1, 'EMPRESA', 'EMPRESA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (38, 1, 'EMPRESAFORM', 'EMPRESA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (39, 1, 'ENTEDOCUMENTOTIPO', 'ENTEDOCUMENTOTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (40, 1, 'ENTEDOCUMENTOTIPOFORM', 'ENTEDOCUMENTOTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (41, 1, 'ENTEDOMICILIOTIPO', 'ENTEDOMICILIOTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (42, 1, 'ENTEDOMICILIOTIPOFORM', 'ENTEDOMICILIOTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (43, 1, 'ENTETELEFONOTIPO', 'ENTETELEFONOTIPO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (44, 1, 'ENTETELEFONOTIPOFORM', 'ENTETELEFONOTIPO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (45, 1, 'LOCALIDAD', 'LOCALIDAD', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (46, 1, 'LOCALIDADFORM', 'LOCALIDAD', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (47, 1, 'LOG', 'LOG', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (48, 1, 'LOGFORM', 'LOG', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (49, 1, 'MOVIMIENTOCAJA', 'MOVIMIENTOCAJA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (50, 1, 'MOVIMIENTOCAJAFORM', 'MOVIMIENTOCAJA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (51, 1, 'ORDEN', 'ORDEN', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (52, 1, 'ORDENFORM', 'ORDEN', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (53, 1, 'PAIS', 'PAIS', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (54, 1, 'PAISFORM', 'PAIS', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (55, 1, 'PARTIDO', 'PARTIDO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (56, 1, 'PARTIDOFORM', 'PARTIDO', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (57, 1, 'PROVEEDOR', 'PROVEEDOR', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (58, 1, 'PROVEEDORFORM', 'PROVEEDOR', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (59, 1, 'PROVINCIA', 'PROVINCIA', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (60, 1, 'PROVINCIAFORM', 'PROVINCIA', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (61, 1, 'ROL', 'ROL', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (62, 1, 'ROLFORM', 'ROL', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (63, 1, 'SUCURSAL', 'SUCURSAL', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (64, 1, 'SUCURSALFORM', 'SUCURSAL', 'WRITE');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (65, 1, 'USUARIO', 'USUARIO', 'READ');
INSERT INTO dbo.RecursoSistema (IdRecurso, Activo, AppState, ApiName, Permiso) VALUES (66, 1, 'USUARIOFORM', 'USUARIO', 'WRITE');
SET IDENTITY_INSERT dbo.RecursoSistema OFF;

INSERT INTO dbo.RolRecurso (IdRol, IdRecurso)
SELECT 1, IdRecurso
FROM dbo.RecursoSistema;

SET IDENTITY_INSERT dbo.Usuario ON;
INSERT INTO dbo.Usuario (IdUsuario, Activo, Nombre, Apellido, Email, PasswordHash, PasswordSalt, IdRol, AudFechaCreacion, AudUsuarioCreacion) VALUES (1, 1, 'Admin', 'Admin', 'admin@admin.com', 0x103D2B5E9E381A7234D8B5C03D1887BAC313ACDCFDCFF114A839475FAF80BE69772361B8E5926152FBFC44445A1513D4DD6F075F6ACC560381117A288B502636, 0x57B8CD1DD915126847126E26EFE681FDCF33D68CA6DD068C6186B7B32CB8CB67FC92B39550B8DA7C167C434A54F346E42593437535107A2B35F923A757E58E583637425D7D127EE0B35C397AC3B1FC0C095AD2EB4F69D7D17C844FFDF8F650FF262B24DA6F86ADD067112BFEE3584BE40DC86BF1EB9D6E62452E2D4A67E440B0, 1, GETDATE(), 'INIT');
SET IDENTITY_INSERT dbo.Usuario OFF;
