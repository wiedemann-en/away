using Away.Api.Core.Repository;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class RolRepository : Repository<RolModel>, IRolRepository
    {
        #region Overrides
        protected override IQueryable<RolModel> SetDefaultIncludes(IQueryable<RolModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Recursos")
                .Include("Recursos.Recurso");

            return queryConstruct;
        }
        #endregion
    }
}
