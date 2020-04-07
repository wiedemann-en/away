using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class CondicionPagoDto : DtoBaseCodeName
    {
        #region Attributes
        public int Dias { get; set; }
        #endregion
    }
}
