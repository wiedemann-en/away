using Away.Api.Contracts.Base;
using Away.Api.Contracts.Client;
using Away.Api.Contracts.Common;
using Away.Api.Contracts.Segmentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Transaction
{
    public class OrdenCabeceraDto : DtoBase, ISegmentacionNegocio
    {
        #region Constructors
        public OrdenCabeceraDto()
        {
            Cliente = new ClienteDto();
            Contacto = new ContactoDto();
            Negocio = new SegmentacionNegocioDto();
            Detalles = new List<OrdenDetalleDto>();
        }
        #endregion

        #region Attributes
        public string CodTipoOrden { get; set; }
        public string CodEstado { get; set; }
        public ClienteDto Cliente { get; set; }
        public ContactoDto Contacto { get; set; }
        public string NroOC { get; set; }
        public string NroComprobante { get; set; }
        public string Ubicacion { get; set; }
        public string Observaciones { get; set; }
        public bool EsUrgente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaFinaliacion { get; set; }
        public DateTime? FechaProcesamiento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public SegmentacionNegocioDto Negocio { get; set; }
        public List<OrdenDetalleDto> Detalles { get; set; }
        #endregion
    }
}
