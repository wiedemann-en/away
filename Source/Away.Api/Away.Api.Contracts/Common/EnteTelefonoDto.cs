using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class EnteTelefonoDto : DtoBase
    {
        #region Constructors
        public EnteTelefonoDto()
        {
            Tipo = new EnteTelefonoTipoDto();
        }
        #endregion

        #region Attributes
        public EnteTelefonoTipoDto Tipo { get; set; }
        public string CodigoArea { get; set; }
        public string Numero { get; set; }
        #endregion
    }
}
