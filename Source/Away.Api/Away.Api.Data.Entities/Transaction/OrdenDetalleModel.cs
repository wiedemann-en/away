using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Transaction
{
    public class OrdenDetalleModel
    {
        #region Attributes
        public long Id { get; set; }
        public long IdOrdenCabecera { get; set; }
        public int Orden { get; set; }
        public long IdArticulo { get; set; }
        public string ArticuloCodigo { get; set; }
        public string ArticuloDescripcion { get; set; }
        public double ArticuloPrecio { get; set; }
        public double Cantidad { get; set; }
        public string CodEstado { get; set; }
        public string Observaciones { get; set; }
        #endregion

        #region References
        public virtual OrdenCabeceraModel OrdenCabecera { get; set; }
        public virtual ArticuloModel Articulo { get; set; }
        #endregion
    }
}
