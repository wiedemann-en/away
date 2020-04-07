using Away.Api.Core.Repository.Specification;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Core.Repository.Base
{
    public interface IRepository<TEntity> : IRepositoryBase
        where TEntity : ModelBase
    {
        TEntity GetById(long id, params string[] includes);
        Task<TEntity> GetByIdAsync(long id, params string[] includes);
        ResponseQuery<TEntity> Get(ISpecification<TEntity> specification = null);
        Task<ResponseQuery<TEntity>> GetAsync(ISpecification<TEntity> specification = null);
        ResponseQuery<TEntity> GetActives(params string[] includes);
        Task<ResponseQuery<TEntity>> GetActivesAsync(params string[] includes);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(long id);
        void Delete(TEntity entity);
        void Disable(long id, RecordAudit audit);
        void Disable(TEntity entity);
        void Enable(long id, RecordAudit audit);
        void Enable(TEntity entity);
    }
}
