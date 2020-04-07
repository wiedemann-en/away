using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class EnteDto : DtoBaseCode
    {
        #region Constructors
        public EnteDto()
        {
            TipoDocumento = new EnteDocumentoTipoDto();
            Domicilios = new List<EnteDomicilioDto>();
            Telefonos = new List<EnteTelefonoDto>();
            Contactos = new List<ContactoDto>();
        }
        #endregion

        #region Attributes
        public string ApellidoRazonSocial { get; set; }
        public string Nombre { get; set; }
        public EnteDocumentoTipoDto TipoDocumento { get; set; }
        public string NroFiscal { get; set; }
        public bool EsPersonaJuridica { get; set; }
        public string TipoEnte { get; set; }
        public List<EnteDomicilioDto> Domicilios { get; set; }
        public List<EnteTelefonoDto> Telefonos { get; set; }
        public List<ContactoDto> Contactos { get; set; }
        #endregion
    }
}
