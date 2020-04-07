using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.SystemSecurity
{
    public class RolRecursoModel
    {
        #region Attributes
        public long IdRol { get; set; }
        public long IdRecurso { get; set; }
        #endregion

        #region References
        public virtual RolModel Rol { get; set; }
        public virtual RecursoSistemaModel Recurso { get; set; }
        #endregion
    }
}
