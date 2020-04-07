using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Article
{
    public class ArticuloRubroModel : ModelBaseCodeName
    {
        #region Constructors
        public ArticuloRubroModel()
        {
            Articulos = new List<ArticuloModel>();
        }
        #endregion

        #region References
        public virtual List<ArticuloModel> Articulos { get; set; }
        #endregion
    }
}
