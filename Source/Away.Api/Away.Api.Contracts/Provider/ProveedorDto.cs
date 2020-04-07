using Away.Api.Contracts.Base;
using Away.Api.Contracts.Common;
using Away.Api.Contracts.Segmentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Provider
{
    public class ProveedorDto : DtoBase, ISegmentacionNegocio
    {
        #region Constructors
        public ProveedorDto()
        {
            Ente = new EnteDto();
            Facturacion = new ProveedorFacturacionDto();
            Negocio = new SegmentacionNegocioDto();
        }
        #endregion

        #region Attributes
        public EnteDto Ente { get; set; }
        public ProveedorFacturacionDto Facturacion { get; set; }
        public SegmentacionNegocioDto Negocio { get; set; }
        #endregion
    }
}
