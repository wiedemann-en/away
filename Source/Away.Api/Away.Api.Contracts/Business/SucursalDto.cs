using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Business
{
    public class SucursalDto : DtoBaseName
    {
        #region Constructors
        public SucursalDto()
        {
            Empresa = new EmpresaDto();
        }
        #endregion

        #region Attributes
        public EmpresaDto Empresa { get; set; }
        #endregion
    }
}
