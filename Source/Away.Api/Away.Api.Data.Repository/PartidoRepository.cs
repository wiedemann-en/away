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
    public class PartidoRepository : Repository<PartidoModel>, IPartidoRepository
    {
        #region Overrides
        protected override IQueryable<PartidoModel> SetDefaultIncludes(IQueryable<PartidoModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Provincia.Pais");

            return queryConstruct;
        }
        #endregion
    }
}
