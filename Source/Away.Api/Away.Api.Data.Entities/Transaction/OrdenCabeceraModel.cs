using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Transaction
{
    public class OrdenCabeceraModel : ModelBase, IRecordBusiness, IRecordAudit
    {
        #region Constructors
        public OrdenCabeceraModel()
        {
            Detalles = new List<OrdenDetalleModel>();
        }
        #endregion

        #region Attributes
        /// <summary>
        /// Datos de la Orden
        /// </summary>
        public string CodTipoOrden { get; set; }
        public string CodEstado { get; set; }
        public long IdCliente { get; set; }
        public long? IdContacto { get; set; }
        public string NroOC { get; set; }
        public string NroComprobante { get; set; }
        public string Ubicacion { get; set; }
        public string Observaciones { get; set; }
        public bool EsUrgente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaFinaliacion { get; set; }
        public DateTime? FechaProcesamiento { get; set; }
        public DateTime? FechaVencimiento { get; set; }

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
        public virtual ClienteModel Cliente { get; set; }
        public virtual ContactoModel Contacto { get; set; }
        public virtual CompaniaModel Compania { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public virtual SucursalModel Sucursal { get; set; }
        public virtual List<OrdenDetalleModel> Detalles { get; set; }
        #endregion
    }
}
