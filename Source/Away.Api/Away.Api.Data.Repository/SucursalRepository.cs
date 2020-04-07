using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class SucursalRepository : Repository<SucursalModel>, ISucursalRepository
    {
        #region Overrides
        protected override IQueryable<SucursalModel> SetDefaultIncludes(IQueryable<SucursalModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Empresa.Compania");

            return queryConstruct;
        }
        #endregion
    }
}
