using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Client
{
    public class ClienteTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public ClienteTipoModel()
        {
            Clientes = new List<ClienteModel>();
            SubTipos = new List<ClienteSubTipoModel>();
        }
        #endregion

        #region References
        public virtual List<ClienteModel> Clientes { get; set; }
        public virtual List<ClienteSubTipoModel> SubTipos { get; set; }
        #endregion
    }
}
