using AutoMapper;
using Away.Api.Contracts.Client;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class ClienteCategoriaService : ServiceBase<ClienteCategoriaDto, ClienteCategoriaModel>, IClienteCategoriaService
    {
        #region Constructors
        public ClienteCategoriaService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<ClienteCategoriaRepository>();
        }
        #endregion
    }
}
