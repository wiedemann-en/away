using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Away.Api.Data.Migrations
{
    public partial class V01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AlicuotaIva",
                schema: "dbo",
                columns: table => new
                {
                    IdAlicuotaIva = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    Alicuota = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlicuotaIva", x => x.IdAlicuotaIva);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloCategoria",
                schema: "dbo",
                columns: table => new
                {
                    IdCategoria = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloCategoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloLinea",
                schema: "dbo",
                columns: table => new
                {
                    IdLinea = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloLinea", x => x.IdLinea);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloMarca",
                schema: "dbo",
                columns: table => new
                {
                    IdMarca = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloMarca", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloRubro",
                schema: "dbo",
                columns: table => new
                {
                    IdRubro = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloRubro", x => x.IdRubro);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloTipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloUnidadMedida",
                schema: "dbo",
                columns: table => new
                {
                    IdUnidadMedida = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloUnidadMedida", x => x.IdUnidadMedida);
                });

            migrationBuilder.CreateTable(
                name: "ClienteCategoria",
                schema: "dbo",
                columns: table => new
                {
                    IdCategoria = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteCategoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "ClienteRubro",
                schema: "dbo",
                columns: table => new
                {
                    IdRubro = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteRubro", x => x.IdRubro);
                });

            migrationBuilder.CreateTable(
                name: "ClienteTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteTipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "Compania",
                schema: "dbo",
                columns: table => new
                {
                    IdCompania = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compania", x => x.IdCompania);
                });

            migrationBuilder.CreateTable(
                name: "CondicionIva",
                schema: "dbo",
                columns: table => new
                {
                    IdCondicionIva = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionIva", x => x.IdCondicionIva);
                });

            migrationBuilder.CreateTable(
                name: "CondicionPago",
                schema: "dbo",
                columns: table => new
                {
                    IdCondicionPago = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    Dias = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionPago", x => x.IdCondicionPago);
                });

            migrationBuilder.CreateTable(
                name: "EnteDocumentoTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteDocumentoTipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "EnteDomicilioTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteDomicilioTipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "EnteTelefonoTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteTelefonoTipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                schema: "dbo",
                columns: table => new
                {
                    IdLog = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Tipo = table.Column<string>(type: "char", maxLength: 1, nullable: false),
                    Origen = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Detalle = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    TargetSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.IdLog);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                schema: "dbo",
                columns: table => new
                {
                    IdPais = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "RecursoSistema",
                schema: "dbo",
                columns: table => new
                {
                    IdRecurso = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    AppState = table.Column<string>(maxLength: 128, nullable: true),
                    ApiName = table.Column<string>(maxLength: 128, nullable: true),
                    Permiso = table.Column<string>(maxLength: 16, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 255, nullable: true),
                    AppStatePadre = table.Column<string>(maxLength: 128, nullable: true),
                    RecursosDependientes = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursoSistema", x => x.IdRecurso);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                schema: "dbo",
                columns: table => new
                {
                    IdRol = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloSubTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdSubTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdTipo = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloSubTipo", x => x.IdSubTipo);
                    table.ForeignKey(
                        name: "FK_ArticuloSubTipo_ArticuloTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "ArticuloTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteSubTipo",
                schema: "dbo",
                columns: table => new
                {
                    IdSubTipo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdTipo = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteSubTipo", x => x.IdSubTipo);
                    table.ForeignKey(
                        name: "FK_ClienteSubTipo_ClienteTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "ClienteTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                schema: "dbo",
                columns: table => new
                {
                    IdEmpresa = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    RazonSocial = table.Column<string>(maxLength: 250, nullable: false),
                    Cuit = table.Column<string>(maxLength: 16, nullable: false),
                    IdCompania = table.Column<long>(nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IdEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresa_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ente",
                schema: "dbo",
                columns: table => new
                {
                    IdEnte = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    ApellidoRazonSocial = table.Column<string>(maxLength: 200, nullable: false),
                    Nombre = table.Column<string>(maxLength: 100, nullable: true),
                    IdTipoDocumento = table.Column<long>(nullable: false),
                    NroFiscal = table.Column<string>(maxLength: 13, nullable: false),
                    EsPersonaJuridica = table.Column<bool>(nullable: false),
                    TipoEnte = table.Column<string>(maxLength: 32, nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ente", x => x.IdEnte);
                    table.ForeignKey(
                        name: "FK_Ente_EnteDocumentoTipo_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalSchema: "dbo",
                        principalTable: "EnteDocumentoTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                schema: "dbo",
                columns: table => new
                {
                    IdProvincia = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdPais = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.IdProvincia);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_IdPais",
                        column: x => x.IdPais,
                        principalSchema: "dbo",
                        principalTable: "Pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolRecurso",
                schema: "dbo",
                columns: table => new
                {
                    IdRol = table.Column<long>(nullable: false),
                    IdRecurso = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolRecurso", x => new { x.IdRol, x.IdRecurso });
                    table.ForeignKey(
                        name: "FK_RolRecurso_RecursoSistema_IdRecurso",
                        column: x => x.IdRecurso,
                        principalSchema: "dbo",
                        principalTable: "RecursoSistema",
                        principalColumn: "IdRecurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolRecurso_Rol_IdRol",
                        column: x => x.IdRol,
                        principalSchema: "dbo",
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                schema: "dbo",
                columns: table => new
                {
                    IdSucursal = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdCompania = table.Column<long>(nullable: false),
                    IdEmpresa = table.Column<long>(nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursal_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sucursal_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                schema: "dbo",
                columns: table => new
                {
                    IdContacto = table.Column<long>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    Empresa = table.Column<string>(nullable: true),
                    Puesto = table.Column<string>(nullable: true),
                    EsPrincipal = table.Column<bool>(nullable: false),
                    IdEnteRelacion = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.IdContacto);
                    table.ForeignKey(
                        name: "FK_Contacto_Ente_IdContacto",
                        column: x => x.IdContacto,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacto_Ente_IdEnteRelacion",
                        column: x => x.IdEnteRelacion,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnteTelefono",
                schema: "dbo",
                columns: table => new
                {
                    IdTelefono = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    IdEnte = table.Column<long>(nullable: false),
                    IdTipo = table.Column<long>(nullable: false),
                    CodigoArea = table.Column<string>(maxLength: 12, nullable: false),
                    Numero = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteTelefono", x => x.IdTelefono);
                    table.ForeignKey(
                        name: "FK_EnteTelefono_Ente_IdEnte",
                        column: x => x.IdEnte,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnteTelefono_EnteTelefonoTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "EnteTelefonoTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoCaja",
                schema: "dbo",
                columns: table => new
                {
                    IdMovimientoCaja = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    IdEnte = table.Column<long>(nullable: false),
                    TipoMovimiento = table.Column<string>(maxLength: 50, nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoCaja", x => x.IdMovimientoCaja);
                    table.ForeignKey(
                        name: "FK_MovimientoCaja_Ente_IdEnte",
                        column: x => x.IdEnte,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                schema: "dbo",
                columns: table => new
                {
                    IdPartido = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdPais = table.Column<long>(nullable: false),
                    IdProvincia = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.IdPartido);
                    table.ForeignKey(
                        name: "FK_Partido_Provincia_IdProvincia",
                        column: x => x.IdProvincia,
                        principalSchema: "dbo",
                        principalTable: "Provincia",
                        principalColumn: "IdProvincia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                schema: "dbo",
                columns: table => new
                {
                    IdArticulo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    DescripcionCorta = table.Column<string>(nullable: true),
                    Familia = table.Column<string>(maxLength: 50, nullable: false),
                    Grupo = table.Column<string>(maxLength: 50, nullable: false),
                    IdTipo = table.Column<long>(nullable: false),
                    IdSubTipo = table.Column<long>(nullable: false),
                    IdRubro = table.Column<long>(nullable: false),
                    IdCategoria = table.Column<long>(nullable: false),
                    IdLinea = table.Column<long>(nullable: false),
                    IdMarca = table.Column<long>(nullable: false),
                    Presentacion = table.Column<string>(maxLength: 50, nullable: true),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    CodigoEANBulto = table.Column<string>(nullable: true),
                    CodigoEANUnidad = table.Column<string>(nullable: true),
                    CodigoEANFraccion = table.Column<string>(nullable: true),
                    GestionaStock = table.Column<bool>(nullable: false),
                    UnidadesXBulto = table.Column<int>(nullable: false),
                    BultosXPallet = table.Column<int>(nullable: true),
                    IdUnidadMedida = table.Column<long>(nullable: false),
                    IdAlicuotaIva = table.Column<long>(nullable: false),
                    IdAlicuotaIvaDiferencial = table.Column<long>(nullable: false),
                    ImpuestosInternosPorc = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    ImpuestosInternosFijos = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    PercepcionIIBB = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    EsCompuesto = table.Column<bool>(nullable: false),
                    EsLibreDescripcion = table.Column<bool>(nullable: false),
                    EsDeOferta = table.Column<bool>(nullable: false),
                    IdCompania = table.Column<long>(nullable: true),
                    IdEmpresa = table.Column<long>(nullable: true),
                    IdSucursal = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.IdArticulo);
                    table.ForeignKey(
                        name: "FK_Articulo_AlicuotaIva_IdAlicuotaIva",
                        column: x => x.IdAlicuotaIva,
                        principalSchema: "dbo",
                        principalTable: "AlicuotaIva",
                        principalColumn: "IdAlicuotaIva",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_AlicuotaIva_IdAlicuotaIvaDiferencial",
                        column: x => x.IdAlicuotaIvaDiferencial,
                        principalSchema: "dbo",
                        principalTable: "AlicuotaIva",
                        principalColumn: "IdAlicuotaIva",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloCategoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalSchema: "dbo",
                        principalTable: "ArticuloCategoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloLinea_IdLinea",
                        column: x => x.IdLinea,
                        principalSchema: "dbo",
                        principalTable: "ArticuloLinea",
                        principalColumn: "IdLinea",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloMarca_IdMarca",
                        column: x => x.IdMarca,
                        principalSchema: "dbo",
                        principalTable: "ArticuloMarca",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloRubro_IdRubro",
                        column: x => x.IdRubro,
                        principalSchema: "dbo",
                        principalTable: "ArticuloRubro",
                        principalColumn: "IdRubro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloSubTipo_IdSubTipo",
                        column: x => x.IdSubTipo,
                        principalSchema: "dbo",
                        principalTable: "ArticuloSubTipo",
                        principalColumn: "IdSubTipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalSchema: "dbo",
                        principalTable: "Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "ArticuloTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_ArticuloUnidadMedida_IdUnidadMedida",
                        column: x => x.IdUnidadMedida,
                        principalSchema: "dbo",
                        principalTable: "ArticuloUnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                schema: "dbo",
                columns: table => new
                {
                    IdCliente = table.Column<long>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    NombreFantasia = table.Column<string>(maxLength: 100, nullable: true),
                    Rol = table.Column<int>(nullable: false),
                    IdCondicionIva = table.Column<long>(nullable: false),
                    IdCondicionPago = table.Column<long>(nullable: true),
                    PercibirIB = table.Column<bool>(nullable: true),
                    AlicuotaIB = table.Column<double>(nullable: true),
                    IvaDiferencial = table.Column<bool>(nullable: true),
                    Grupo = table.Column<string>(maxLength: 50, nullable: true),
                    Zona = table.Column<string>(maxLength: 50, nullable: true),
                    IdTipo = table.Column<long>(nullable: true),
                    IdSubTipo = table.Column<long>(nullable: true),
                    IdRubro = table.Column<long>(nullable: true),
                    IdCategoria = table.Column<long>(nullable: true),
                    IdCompania = table.Column<long>(nullable: true),
                    IdEmpresa = table.Column<long>(nullable: true),
                    IdSucursal = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Ente_IdCliente",
                        column: x => x.IdCliente,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_ClienteCategoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalSchema: "dbo",
                        principalTable: "ClienteCategoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_CondicionIva_IdCondicionIva",
                        column: x => x.IdCondicionIva,
                        principalSchema: "dbo",
                        principalTable: "CondicionIva",
                        principalColumn: "IdCondicionIva",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_CondicionPago_IdCondicionPago",
                        column: x => x.IdCondicionPago,
                        principalSchema: "dbo",
                        principalTable: "CondicionPago",
                        principalColumn: "IdCondicionPago",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_ClienteRubro_IdRubro",
                        column: x => x.IdRubro,
                        principalSchema: "dbo",
                        principalTable: "ClienteRubro",
                        principalColumn: "IdRubro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_ClienteSubTipo_IdSubTipo",
                        column: x => x.IdSubTipo,
                        principalSchema: "dbo",
                        principalTable: "ClienteSubTipo",
                        principalColumn: "IdSubTipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalSchema: "dbo",
                        principalTable: "Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_ClienteTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "ClienteTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                schema: "dbo",
                columns: table => new
                {
                    IdProveedor = table.Column<long>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    IdCondicionIva = table.Column<long>(nullable: false),
                    IdCondicionPago = table.Column<long>(nullable: true),
                    IdCompania = table.Column<long>(nullable: true),
                    IdEmpresa = table.Column<long>(nullable: true),
                    IdSucursal = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                    table.ForeignKey(
                        name: "FK_Proveedor_Ente_IdProveedor",
                        column: x => x.IdProveedor,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_CondicionIva_IdCondicionIva",
                        column: x => x.IdCondicionIva,
                        principalSchema: "dbo",
                        principalTable: "CondicionIva",
                        principalColumn: "IdCondicionIva",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_CondicionPago_IdCondicionPago",
                        column: x => x.IdCondicionPago,
                        principalSchema: "dbo",
                        principalTable: "CondicionPago",
                        principalColumn: "IdCondicionPago",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalSchema: "dbo",
                        principalTable: "Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "dbo",
                columns: table => new
                {
                    IdUsuario = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    Usuario = table.Column<string>(maxLength: 128, nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false),
                    IdRol = table.Column<long>(nullable: false),
                    IdCompania = table.Column<long>(nullable: true),
                    IdEmpresa = table.Column<long>(nullable: true),
                    IdSucursal = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_IdRol",
                        column: x => x.IdRol,
                        principalSchema: "dbo",
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalSchema: "dbo",
                        principalTable: "Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                schema: "dbo",
                columns: table => new
                {
                    IdLocalidad = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    IdPais = table.Column<long>(nullable: false),
                    IdProvincia = table.Column<long>(nullable: false),
                    IdPartido = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.IdLocalidad);
                    table.ForeignKey(
                        name: "FK_Localidad_Partido_IdPartido",
                        column: x => x.IdPartido,
                        principalSchema: "dbo",
                        principalTable: "Partido",
                        principalColumn: "IdPartido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCabecera",
                schema: "dbo",
                columns: table => new
                {
                    IdOrdenCabecera = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    CodTipoOrden = table.Column<string>(maxLength: 50, nullable: false),
                    CodEstado = table.Column<string>(maxLength: 50, nullable: false),
                    IdCliente = table.Column<long>(nullable: false),
                    IdContacto = table.Column<long>(nullable: true),
                    NroOC = table.Column<string>(maxLength: 100, nullable: true),
                    NroComprobante = table.Column<string>(maxLength: 100, nullable: true),
                    Ubicacion = table.Column<string>(maxLength: 250, nullable: true),
                    Observaciones = table.Column<string>(maxLength: 1000, nullable: true),
                    EsUrgente = table.Column<bool>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaFinaliacion = table.Column<DateTime>(nullable: true),
                    FechaProcesamiento = table.Column<DateTime>(nullable: true),
                    FechaVencimiento = table.Column<DateTime>(nullable: true),
                    IdCompania = table.Column<long>(nullable: true),
                    IdEmpresa = table.Column<long>(nullable: true),
                    IdSucursal = table.Column<long>(nullable: true),
                    AudFechaCreacion = table.Column<DateTime>(nullable: false),
                    AudUsuarioCreacion = table.Column<string>(maxLength: 128, nullable: false),
                    AudFechaModificacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioModificacion = table.Column<string>(maxLength: 128, nullable: true),
                    AudFechaSincornizacion = table.Column<DateTime>(nullable: true),
                    AudUsuarioSincronizacion = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenCabecera", x => x.IdOrdenCabecera);
                    table.ForeignKey(
                        name: "FK_OrdenCabecera_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalSchema: "dbo",
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenCabecera_Compania_IdCompania",
                        column: x => x.IdCompania,
                        principalSchema: "dbo",
                        principalTable: "Compania",
                        principalColumn: "IdCompania",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenCabecera_Contacto_IdContacto",
                        column: x => x.IdContacto,
                        principalSchema: "dbo",
                        principalTable: "Contacto",
                        principalColumn: "IdContacto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenCabecera_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenCabecera_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalSchema: "dbo",
                        principalTable: "Sucursal",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnteDomicilio",
                schema: "dbo",
                columns: table => new
                {
                    IdDomicilio = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<bool>(nullable: false),
                    IdEnte = table.Column<long>(nullable: false),
                    IdTipo = table.Column<long>(nullable: false),
                    IdPais = table.Column<long>(nullable: false),
                    IdProvincia = table.Column<long>(nullable: false),
                    IdPartido = table.Column<long>(nullable: false),
                    IdLocalidad = table.Column<long>(nullable: false),
                    CodigoPostal = table.Column<string>(maxLength: 12, nullable: true),
                    Calle = table.Column<string>(maxLength: 128, nullable: false),
                    Numero = table.Column<string>(maxLength: 12, nullable: false),
                    Cuerpo = table.Column<string>(maxLength: 12, nullable: true),
                    Piso = table.Column<string>(maxLength: 12, nullable: true),
                    Departamento = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteDomicilio", x => x.IdDomicilio);
                    table.ForeignKey(
                        name: "FK_EnteDomicilio_Ente_IdEnte",
                        column: x => x.IdEnte,
                        principalSchema: "dbo",
                        principalTable: "Ente",
                        principalColumn: "IdEnte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnteDomicilio_Localidad_IdLocalidad",
                        column: x => x.IdLocalidad,
                        principalSchema: "dbo",
                        principalTable: "Localidad",
                        principalColumn: "IdLocalidad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnteDomicilio_EnteDomicilioTipo_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "dbo",
                        principalTable: "EnteDomicilioTipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDetalle",
                schema: "dbo",
                columns: table => new
                {
                    IdOrdenDetalle = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdOrdenCabecera = table.Column<long>(nullable: false),
                    Orden = table.Column<int>(nullable: false),
                    IdArticulo = table.Column<long>(nullable: false),
                    ArticuloCodigo = table.Column<string>(maxLength: 50, nullable: false),
                    ArticuloDescripcion = table.Column<string>(maxLength: 100, nullable: false),
                    ArticuloPrecio = table.Column<double>(nullable: false),
                    Cantidad = table.Column<double>(nullable: false),
                    CodEstado = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDetalle", x => x.IdOrdenDetalle);
                    table.ForeignKey(
                        name: "FK_OrdenDetalle_Articulo_IdArticulo",
                        column: x => x.IdArticulo,
                        principalSchema: "dbo",
                        principalTable: "Articulo",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDetalle_OrdenCabecera_IdOrdenCabecera",
                        column: x => x.IdOrdenCabecera,
                        principalSchema: "dbo",
                        principalTable: "OrdenCabecera",
                        principalColumn: "IdOrdenCabecera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdAlicuotaIva",
                schema: "dbo",
                table: "Articulo",
                column: "IdAlicuotaIva");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdAlicuotaIvaDiferencial",
                schema: "dbo",
                table: "Articulo",
                column: "IdAlicuotaIvaDiferencial");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdCategoria",
                schema: "dbo",
                table: "Articulo",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdCompania",
                schema: "dbo",
                table: "Articulo",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdEmpresa",
                schema: "dbo",
                table: "Articulo",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdLinea",
                schema: "dbo",
                table: "Articulo",
                column: "IdLinea");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdMarca",
                schema: "dbo",
                table: "Articulo",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdRubro",
                schema: "dbo",
                table: "Articulo",
                column: "IdRubro");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdSubTipo",
                schema: "dbo",
                table: "Articulo",
                column: "IdSubTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdSucursal",
                schema: "dbo",
                table: "Articulo",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdTipo",
                schema: "dbo",
                table: "Articulo",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdUnidadMedida",
                schema: "dbo",
                table: "Articulo",
                column: "IdUnidadMedida");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloSubTipo_IdTipo",
                schema: "dbo",
                table: "ArticuloSubTipo",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdCategoria",
                schema: "dbo",
                table: "Cliente",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdCompania",
                schema: "dbo",
                table: "Cliente",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdCondicionIva",
                schema: "dbo",
                table: "Cliente",
                column: "IdCondicionIva");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdCondicionPago",
                schema: "dbo",
                table: "Cliente",
                column: "IdCondicionPago");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdEmpresa",
                schema: "dbo",
                table: "Cliente",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdRubro",
                schema: "dbo",
                table: "Cliente",
                column: "IdRubro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdSubTipo",
                schema: "dbo",
                table: "Cliente",
                column: "IdSubTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdSucursal",
                schema: "dbo",
                table: "Cliente",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdTipo",
                schema: "dbo",
                table: "Cliente",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteSubTipo_IdTipo",
                schema: "dbo",
                table: "ClienteSubTipo",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_IdEnteRelacion",
                schema: "dbo",
                table: "Contacto",
                column: "IdEnteRelacion");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdCompania",
                schema: "dbo",
                table: "Empresa",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Ente_IdTipoDocumento",
                schema: "dbo",
                table: "Ente",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_EnteDomicilio_IdEnte",
                schema: "dbo",
                table: "EnteDomicilio",
                column: "IdEnte");

            migrationBuilder.CreateIndex(
                name: "IX_EnteDomicilio_IdLocalidad",
                schema: "dbo",
                table: "EnteDomicilio",
                column: "IdLocalidad");

            migrationBuilder.CreateIndex(
                name: "IX_EnteDomicilio_IdTipo",
                schema: "dbo",
                table: "EnteDomicilio",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_EnteTelefono_IdEnte",
                schema: "dbo",
                table: "EnteTelefono",
                column: "IdEnte");

            migrationBuilder.CreateIndex(
                name: "IX_EnteTelefono_IdTipo",
                schema: "dbo",
                table: "EnteTelefono",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_IdPartido",
                schema: "dbo",
                table: "Localidad",
                column: "IdPartido");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCaja_IdEnte",
                schema: "dbo",
                table: "MovimientoCaja",
                column: "IdEnte");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCabecera_IdCliente",
                schema: "dbo",
                table: "OrdenCabecera",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCabecera_IdCompania",
                schema: "dbo",
                table: "OrdenCabecera",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCabecera_IdContacto",
                schema: "dbo",
                table: "OrdenCabecera",
                column: "IdContacto");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCabecera_IdEmpresa",
                schema: "dbo",
                table: "OrdenCabecera",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCabecera_IdSucursal",
                schema: "dbo",
                table: "OrdenCabecera",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalle_IdArticulo",
                schema: "dbo",
                table: "OrdenDetalle",
                column: "IdArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalle_IdOrdenCabecera",
                schema: "dbo",
                table: "OrdenDetalle",
                column: "IdOrdenCabecera");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_IdProvincia",
                schema: "dbo",
                table: "Partido",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdCompania",
                schema: "dbo",
                table: "Proveedor",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdCondicionIva",
                schema: "dbo",
                table: "Proveedor",
                column: "IdCondicionIva");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdCondicionPago",
                schema: "dbo",
                table: "Proveedor",
                column: "IdCondicionPago");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdEmpresa",
                schema: "dbo",
                table: "Proveedor",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdSucursal",
                schema: "dbo",
                table: "Proveedor",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_IdPais",
                schema: "dbo",
                table: "Provincia",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_RolRecurso_IdRecurso",
                schema: "dbo",
                table: "RolRecurso",
                column: "IdRecurso");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_IdCompania",
                schema: "dbo",
                table: "Sucursal",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_IdEmpresa",
                schema: "dbo",
                table: "Sucursal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdCompania",
                schema: "dbo",
                table: "Usuario",
                column: "IdCompania");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdEmpresa",
                schema: "dbo",
                table: "Usuario",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                schema: "dbo",
                table: "Usuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdSucursal",
                schema: "dbo",
                table: "Usuario",
                column: "IdSucursal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnteDomicilio",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EnteTelefono",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Logs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MovimientoCaja",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrdenDetalle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Proveedor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RolRecurso",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Localidad",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EnteDomicilioTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EnteTelefonoTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Articulo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrdenCabecera",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RecursoSistema",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Rol",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Partido",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AlicuotaIva",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloCategoria",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloLinea",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloMarca",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloRubro",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloSubTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloUnidadMedida",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cliente",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Contacto",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Provincia",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArticuloTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClienteCategoria",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CondicionIva",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CondicionPago",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClienteRubro",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClienteSubTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Sucursal",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Ente",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Pais",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClienteTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Empresa",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EnteDocumentoTipo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Compania",
                schema: "dbo");
        }
    }
}
