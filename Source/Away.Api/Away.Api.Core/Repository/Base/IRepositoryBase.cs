using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Repository.Base
{
    public interface IRepositoryBase : IDisposable
    {
        void SetContext(DbContext context);
    }
}
