using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Article
{
    public class ArticuloSubTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public ArticuloSubTipoModel()
        {
            Articulos = new List<ArticuloModel>();
        }
        #endregion

        #region Attributes
        public long IdTipo { get; set; }
        #endregion

        #region References
        public virtual ArticuloTipoModel Tipo { get; set; }
        public virtual List<ArticuloModel> Articulos { get; set; }
        #endregion
    }
}
