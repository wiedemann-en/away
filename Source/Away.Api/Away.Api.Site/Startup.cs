using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Away.Api.Core.Logger;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data;
using Away.Api.Data.Repository.Base;
using Away.Api.Logger.Infrastructure;
using Away.Api.Logger.Logic;
using Away.Api.Services;
using Away.Api.Site.Logic.Context;
using Away.Api.Site.Models.Common;
using Away.Api.Site.Models.Infraestructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Away.Api.Site
{
    public class Startup
    {
        #region Public Attributes
        public IConfiguration Configuration { get; }
        #endregion

        #region Constructors
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                builder => builder
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowCredentials()
                    .AllowAnyMethod());
            });

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.Configure<LoggerAppSettings>(Configuration.GetSection("LoggerAppSettings"));
            services.Configure<JwtIssuerOptions>(Configuration.GetSection("JwtIssuerOptions"));

            services.AddScoped<IAlicuotaIvaService, AlicuotaIvaService>();
            services.AddScoped<IArticuloCategoriaService, ArticuloCategoriaService>();
            services.AddScoped<IArticuloLineaService, ArticuloLineaService>();
            services.AddScoped<IArticuloMarcaService, ArticuloMarcaService>();
            services.AddScoped<IArticuloRubroService, ArticuloRubroService>();
            services.AddScoped<IArticuloService, ArticuloService>();
            services.AddScoped<IArticuloSubTipoService, ArticuloSubTipoService>();
            services.AddScoped<IArticuloTipoService, ArticuloTipoService>();
            services.AddScoped<IArticuloUnidadMedidaService, ArticuloUnidadMedidaService>();
            services.AddScoped<IClienteCategoriaService, ClienteCategoriaService>();
            services.AddScoped<IClienteRubroService, ClienteRubroService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteSubTipoService, ClienteSubTipoService>();
            services.AddScoped<IClienteTipoService, ClienteTipoService>();
            services.AddScoped<ICompaniaService, CompaniaService>();
            services.AddScoped<ICondicionIvaService, CondicionIvaService>();
            services.AddScoped<ICondicionPagoService, CondicionPagoService>();
            services.AddScoped<IContactoService, ContactoService>();
            services.AddScoped<IEnteDocumentoTipoService, EnteDocumentoTipoService>();
            services.AddScoped<IEnteDomicilioTipoService, EnteDomicilioTipoService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<ILocalidadService, LocalidadService>();
            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IMovimientoCajaService, MovimientoCajaService>();
            services.AddScoped<IOrdenService, OrdenService>();
            services.AddScoped<IPaisService, PaisService>();
            services.AddScoped<IPartidoService, PartidoService>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IProvinciaService, ProvinciaService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<ISucursalService, SucursalService>();
            services.AddScoped<IEnteTelefonoTipoService, EnteTelefonoTipoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICurrentContext>(im => CurrentContextResolver.GetCurrentContext());
            services.AddHttpContextAccessor();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var loggerAppSettings = Configuration.GetSection("LoggerAppSettings").Get<LoggerAppSettings>();
            if (loggerAppSettings.LogMode.ToUpper() == "DB")
            {
                services.AddScoped<ILogger, LoggerDb>();
            }
            else if (loggerAppSettings.LogMode.ToUpper() == "FILE")
            {
                services.AddScoped<ILogger, LoggerFile>();
            }

            var appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = false,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        RequireExpirationTime = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();

            app.UseCors("AllowSpecificOrigin");

            app.UseStatusCodePages(async context =>
            {
                context.HttpContext.Response.ContentType = "application/json";
                var result = new ResultDto();
                result.AddError(string.Format("status code: {0}", context.HttpContext.Response.StatusCode));
                await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));
            });

            app.UseExceptionHandler(appBuilder =>
            {
                appBuilder.Use(async (context, next) =>
                {
                    var error = context.Features[typeof(IExceptionHandlerFeature)] as IExceptionHandlerFeature;

                    //when authorization has failed, should retrun a json message to client
                    if (error?.Error is SecurityTokenExpiredException)
                    {
                        context.Response.StatusCode = 401;
                        context.Response.ContentType = "application/json";

                        var result = new ResultDto();
                        result.AddError("El token expiró");
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                    }
                    else if (error?.Error is SecurityTokenValidationException)
                    {
                        context.Response.StatusCode = 401;
                        context.Response.ContentType = "application/json";

                        var result = new ResultDto();
                        result.AddError("El token no es válido!!");
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                    }
                    else if (error?.Error != null)
                    {
                        context.Response.StatusCode = 500;
                        context.Response.ContentType = "application/json";

                        var result = new ResultDto();
                        result.AddError(error.Error.Message);
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                    }
                    //when no error, do next.
                    else await next();
                });
            });

            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                if (context.Database.GetPendingMigrations().ToList().Count > 0)
                    context.Database.Migrate();
            }

            CurrentContextResolver.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());
            AwayAppContext.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());
        }
    }
}
