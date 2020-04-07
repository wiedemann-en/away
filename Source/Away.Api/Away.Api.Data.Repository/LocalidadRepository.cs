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
    public class LocalidadRepository : Repository<LocalidadModel>, ILocalidadRepository
    {
        #region Overrides
        protected override IQueryable<LocalidadModel> SetDefaultIncludes(IQueryable<LocalidadModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Partido.Provincia.Pais");

            return queryConstruct;
        }
        #endregion
    }
}
