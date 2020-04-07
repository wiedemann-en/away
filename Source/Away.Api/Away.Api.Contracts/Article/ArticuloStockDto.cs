using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Article
{
    public class ArticuloStockDto
    {
        #region Constructors
        public ArticuloStockDto()
        {
            UnidadMedida = new ArticuloUnidadMedidaDto();
        }
        #endregion

        #region Attributes
        public bool GestionaStock { get; set; }
        public int UnidadesXBulto { get; set; }
        public int? BultosXPallet { get; set; }
        public ArticuloUnidadMedidaDto UnidadMedida { get; set; }
        #endregion
    }
}
