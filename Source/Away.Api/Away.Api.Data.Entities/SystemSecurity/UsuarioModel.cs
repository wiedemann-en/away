using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.SystemSecurity
{
    public class UsuarioModel : ModelBase, IRecordBusiness, IRecordAudit
    {
        #region Attributes
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public long IdRol { get; set; }
        public long? IdCompania { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSucursal { get; set; }
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual RolModel Rol { get; set; }
        public virtual CompaniaModel Compania { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public virtual SucursalModel Sucursal { get; set; }
        #endregion
    }
}
