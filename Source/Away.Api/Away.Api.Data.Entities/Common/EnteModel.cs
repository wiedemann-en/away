using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteModel : ModelBaseCode, IRecordAudit
    {
        #region Constructors
        public EnteModel()
        {
            Domicilios = new List<EnteDomicilioModel>();
            Telefonos = new List<EnteTelefonoModel>();
            Contactos = new List<ContactoModel>();
            Movimientos = new List<MovimientoCajaModel>();
        }
        #endregion

        #region Attributes
        public string ApellidoRazonSocial { get; set; }
        public string Nombre { get; set; }
        public long IdTipoDocumento { get; set; }
        public string NroFiscal { get; set; }
        public bool EsPersonaJuridica { get; set; }
        public string TipoEnte { get; set; }

        /// <summary>
        /// Audit
        /// </summary>
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual ClienteModel Cliente { get; set; }
        public virtual ProveedorModel Proveedor { get; set; }
        public virtual ContactoModel Contacto { get; set; }
        public virtual EnteDocumentoTipoModel TipoDocumento { get; set; }
        public virtual List<EnteDomicilioModel> Domicilios { get; set; }
        public virtual List<EnteTelefonoModel> Telefonos { get; set; }
        public virtual List<ContactoModel> Contactos { get; set; }
        public virtual List<MovimientoCajaModel> Movimientos { get; set; }
        #endregion
    }
}
