﻿using AutoMapper;
using Away.Api.Contracts.Common;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services
{
    public class CondicionIvaService : ServiceBase<CondicionIvaDto, CondicionIvaModel>, ICondicionIvaService
    {
        #region Constructors
        public CondicionIvaService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<CondicionIvaRepository>();
        }
        #endregion
    }
}
