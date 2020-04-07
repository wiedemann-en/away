using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Client
{
    public class ClienteModel : ModelBase, IRecordBusiness, IRecordAudit
    {
        #region Constructors
        public ClienteModel()
        {
            Ordenes = new List<OrdenCabeceraModel>();
        }
        #endregion

        #region Attributes
        public string Email { get; set; }
        public string NombreFantasia { get; set; }
        public int Rol { get; set; }

        /// <summary>
        /// Facturación
        /// </summary>
        public long IdCondicionIva { get; set; }
        public long? IdCondicionPago { get; set; }
        public bool? PercibirIB { get; set; }
        public double? AlicuotaIB { get; set; }
        public bool? IvaDiferencial { get; set; }

        /// <summary>
        /// Segmentación
        /// </summary>
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public long? IdTipo { get; set; }
        public long? IdSubTipo { get; set; }
        public long? IdRubro { get; set; }
        public long? IdCategoria { get; set; }

        /// <summary>
        /// Segmentación Negocio
        /// </summary>
        public long? IdCompania { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSucursal { get; set; }

        /// <summary>
        /// Audit
        /// </summary>
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        public virtual CondicionIvaModel CondicionIva { get; set; }
        public virtual CondicionPagoModel CondicionPago { get; set; }
        public virtual ClienteTipoModel Tipo { get; set; }
        public virtual ClienteSubTipoModel SubTipo { get; set; }
        public virtual ClienteRubroModel Rubro { get; set; }
        public virtual ClienteCategoriaModel Categoria { get; set; }
        public virtual CompaniaModel Compania { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public virtual SucursalModel Sucursal { get; set; }
        public virtual List<OrdenCabeceraModel> Ordenes { get; set; }
        #endregion
    }
}
