using Away.Api.Contracts;
using Away.Api.Contracts.System;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Services
{
    public interface ILogService : IService<LogDto, LogModel>
    {
    }
}
