using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class PaisModel : ModelBaseCodeName
    {
        #region Constructors
        public PaisModel()
        {
            Provincias = new List<ProvinciaModel>();
        }
        #endregion

        #region References
        public List<ProvinciaModel> Provincias { get; set; }
        #endregion
    }
}
