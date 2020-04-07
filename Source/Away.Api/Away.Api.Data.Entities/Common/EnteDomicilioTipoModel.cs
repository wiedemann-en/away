using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteDomicilioTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public EnteDomicilioTipoModel()
        {
            Domicilios = new List<EnteDomicilioModel>();
        }
        #endregion

        #region References
        public virtual List<EnteDomicilioModel> Domicilios { get; set; }
        #endregion
    }
}
