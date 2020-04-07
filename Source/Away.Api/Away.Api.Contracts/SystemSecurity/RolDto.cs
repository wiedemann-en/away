using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.SystemSecurity
{
    public class RolDto : DtoBaseName
    {
        #region Constructors
        public RolDto()
        {
            Recursos = new List<RecursoSistemaDto>();
        }
        #endregion

        #region Attributes
        public List<RecursoSistemaDto> Recursos { get; set; }
        #endregion
    }
}
