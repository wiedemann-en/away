using AutoMapper;
using Away.Api.Contracts.Base;
using Away.Api.Contracts.Query;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Repository.Specification;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Services.Base
{
    public abstract class ServiceBase<TDto, TEntity> : IService<TDto, TEntity>
        where TDto : DtoBase
        where TEntity : ModelBase
    {
        #region Protected Attributes
        protected IRepository<TEntity> _repository { get; set; }
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly ICurrentContext _currentContext;
        protected readonly IMapper _mapper;
        #endregion

        #region Private Attributes
        private bool _disposed;
        #endregion

        #region Constructors
        public ServiceBase(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _currentContext = currentContext;
            _mapper = mapper;
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
                _unitOfWork.Dispose();
            _disposed = true;
        }
        #endregion

        #region IService
        public ResponseQueryDto<TDto> Get(ISpecification<TEntity> specification = null)
        {
            ResponseQuery<TEntity> info = _repository.Get(specification);
            ResponseQueryDto<TDto> result = new ResponseQueryDto<TDto>();
            result.Items = _mapper.Map<List<TEntity>, List<TDto>>(info.Items);
            result.Total = info.Total;
            return result;
        }

        public async Task<ResponseQueryDto<TDto>> GetAsync(ISpecification<TEntity> specification = null)
        {
            ResponseQuery<TEntity> info = await _repository.GetAsync(specification);
            ResponseQueryDto<TDto> result = new ResponseQueryDto<TDto>();
            result.Items = _mapper.Map<List<TEntity>, List<TDto>>(info.Items);
            result.Total = info.Total;
            return result;
        }

        public ResponseQueryDto<TDto> GetActives(params string[] includes)
        {
            ResponseQuery<TEntity> info = _repository.GetActives(includes);
            ResponseQueryDto<TDto> result = new ResponseQueryDto<TDto>();
            result.Items = _mapper.Map<List<TEntity>, List<TDto>>(info.Items);
            result.Total = info.Total;
            return result;
        }

        public async Task<ResponseQueryDto<TDto>> GetActivesAsync(params string[] includes)
        {
            ResponseQuery<TEntity> info = await _repository.GetActivesAsync(includes);
            ResponseQueryDto<TDto> result = new ResponseQueryDto<TDto>();
            result.Items = _mapper.Map<List<TEntity>, List<TDto>>(info.Items);
            result.Total = info.Total;
            return result;
        }

        public TDto GetById(long id, params string[] includes)
        {
            TEntity info = _repository.GetById(id, includes);
            TDto result = null;
            if (info != null)
                result = _mapper.Map<TEntity, TDto>(info);
            return result;
        }

        public async Task<TDto> GetByIdAsync(long id, params string[] includes)
        {
            TEntity info = await _repository.GetByIdAsync(id, includes);
            TDto result = null;
            if (info != null)
                result = _mapper.Map<TEntity, TDto>(info);
            return result;
        }

        public TDto Create(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetCreationAudit(entity);
            _repository.Add(entity);
            _unitOfWork.Commit();
            dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetCreationAudit(entity);
            _repository.Add(entity);
            await _unitOfWork.CommitAsync();
            dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public bool Update(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Update(entity);

            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> UpdateAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Update(entity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Delete(long id)
        {
            _repository.Delete(id);
            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            _repository.Delete(id);
            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Delete(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);
            _repository.Delete(entity);
            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> DeleteAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);
            _repository.Delete(entity);
            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Disable(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Disable(id, audit);
            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> DisableAsync(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Disable(id, audit);
            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Disable(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Disable(entity);

            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> DisableAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Disable(entity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Enable(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Enable(id, audit);
            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> EnableAsync(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Enable(id, audit);
            return await _unitOfWork.CommitAsync() > 0;
        }

        public bool Enable(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Enable(entity);

            return _unitOfWork.Commit() > 0;
        }

        public async Task<bool> EnableAsync(TDto dto)
        {
            TEntity entity = _mapper.Map<TDto, TEntity>(dto);

            SetUpdateAudit(entity);
            _repository.Enable(entity);

            return await _unitOfWork.CommitAsync() > 0;
        }
        #endregion

        #region Protected Helpers
        protected void SetCreationAudit(TEntity entity)
        {
            if (entity is IRecordAudit)
            {
                var entityAudit = (IRecordAudit)entity;
                if (entityAudit.Auditoria == null)
                    entityAudit.Auditoria = new RecordAudit();
                entityAudit.Auditoria.FechaCreacion = DateTime.Now;
                entityAudit.Auditoria.UsuarioCreacion = _currentContext.User.Email;
            }
        }
        protected void SetUpdateAudit(TEntity entity)
        {
            if (entity is IRecordAudit)
            {
                var entityAudit = (IRecordAudit)entity;
                if (entityAudit.Auditoria == null)
                    entityAudit.Auditoria = new RecordAudit();
                entityAudit.Auditoria.FechaModificacion = DateTime.Now;
                entityAudit.Auditoria.UsuarioModificacion = _currentContext.User.Email;
            }
        }
        #endregion
    }
}
