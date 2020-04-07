using AutoMapper;
using Away.Api.Contracts.Business;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class SucursalService : ServiceBase<SucursalDto, SucursalModel>, ISucursalService
    {
        #region Constructors
        public SucursalService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<SucursalRepository>();
        }
        #endregion
    }
}
