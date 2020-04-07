using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class LocalidadModel : ModelBaseCodeName
    {
        #region Constructors
        public LocalidadModel()
        {
            Domicilios = new List<EnteDomicilioModel>();
        }
        #endregion

        #region Attributes
        public long IdPais { get; set; }
        public long IdProvincia { get; set; }
        public long IdPartido { get; set; }
        #endregion

        #region References
        public virtual PartidoModel Partido { get; set; }
        public virtual List<EnteDomicilioModel> Domicilios { get; set; }
        #endregion
    }
}
