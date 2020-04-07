using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Transaction;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class MovimientoCajaRepository : Repository<MovimientoCajaModel>, IMovimientoCajaRepository
    {
        #region Overrides
        protected override IQueryable<MovimientoCajaModel> SetDefaultIncludes(IQueryable<MovimientoCajaModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Ente.TipoDocumento");

            return queryConstruct;
        }
        #endregion
    }
}
