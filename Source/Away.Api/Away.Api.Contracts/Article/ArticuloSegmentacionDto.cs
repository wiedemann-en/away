using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Article
{
    public class ArticuloSegmentacionDto
    {
        #region Constructors
        public ArticuloSegmentacionDto()
        {
            Tipo = new ArticuloTipoDto();
            SubTipo = new ArticuloSubTipoDto();
            Rubro = new ArticuloRubroDto();
            Categoria = new ArticuloCategoriaDto();
            Linea = new ArticuloLineaDto();
            Marca = new ArticuloMarcaDto();
        }
        #endregion

        #region Attributes
        public string Familia { get; set; }
        public string Grupo { get; set; }
        public ArticuloTipoDto Tipo { get; set; }
        public ArticuloSubTipoDto SubTipo { get; set; }
        public ArticuloRubroDto Rubro { get; set; }
        public ArticuloCategoriaDto Categoria { get; set; }
        public ArticuloLineaDto Linea { get; set; }
        public ArticuloMarcaDto Marca { get; set; }
        #endregion
    }
}
