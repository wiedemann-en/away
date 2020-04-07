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
    public class EmpresaRepository : Repository<EmpresaModel>, IEmpresaRepository
    {
        #region Overrides
        protected override IQueryable<EmpresaModel> SetDefaultIncludes(IQueryable<EmpresaModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Compania");

            return queryConstruct;
        }
        #endregion
    }
}
