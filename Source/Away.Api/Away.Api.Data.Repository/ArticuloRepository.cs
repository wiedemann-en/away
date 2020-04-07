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
    public class ArticuloRepository : Repository<ArticuloModel>, IArticuloRepository
    {
        #region Overrides
        protected override IQueryable<ArticuloModel> SetDefaultIncludes(IQueryable<ArticuloModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Tipo")
                .Include("SubTipo")
                .Include("Rubro")
                .Include("Categoria")
                .Include("Linea")
                .Include("Marca")
                .Include("UnidadMedida")
                .Include("AlicuotaIva")
                .Include("AlicuotaIvaDiferencial")
                .Include("Compania")
                .Include("Empresa")
                .Include("Sucursal");

            return queryConstruct;
        }
        #endregion
    }
}
