using Away.Api.Core.Repository.Base;
using Away.Api.Data.Entities.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Core.Repository
{
    public interface IUsuarioRepository : IRepository<UsuarioModel>
    {
        UsuarioModel GetByUserName(string userName);
        Task<UsuarioModel> GetByUserNameAsync(string userName);
        void UpdatePassword(UsuarioModel entity);
    }
}
