using Away.Api.Contracts.Base;
using Away.Api.Contracts.Segmentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Article
{
    public class ArticuloDto : DtoBaseCode, ISegmentacionNegocio
    {
        #region Constructors
        public ArticuloDto()
        {
            Stock = new ArticuloStockDto();
            Facturacion = new ArticuloFacturacionDto();
            Segmentacion = new ArticuloSegmentacionDto();
            Negocio = new SegmentacionNegocioDto();
        }
        #endregion

        #region Attributes
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Presentacion { get; set; }
        public string Color { get; set; }
        public string CodigoEANBulto { get; set; }
        public string CodigoEANUnidad { get; set; }
        public string CodigoEANFraccion { get; set; }
        public ArticuloStockDto Stock { get; set; }
        public ArticuloFacturacionDto Facturacion { get; set; }
        public ArticuloSegmentacionDto Segmentacion { get; set; }
        public SegmentacionNegocioDto Negocio { get; set; }
        public bool EsCompuesto { get; set; }
        public bool EsLibreDescripcion { get; set; }
        public bool EsDeOferta { get; set; }
        #endregion
    }
}
