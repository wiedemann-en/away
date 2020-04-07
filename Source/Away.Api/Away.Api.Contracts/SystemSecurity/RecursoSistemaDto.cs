using Away.Api.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.SystemSecurity
{
    public class RecursoSistemaDto : DtoBase
    {
        #region Attributes
        public string AppState { get; set; }
        public string ApiName { get; set; }
        public string Permiso { get; set; }
        public string Descripcion { get; set; }
        public string AppStatePadre { get; set; }
        public string RecursosDependientes { get; set; }
        #endregion
    }
}
