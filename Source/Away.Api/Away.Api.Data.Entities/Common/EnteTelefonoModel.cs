using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteTelefonoModel : ModelBase
    {
        #region Attributes
        public long IdEnte { get; set; }
        public long IdTipo { get; set; }
        public string CodigoArea { get; set; }
        public string Numero { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        public virtual EnteTelefonoTipoModel Tipo { get; set; }
        #endregion
    }
}
