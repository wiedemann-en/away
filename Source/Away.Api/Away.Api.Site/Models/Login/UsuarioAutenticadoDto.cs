using Away.Api.Contracts.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Models.Login
{
    public class UsuarioAutenticadoDto
    {
        #region Attributes
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Token { get; set; }
        public RolDto Rol { get; set; }
        #endregion
    }
}
