using Away.Api.Core.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Data.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Attributes
        private readonly DataContext _context;
        private readonly Hashtable _repositories;
        private bool _disposed;
        #endregion

        #region Constructors
        public UnitOfWork(DataContext context)
        {
            _context = context;
            _repositories = new Hashtable();
        }
        #endregion

        #region IUnitOfWork
        public TRepository RegisterRepository<TRepository>() where TRepository : IRepositoryBase, new()
        {
            var type = typeof(TRepository).Name;
            if (_repositories.ContainsKey(type))
                return (TRepository)_repositories[type];

            var repository = new TRepository();
            repository.SetContext(_context);
            _repositories.Add(type, repository);

            return (TRepository)_repositories[type];
        }

        public void BeginTransaction()
        {
            _context.BeginTransaction();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Rollback()
        {
            _context.Rollback();
        }

        public DataTable ExecuteQuery(string sqlQuery)
        {
            var result = new DataTable();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                _context.Database.OpenConnection();
                command.CommandText = sqlQuery;
                var dataReader = command.ExecuteReader();
                result.Load(dataReader);
            }
            return result;
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
                if (_repositories != null)
                    foreach (IDisposable repository in _repositories.Values)
                        repository.Dispose();
            }
            _disposed = true;
        }
        #endregion
    }
}
