using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Business
{
    public class EmpresaModel : ModelBase, IRecordAudit
    {
        #region Constructors
        public EmpresaModel()
        {
            Sucursales = new List<SucursalModel>();
            Clientes = new List<ClienteModel>();
            Proveedores = new List<ProveedorModel>();
            Articulos = new List<ArticuloModel>();
            Usuarios = new List<UsuarioModel>();
            Ordenes = new List<OrdenCabeceraModel>();
        }
        #endregion

        #region Attributes
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public long IdCompania { get; set; }
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual CompaniaModel Compania { get; set; }
        public virtual List<SucursalModel> Sucursales { get; set; }
        public virtual List<ClienteModel> Clientes { get; set; }
        public virtual List<ProveedorModel> Proveedores { get; set; }
        public virtual List<ArticuloModel> Articulos { get; set; }
        public virtual List<UsuarioModel> Usuarios { get; set; }
        public virtual List<OrdenCabeceraModel> Ordenes { get; set; }
        #endregion
    }
}
