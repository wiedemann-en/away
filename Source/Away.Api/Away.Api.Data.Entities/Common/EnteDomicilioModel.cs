using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class EnteDomicilioModel : ModelBase
    {
        #region Attributes
        public long IdEnte { get; set; }
        public long IdTipo { get; set; }
        public long IdPais { get; set; }
        public long IdProvincia { get; set; }
        public long IdPartido { get; set; }
        public long IdLocalidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Cuerpo { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        #endregion

        #region References
        public virtual EnteModel Ente { get; set; }
        public virtual EnteDomicilioTipoModel Tipo { get; set; }
        public virtual LocalidadModel Localidad { get; set; }
        #endregion
    }
}
