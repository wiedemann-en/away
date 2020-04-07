using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Article
{
    public class ArticuloSubTipoDto : DtoBaseCodeName
    {
        #region Constructors
        public ArticuloSubTipoDto()
        {
            Tipo = new ArticuloTipoDto();
        }
        #endregion

        #region Attributes
        public ArticuloTipoDto Tipo { get; set; }
        #endregion
    }
}
