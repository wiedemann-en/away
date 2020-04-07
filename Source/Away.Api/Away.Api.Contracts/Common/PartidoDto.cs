using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class PartidoDto : DtoBaseCodeName
    {
        #region Constructors
        public PartidoDto()
        {
            Provincia = new ProvinciaDto();
        }
        #endregion

        #region Attributes
        public ProvinciaDto Provincia { get; set; }
        #endregion
    }
}
