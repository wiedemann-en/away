using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Client
{
    public class ClienteRubroModel : ModelBaseCodeName
    {
        #region Constructors
        public ClienteRubroModel()
        {
            Clientes = new List<ClienteModel>();
        }
        #endregion

        #region References
        public virtual List<ClienteModel> Clientes { get; set; }
        #endregion
    }
}
