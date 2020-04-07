using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class ProvinciaModel : ModelBaseCodeName
    {
        #region Constructors
        public ProvinciaModel()
        {
            Partidos = new List<PartidoModel>();
        }
        #endregion

        #region Attributes
        public long IdPais { get; set; }
        #endregion

        #region References
        public virtual PaisModel Pais { get; set; }
        public List<PartidoModel> Partidos { get; set; }
        #endregion
    }
}
