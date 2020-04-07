using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class ProvinciaRepository : Repository<ProvinciaModel>, IProvinciaRepository
    {
        #region Overrides
        protected override IQueryable<ProvinciaModel> SetDefaultIncludes(IQueryable<ProvinciaModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Pais");

            return queryConstruct;
        }
        #endregion
    }
}
