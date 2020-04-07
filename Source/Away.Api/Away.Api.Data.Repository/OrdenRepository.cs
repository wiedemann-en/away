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
    public class OrdenRepository : Repository<OrdenCabeceraModel>, IOrdenRepository
    {
        #region Overrides
        protected override IQueryable<OrdenCabeceraModel> SetDefaultIncludes(IQueryable<OrdenCabeceraModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Cliente.TipoDocumento")
                .Include("Contacto.TipoDocumento")
                .Include("Compania")
                .Include("Empresa")
                .Include("Sucursal")
                .Include("Detalles.Articulo");

            return queryConstruct;
        }
        #endregion
    }
}
