using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.System
{
    public class LogDto : DtoBase
    {
        #region Attributes
        public string Tipo { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Detalle { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string TargetSite { get; set; }
        #endregion
    }
}
