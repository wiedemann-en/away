using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Data
{
    public interface IDataContext
    {
        void BeginTransaction();
        int Commit();
        Task<int> CommitAsync();
        void Rollback();
    }
}
