using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class ContactoModel : ModelBase, IRecordAudit
    {
        #region Constructors
        public ContactoModel()
        {
            Ordenes = new List<OrdenCabeceraModel>();
        }
        #endregion

        #region Attributes
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public bool EsPrincipal { get; set; }
        public long? IdEnteRelacion { get; set; }
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        public virtual EnteModel EnteRelacion { get; set; }
        public virtual List<OrdenCabeceraModel> Ordenes { get; set; }
        #endregion
    }
}
