using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Common
{
    public class ContactoDto : DtoBase
    {
        #region Constructors
        public ContactoDto()
        {
            Ente = new EnteDto();
            EnteRelacion = new EnteDto();
        }
        #endregion

        #region Attributes
        public string Empresa { get; set; }
        public string Puesto { get; set; }
        public bool EsPrincipal { get; set; }
        public EnteDto Ente { get; set; }
        public EnteDto EnteRelacion { get; set; }
        #endregion
    }
}
