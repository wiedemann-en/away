using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Article
{
    public class ArticuloLineaModel : ModelBaseCodeName
    {
        #region Constructors
        public ArticuloLineaModel()
        {
            Articulos = new List<ArticuloModel>();
        }
        #endregion

        #region References
        public virtual List<ArticuloModel> Articulos { get; set; }
        #endregion
    }
}
