using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Provider
{
    public class ProveedorModel : ModelBase, IRecordBusiness, IRecordAudit
    {
        #region Attributes
        public long IdCondicionIva { get; set; }
        public long? IdCondicionPago { get; set; }
        public long? IdCompania { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSucursal { get; set; }
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        public virtual CondicionIvaModel CondicionIva { get; set; }
        public virtual CondicionPagoModel CondicionPago { get; set; }
        public virtual CompaniaModel Compania { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public virtual SucursalModel Sucursal { get; set; }
        #endregion
    }
}
