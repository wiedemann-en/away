using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class AlicuotaIvaModel : ModelBaseCodeName
    {
        #region Constructors
        public AlicuotaIvaModel()
        {
            Articulos = new List<ArticuloModel>();
            ArticulosDiferencial = new List<ArticuloModel>();
        }
        #endregion

        #region Attributes
        public double Alicuota { get; set; }
        #endregion

        #region References
        public virtual List<ArticuloModel> Articulos { get; set; }
        public virtual List<ArticuloModel> ArticulosDiferencial { get; set; }
        #endregion
    }
}
