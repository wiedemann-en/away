using Away.Api.Contracts.Base;
using Away.Api.Contracts.Segmentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.SystemSecurity
{
    public class UsuarioDto : DtoBase, ISegmentacionNegocio
    {
        #region Constructors
        public UsuarioDto()
        {
            Rol = new RolDto();
            Negocio = new SegmentacionNegocioDto();
        }
        #endregion

        #region Attributes
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public RolDto Rol { get; set; }
        public SegmentacionNegocioDto Negocio { get; set; }
        #endregion
    }
}
