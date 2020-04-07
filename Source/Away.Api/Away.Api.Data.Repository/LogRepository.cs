using Away.Api.Core.Repository;
using Away.Api.Data.Entities;
using Away.Api.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class LogRepository : Repository<LogModel>, ILogRepository
    {
    }
}
