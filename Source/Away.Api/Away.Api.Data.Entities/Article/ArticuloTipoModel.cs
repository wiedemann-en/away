using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Article
{
    public class ArticuloTipoModel : ModelBaseCodeName
    {
        #region Constructors
        public ArticuloTipoModel()
        {
            Articulos = new List<ArticuloModel>();
            SubTipos = new List<ArticuloSubTipoModel>();
        }
        #endregion

        #region References
        public virtual List<ArticuloModel> Articulos { get; set; }
        public virtual List<ArticuloSubTipoModel> SubTipos { get; set; }
        #endregion
    }
}
