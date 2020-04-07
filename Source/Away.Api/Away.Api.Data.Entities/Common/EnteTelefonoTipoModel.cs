using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteTelefonoTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public EnteTelefonoTipoModel()
        {
            Telefonos = new List<EnteTelefonoModel>();
        }
        #endregion

        #region References
        public virtual List<EnteTelefonoModel> Telefonos { get; set; }
        #endregion
    }
}
