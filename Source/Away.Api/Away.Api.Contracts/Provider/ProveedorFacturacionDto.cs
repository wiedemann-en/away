using Away.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Provider
{
    public class ProveedorFacturacionDto
    {
        #region Constructors
        public ProveedorFacturacionDto()
        {
            CondicionIva = new CondicionIvaDto();
            CondicionPago = new CondicionPagoDto();
        }
        #endregion

        #region Attributes
        public CondicionIvaDto CondicionIva { get; set; }
        public CondicionPagoDto CondicionPago { get; set; }
        #endregion
    }
}
