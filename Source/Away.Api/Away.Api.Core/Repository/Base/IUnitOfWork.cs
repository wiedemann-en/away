using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Core.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        TRepository RegisterRepository<TRepository>() where TRepository : IRepositoryBase, new();
        void BeginTransaction();
        int Commit();
        Task<int> CommitAsync();
        void Rollback();
        DataTable ExecuteQuery(string sqlQuery);
        void Dispose(bool disposing);
    }
}
