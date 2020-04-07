using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class ClienteSubTipoRepository : Repository<ClienteSubTipoModel>, IClienteSubTipoRepository
    {
        #region Overrides
        protected override IQueryable<ClienteSubTipoModel> SetDefaultIncludes(IQueryable<ClienteSubTipoModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Tipo");

            return queryConstruct;
        }
        #endregion
    }
}
