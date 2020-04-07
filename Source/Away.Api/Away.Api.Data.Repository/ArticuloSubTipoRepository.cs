using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Article;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class ArticuloSubTipoRepository : Repository<ArticuloSubTipoModel>, IArticuloSubTipoRepository
    {
        #region Overrides
        protected override IQueryable<ArticuloSubTipoModel> SetDefaultIncludes(IQueryable<ArticuloSubTipoModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Tipo");

            return queryConstruct;
        }
        #endregion
    }
}
