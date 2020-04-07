using Away.Api.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Client
{
    public class ClienteFacturacionDto
    {
        #region Constructors
        public ClienteFacturacionDto()
        {
            CondicionIva = new CondicionIvaDto();
            CondicionPago = new CondicionPagoDto();
        }
        #endregion

        #region Attributes
        public CondicionIvaDto CondicionIva { get; set; }
        public CondicionPagoDto CondicionPago { get; set; }
        public bool? PercibirIB { get; set; }
        public double? AlicuotaIB { get; set; }
        public bool? IvaDiferencial { get; set; }
        #endregion
    }
}
