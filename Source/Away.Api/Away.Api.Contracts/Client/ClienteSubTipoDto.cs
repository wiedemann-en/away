using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Client
{
    public class ClienteSubTipoDto : DtoBaseCodeName
    {
        #region Constructors
        public ClienteSubTipoDto()
        {
            Tipo = new ClienteTipoDto();
        }
        #endregion

        #region Attributes
        public ClienteTipoDto Tipo { get; set; }
        #endregion
    }
}
