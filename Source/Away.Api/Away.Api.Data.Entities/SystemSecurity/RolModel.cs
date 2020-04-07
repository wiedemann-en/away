using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.SystemSecurity
{
    public class RolModel : ModelBaseName, IRecordAudit
    {
        #region Constructors
        public RolModel()
        {
            Recursos = new List<RolRecursoModel>();
            Usuarios = new List<UsuarioModel>();
        }
        #endregion

        #region Attributes
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual List<RolRecursoModel> Recursos { get; set; }
        public virtual List<UsuarioModel> Usuarios { get; set; }
        #endregion
    }
}
