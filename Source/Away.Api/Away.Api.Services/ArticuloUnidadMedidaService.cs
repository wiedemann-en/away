using AutoMapper;
using Away.Api.Contracts.Article;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Article;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class ArticuloUnidadMedidaService : ServiceBase<ArticuloUnidadMedidaDto, ArticuloUnidadMedidaModel>, IArticuloUnidadMedidaService
    {
        #region Constructors
        public ArticuloUnidadMedidaService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<ArticuloUnidadMedidaRepository>();
        }
        #endregion
    }
}
