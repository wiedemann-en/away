using Away.Api.Contracts;
using Away.Api.Contracts.SystemSecurity;
using Away.Api.Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Services.Base
{
    public class CurrentContext : ICurrentContext
    {
        #region Constructors
        public CurrentContext(UsuarioDto user)
        {
            User = user;
        }
        #endregion

        #region ICurrentContext
        public UsuarioDto User { get; }
        #endregion
    }
}
