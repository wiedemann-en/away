using Away.Api.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Transaction
{
    public class OrdenDetalleDto
    {
        #region Csontructors
        public OrdenDetalleDto()
        {
            Articulo = new ArticuloDto();
        }
        #endregion

        #region Attributes
        public long Id { get; set; }
        public long IdOrdenCabecera { get; set; }
        public int Orden { get; set; }
        public ArticuloDto Articulo { get; set; }
        public string ArticuloCodigo { get; set; }
        public string ArticuloDescripcion { get; set; }
        public double ArticuloPrecio { get; set; }
        public double Cantidad { get; set; }
        public string CodEstado { get; set; }
        public string Observaciones { get; set; }
        #endregion
    }
}
