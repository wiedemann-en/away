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
    public class ContactoRepository : Repository<ContactoModel>, IContactoRepository
    {
        #region Overrides
        protected override IQueryable<ContactoModel> SetDefaultIncludes(IQueryable<ContactoModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Ente.TipoDocumento")
                .Include("Ente.Domicilios.Tipo")
                .Include("Ente.Domicilios.Localidad.Partido.Provincia.Pais")
                .Include("Ente.Telefonos.Tipo");

            return queryConstruct;
        }
        #endregion
    }
}
