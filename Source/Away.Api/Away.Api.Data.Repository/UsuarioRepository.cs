using Away.Api.Core.Repository;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Data.Repository
{
    public class UsuarioRepository : Repository<UsuarioModel>, IUsuarioRepository
    {
        #region IRepositoryUser
        public UsuarioModel GetByUserName(string userName)
        {
            return GetByUserNameAsync(userName).Result;
        }
        public async Task<UsuarioModel> GetByUserNameAsync(string userName)
        {
            IQueryable<UsuarioModel> query = _dbSet.AsNoTracking();
            query = SetDefaultIncludes(query);
            return await query.FirstOrDefaultAsync(x => x.Email == userName);
        }
        public void UpdatePassword(UsuarioModel entity)
        {
            if (entity == null)
                return;

            var exist = _dbSet.FirstOrDefault(x => x.Id == entity.Id);
            if (exist == null)
                return;

            exist.PasswordHash = entity.PasswordHash;
            exist.PasswordSalt = entity.PasswordSalt;
            exist.Auditoria.FechaModificacion = entity.Auditoria.FechaModificacion;
            exist.Auditoria.UsuarioModificacion = entity.Auditoria.UsuarioModificacion;

            _context.Update(exist);
            _context.SaveChanges();
        }
        #endregion

        #region Overrides
        protected override IQueryable<UsuarioModel> SetDefaultIncludes(IQueryable<UsuarioModel> queryConstruct)
        {
            queryConstruct = queryConstruct
                .Include("Rol")
                .Include("Rol.Recursos.Recurso")
                .Include("Compania")
                .Include("Empresa")
                .Include("Sucursal");

            return queryConstruct;
        }
        #endregion
    }
}
