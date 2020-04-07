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
    public class EnteDomicilioRepository : Repository<EnteDomicilioModel>, IEnteDomicilioRepository
    {
        #region Overrides
        protected override IQueryable<EnteDomicilioModel> SetDefaultIncludes(IQueryable<EnteDomicilioModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Tipo")
                .Include("Localidad.Partido.Provincia.Pais");

            return queryConstruct;
        }
        #endregion
    }
}
