using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class ProveedorRepository : Repository<ProveedorModel>, IProveedorRepository
    {
        #region Overrides
        protected override IQueryable<ProveedorModel> SetDefaultIncludes(IQueryable<ProveedorModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("CondicionIva")
                .Include("CondicionPago")
                .Include("Compania")
                .Include("Empresa")
                .Include("Sucursal")
                .Include("Ente.TipoDocumento")
                .Include("Ente.Domicilios.Tipo")
                .Include("Ente.Domicilios.Localidad.Partido.Provincia.Pais")
                .Include("Ente.Telefonos.Tipo")
                .Include("Ente.Contactos.Ente.TipoDocumento");

            return queryConstruct;
        }
        #endregion
    }
}
