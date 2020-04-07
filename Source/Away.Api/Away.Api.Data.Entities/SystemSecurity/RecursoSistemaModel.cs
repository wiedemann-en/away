using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.SystemSecurity
{
    public class RecursoSistemaModel : ModelBase
    {
        #region Constructors
        public RecursoSistemaModel()
        {
            RolRecursos = new List<RolRecursoModel>();
        }
        #endregion

        #region Attributes
        public string AppState { get; set; }
        public string ApiName { get; set; }
        public string Permiso { get; set; }
        public string Descripcion { get; set; }
        public string AppStatePadre { get; set; }
        public string RecursosDependientes { get; set; }
        #endregion

        #region References
        public virtual List<RolRecursoModel> RolRecursos { get; set; }
        #endregion
    }
}
