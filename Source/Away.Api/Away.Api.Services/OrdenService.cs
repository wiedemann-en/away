using AutoMapper;
using Away.Api.Contracts.Transaction;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Transaction;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class OrdenService : ServiceBase<OrdenCabeceraDto, OrdenCabeceraModel>, IOrdenService
    {
        #region Constructors
        public OrdenService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<OrdenRepository>();
        }
        #endregion
    }
}
