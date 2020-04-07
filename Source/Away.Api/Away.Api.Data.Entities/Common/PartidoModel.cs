using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class PartidoModel : ModelBaseCodeName
    {
        #region Constructors
        public PartidoModel()
        {
            Localidades = new List<LocalidadModel>();
        }
        #endregion

        #region Attributes
        public long IdPais { get; set; }
        public long IdProvincia { get; set; }
        #endregion

        #region References
        public virtual ProvinciaModel Provincia { get; set; }
        public List<LocalidadModel> Localidades { get; set; }
        #endregion
    }
}
