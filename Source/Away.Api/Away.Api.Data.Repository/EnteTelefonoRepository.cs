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
    public class EnteTelefonoRepository : Repository<EnteTelefonoModel>, IEnteTelefonoRepository
    {
        #region Overrides
        protected override IQueryable<EnteTelefonoModel> SetDefaultIncludes(IQueryable<EnteTelefonoModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Tipo");

            return queryConstruct;
        }
        #endregion
    }
}
