using Away.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Article
{
    public class ArticuloFacturacionDto
    {
        #region Constructors
        public ArticuloFacturacionDto()
        {
            AlicuotaIva = new AlicuotaIvaDto();
            AlicuotaIvaDiferencial = new AlicuotaIvaDto();
        }
        #endregion

        #region Attributes
        public AlicuotaIvaDto AlicuotaIva { get; set; }
        public AlicuotaIvaDto AlicuotaIvaDiferencial { get; set; }
        public decimal? ImpuestosInternosPorc { get; set; }
        public decimal? ImpuestosInternosFijos { get; set; }
        public decimal? PercepcionIIBB { get; set; }
        #endregion
    }
}
