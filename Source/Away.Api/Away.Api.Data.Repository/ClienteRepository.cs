using Away.Api.Core.Repository;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Data.Repository
{
    public class ClienteRepository : Repository<ClienteModel>, IClienteRepository
    {
        #region Overrides
        protected override IQueryable<ClienteModel> SetDefaultIncludes(IQueryable<ClienteModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("CondicionIva")
                .Include("CondicionPago")
                .Include("Tipo")
                .Include("SubTipo")
                .Include("Rubro")
                .Include("Categoria")
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
