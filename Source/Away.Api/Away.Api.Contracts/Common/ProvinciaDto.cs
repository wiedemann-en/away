using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class ProvinciaDto : DtoBaseCodeName
    {
        #region Constructors
        public ProvinciaDto()
        {
            Pais = new PaisDto();
        }
        #endregion

        #region Attributes
        public PaisDto Pais { get; set; }
        #endregion
    }
}
