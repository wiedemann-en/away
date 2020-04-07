using Away.Api.Contracts.Base;
using Away.Api.Contracts.Query;
using Away.Api.Core.Repository.Specification;
using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Core.Services.Base
{
    public interface IService<TDto, TEntity> : IDisposable
        where TDto : DtoBase
        where TEntity : ModelBase
    {
        ResponseQueryDto<TDto> Get(ISpecification<TEntity> specification = null);
        Task<ResponseQueryDto<TDto>> GetAsync(ISpecification<TEntity> specification = null);
        ResponseQueryDto<TDto> GetActives(params string[] includes);
        Task<ResponseQueryDto<TDto>> GetActivesAsync(params string[] includes);
        TDto GetById(long id, params string[] includes);
        Task<TDto> GetByIdAsync(long id, params string[] includes);
        TDto Create(TDto dto);
        Task<TDto> CreateAsync(TDto dto);
        bool Update(TDto dto);
        Task<bool> UpdateAsync(TDto dto);
        bool Delete(long id);
        Task<bool> DeleteAsync(long id);
        bool Delete(TDto dto);
        Task<bool> DeleteAsync(TDto dto);
        bool Disable(long id);
        Task<bool> DisableAsync(long id);
        bool Disable(TDto dto);
        Task<bool> DisableAsync(TDto dto);
        bool Enable(long id);
        Task<bool> EnableAsync(long id);
        bool Enable(TDto dto);
        Task<bool> EnableAsync(TDto dto);
    }
}
