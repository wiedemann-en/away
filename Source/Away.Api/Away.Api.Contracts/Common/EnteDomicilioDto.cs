using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class EnteDomicilioDto : DtoBase
    {
        #region Constructors
        public EnteDomicilioDto()
        {
            Tipo = new EnteDomicilioTipoDto();
            Localidad = new LocalidadDto();
        }
        #endregion

        #region Attributes
        public EnteDomicilioTipoDto Tipo { get; set; }
        public LocalidadDto Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Cuerpo { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        #endregion
    }
}
