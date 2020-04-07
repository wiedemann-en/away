using AutoMapper;
using Away.Api.Contracts;
using Away.Api.Contracts.System;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class LogService : ServiceBase<LogDto, LogModel>, ILogService
    {
        #region Constructors
        public LogService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<LogRepository>();
        }
        #endregion
    }
}
