using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteDocumentoTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public EnteDocumentoTipoModel()
        {
            Entes = new List<EnteModel>();
        }
        #endregion

        #region References
        public virtual List<EnteModel> Entes { get; set; }
        #endregion
    }
}
