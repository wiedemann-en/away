using Away.Api.Contracts.SystemSecurity;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Core.Services
{
    public interface IUsuarioService : IService<UsuarioDto, UsuarioModel>
    {
        UsuarioDto GetByCredentials(string userName, string password);
        Task<UsuarioDto> GetByCredentialsAsync(string userName, string password);
        bool UpdatePassword(long id, string password);
        Task<bool> UpdatePasswordAsync(long id, string password);
    }
}
