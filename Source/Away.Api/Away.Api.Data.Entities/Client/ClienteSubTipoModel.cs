using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Client
{
    public class ClienteSubTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public ClienteSubTipoModel()
        {
            Clientes = new List<ClienteModel>();
        }
        #endregion

        #region Attributes
        public long IdTipo { get; set; }
        #endregion

        #region References
        public virtual ClienteTipoModel Tipo { get; set; }
        public virtual List<ClienteModel> Clientes { get; set; }
        #endregion
    }
}
