using Away.Api.Contracts.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Segmentation
{
    public class SegmentacionNegocioDto
    {
        #region Attributes
        public CompaniaDto Compania { get; set; }
        public EmpresaDto Empresa { get; set; }
        public SucursalDto Sucursal { get; set; }
        #endregion
    }
}
