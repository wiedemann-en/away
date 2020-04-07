using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Business
{
    public class EmpresaDto : DtoBase
    {
        #region Constructors
        public EmpresaDto()
        {
            Compania = new CompaniaDto();
        }
        #endregion

        #region Attributes
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public CompaniaDto Compania { get; set; }
        #endregion
    }
}
