using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Audit
{
    public class RecordAudit
    {
        #region Attributes
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaSincornizacion { get; set; }
        public string UsuarioSincronizacion { get; set; }
        #endregion

        #region Public Methods
        public RecordAudit Clone()
        {
            var result = new RecordAudit();
            result.FechaCreacion = FechaCreacion;
            result.UsuarioCreacion = UsuarioCreacion;
            result.FechaModificacion = FechaModificacion;
            result.UsuarioModificacion = UsuarioModificacion;
            result.FechaSincornizacion = FechaSincornizacion;
            result.UsuarioSincronizacion = UsuarioSincronizacion;
            return result;
        }
        #endregion
    }
}
