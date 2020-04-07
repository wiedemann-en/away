using Away.Api.Contracts.Base;
using Away.Api.Contracts.Common;
using Away.Api.Contracts.Segmentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Client
{
    public class ClienteDto : DtoBase, ISegmentacionNegocio
    {
        #region Constructors
        public ClienteDto()
        {
            Ente = new EnteDto();
            Facturacion = new ClienteFacturacionDto();
            Segmentacion = new ClienteSegmentacionDto();
            Negocio = new SegmentacionNegocioDto();
        }
        #endregion

        #region Attributes
        public string Email { get; set; }
        public string NombreFantasia { get; set; }
        public int Rol { get; set; }
        public EnteDto Ente { get; set; }
        public ClienteFacturacionDto Facturacion { get; set; }
        public ClienteSegmentacionDto Segmentacion { get; set; }
        public SegmentacionNegocioDto Negocio { get; set; }
        #endregion
    }
}
