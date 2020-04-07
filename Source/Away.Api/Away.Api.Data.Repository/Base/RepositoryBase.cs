using Away.Api.Core.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Repository.Base
{
    public abstract class RepositoryBase : IRepositoryBase
    {
        #region Protected Attributes
        protected DataContext _context;
        protected bool _disposed;
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
                _context.Dispose();
            _disposed = true;
        }
        #endregion

        #region IRepositoryBase
        public abstract void SetContext(DbContext context);
        #endregion
    }
}
