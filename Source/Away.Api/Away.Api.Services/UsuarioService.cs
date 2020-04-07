using AutoMapper;
using Away.Api.Contracts.SystemSecurity;
using Away.Api.Core.Repository;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Repository;
using Away.Api.Misc.Crypto;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Services
{
    public class UsuarioService : ServiceBase<UsuarioDto, UsuarioModel>, IUsuarioService
    {
        #region Constructors
        public UsuarioService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<UsuarioRepository>();
        }
        #endregion

        #region IUsuarioService
        public UsuarioDto GetByCredentials(string userName, string password)
        {
            return GetByCredentialsAsync(userName, password).Result;
        }

        public async Task<UsuarioDto> GetByCredentialsAsync(string userName, string password)
        {
            UsuarioDto result = null;
            UsuarioModel entity = await ((IUsuarioRepository)_repository).GetByUserNameAsync(userName);
            if (entity != null)
            {
                var passwordOk = EncryptionHelper.VerifyPasswordHash(password, entity.PasswordHash, entity.PasswordSalt);
                if (passwordOk)
                    result = _mapper.Map<UsuarioModel, UsuarioDto>(entity);
            }
            return result;
        }

        public bool UpdatePassword(long id, string password)
        {
            return UpdatePasswordAsync(id, password).Result;
        }

        public async Task<bool> UpdatePasswordAsync(long id, string password)
        {
            UsuarioModel entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return false;

            EncryptionHelper.CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            SetUpdateAudit(entity);
            ((IUsuarioRepository)_repository).UpdatePassword(entity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new async Task<UsuarioDto> CreateAsync(UsuarioDto dto)
        {
            UsuarioModel entity = _mapper.Map<UsuarioDto, UsuarioModel>(dto);

            EncryptionHelper.CreatePasswordHash(dto.Password, out var passwordHash, out var passwordSalt);

            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            SetCreationAudit(entity);

            _repository.Add(entity);
            await _unitOfWork.CommitAsync();
            dto = _mapper.Map<UsuarioDto>(entity);

            return dto;
        }
        #endregion
    }
}
