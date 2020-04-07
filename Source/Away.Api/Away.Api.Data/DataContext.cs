using Away.Api.Data.Entities;
using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Entities.Transaction;
using Away.Api.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Data
{
    public sealed class DataContext : DbContext, IDataContext
    {
        #region Private Attributes
        private IDbContextTransaction _transaction;
        private static bool _databaseInitialized;
        private static readonly object _lock = new object();
        #endregion

        #region Constructors
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            if (_databaseInitialized)
            {
                return;
            }
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    Database.OpenConnection();
                    _databaseInitialized = true;
                }
            }
        }
        #endregion

        #region DbSets
        public DbSet<AlicuotaIvaModel> AlicuotaIva { get; set; }
        public DbSet<ArticuloCategoriaModel> ArticuloCategoria { get; set; }
        public DbSet<ArticuloLineaModel> ArticuloLinea { get; set; }
        public DbSet<ArticuloMarcaModel> ArticuloMarca { get; set; }
        public DbSet<ArticuloModel> Articulo { get; set; }
        public DbSet<ArticuloRubroModel> ArticuloRubro { get; set; }
        public DbSet<ArticuloSubTipoModel> ArticuloSubTipo { get; set; }
        public DbSet<ArticuloTipoModel> ArticuloTipo { get; set; }
        public DbSet<ArticuloUnidadMedidaModel> ArticuloUnidadMedida { get; set; }
        public DbSet<ClienteCategoriaModel> ClienteCategoria { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ClienteRubroModel> ClienteRubro { get; set; }
        public DbSet<ClienteSubTipoModel> ClienteSubTipo { get; set; }
        public DbSet<ClienteTipoModel> ClienteTipo { get; set; }
        public DbSet<CompaniaModel> Compania { get; set; }
        public DbSet<CondicionIvaModel> CondicionIva { get; set; }
        public DbSet<CondicionPagoModel> CondicionPago { get; set; }
        public DbSet<ContactoModel> Contacto { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<EnteModel> Ente { get; set; }
        public DbSet<EnteDomicilioModel> EnteDomicilio { get; set; }
        public DbSet<EnteTelefonoModel> EnteTelefono { get; set; }
        public DbSet<EnteDocumentoTipoModel> EnteDocumentoTipo { get; set; }
        public DbSet<EnteDomicilioTipoModel> EnteDomicilioTipo { get; set; }
        public DbSet<EnteTelefonoTipoModel> EnteTelefonoTipo { get; set; }
        public DbSet<LocalidadModel> Localidad { get; set; }
        public DbSet<LogModel> Log { get; set; }
        public DbSet<MovimientoCajaModel> MovimientoCaja { get; set; }
        public DbSet<OrdenCabeceraModel> OrdenCabecera { get; set; }
        public DbSet<OrdenDetalleModel> OrdenDetalle { get; set; }
        public DbSet<PaisModel> Pais { get; set; }
        public DbSet<PartidoModel> Partido { get; set; }
        public DbSet<ProveedorModel> Proveedor { get; set; }
        public DbSet<ProvinciaModel> Provincia { get; set; }
        public DbSet<RecursoSistemaModel> RecursoSistema { get; set; }
        public DbSet<RolModel> Rol { get; set; }
        public DbSet<RolRecursoModel> RolRecurso { get; set; }
        public DbSet<SucursalModel> Sucursal { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        #endregion

        #region Overrides
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DbMapping.AlicuotaIvaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloCategoriaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloLineaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloMarcaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloRubroMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloSubTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ArticuloUnidadMedidaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ClienteCategoriaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ClienteMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ClienteRubroMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ClienteSubTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ClienteTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.CompaniaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.CondicionIvaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.CondicionPagoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ContactoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EmpresaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteDomicilioMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteTelefonoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteDocumentoTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteDomicilioTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.EnteTelefonoTipoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.LocalidadMap());
            modelBuilder.ApplyConfiguration(new DbMapping.LogMap());
            modelBuilder.ApplyConfiguration(new DbMapping.MovimientoCajaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.OrdenCabeceraMap());
            modelBuilder.ApplyConfiguration(new DbMapping.OrdenDetalleMap());
            modelBuilder.ApplyConfiguration(new DbMapping.PaisMap());
            modelBuilder.ApplyConfiguration(new DbMapping.PartidoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ProveedorMap());
            modelBuilder.ApplyConfiguration(new DbMapping.ProvinciaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.RecursoSistemaMap());
            modelBuilder.ApplyConfiguration(new DbMapping.RolMap());
            modelBuilder.ApplyConfiguration(new DbMapping.RolRecursoMap());
            modelBuilder.ApplyConfiguration(new DbMapping.SucursalMap());
            modelBuilder.ApplyConfiguration(new DbMapping.UsuarioMap());

            //modelBuilder.ApplyConfiguration(new DbMapping.RecordAuditMap());

            modelBuilder.Seed();
        }
        #endregion

        #region IDataContext
        public void BeginTransaction()
        {
            if ((Database.GetDbConnection().State == ConnectionState.Open) && (Database.CurrentTransaction != null))
                return;
            _transaction = Database.BeginTransaction();
        }

        public int Commit()
        {
            try
            {
                BeginTransaction();
                var saveChanges = SaveChanges();
                _transaction.Commit();

                return saveChanges;
            }
            catch (DbUpdateException)
            {
                Rollback();
                throw;
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
            finally
            {
                Dispose();
            }
        }

        public async Task<int> CommitAsync()
        {
            try
            {
                BeginTransaction();
                var saveChangesAsync = await SaveChangesAsync();
                _transaction.Commit();

                return saveChangesAsync;
            }
            catch (DbUpdateException)
            {
                Rollback();
                throw;
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
            finally
            {
                Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }
        #endregion
    }
}
