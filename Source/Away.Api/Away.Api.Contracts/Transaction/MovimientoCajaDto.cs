using Away.Api.Contracts.Base;
using Away.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Transaction
{
    public class MovimientoCajaDto : DtoBase
    {
        #region Csontructors
        public MovimientoCajaDto()
        {
            Ente = new EnteDto();
        }
        #endregion

        #region Attributes
        public EnteDto Ente { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Importe { get; set; }
        #endregion
    }
}
