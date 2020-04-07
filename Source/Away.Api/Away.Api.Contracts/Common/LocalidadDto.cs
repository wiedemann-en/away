using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class LocalidadDto : DtoBaseCodeName
    {
        #region Constructors
        public LocalidadDto()
        {
            Partido = new PartidoDto();
        }
        #endregion

        #region Attributes
        public PartidoDto Partido { get; set; }
        #endregion
    }
}
