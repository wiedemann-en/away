using Away.Api.Contracts;
using Away.Api.Contracts.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Services.Base
{
    public interface ICurrentContext
    {
        UsuarioDto User { get; }
    }
}
