using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Transaction
{
    public class MovimientoCajaModel : ModelBase, IRecordAudit
    {
        #region Attributes
        public long IdEnte { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Importe { get; set; }
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        #endregion
    }
}
