using AutoMapper;
using Away.Api.Contracts.Common;
using Away.Api.Contracts.Provider;
using Away.Api.Core.Repository;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Services
{
    public class ProveedorService : ServiceBase<ProveedorDto, ProveedorModel>, IProveedorService
    {
        #region Private Attributes
        private readonly IEnteRepository _enteRepository;
        private readonly IContactoRepository _contactoRepository;
        #endregion

        #region Constructors
        public ProveedorService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<ProveedorRepository>();
            _enteRepository = unitOfWork.RegisterRepository<EnteRepository>();
            _contactoRepository = unitOfWork.RegisterRepository<ContactoRepository>();
        }
        #endregion

        #region IProveedorService
        public new ProveedorDto Create(ProveedorDto dto)
        {
            return CreateAsync(dto).Result;
        }

        public new async Task<ProveedorDto> CreateAsync(ProveedorDto dto)
        {
            //Mapeamos y creamos el ente
            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.TipoEnte = "PROVEEDOR";
            SetEnteCreationAudit(enteEntity);
            _enteRepository.Add(enteEntity);

            //Mapeamos y creamos el proveedor
            ProveedorModel proveedorEntity = _mapper.Map<ProveedorDto, ProveedorModel>(dto);
            proveedorEntity.Id = enteEntity.Id;
            SetCreationAudit(proveedorEntity);
            _repository.Add(proveedorEntity);

            await _unitOfWork.CommitAsync();
            dto.Id = proveedorEntity.Id;

            return dto;
        }

        public new bool Update(ProveedorDto dto)
        {
            return UpdateAsync(dto).Result;
        }

        public new async Task<bool> UpdateAsync(ProveedorDto dto)
        {
            //Mapeamos y modificamos los datos del ente
            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.Id = dto.Id;
            enteEntity.TipoEnte = "CLIENTE";
            SetEnteUpdateAudit(enteEntity);
            _enteRepository.Update(enteEntity);

            //Mapeamos y actualizamos los datos del proveedor
            ProveedorModel proveedorEntity = _mapper.Map<ProveedorDto, ProveedorModel>(dto);
            SetUpdateAudit(proveedorEntity);
            _repository.Update(proveedorEntity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Delete(long id)
        {
            return DeleteAsync(id).Result;
        }

        public new async Task<bool> DeleteAsync(long id)
        {
            _repository.Delete(id);
            _enteRepository.Delete(id);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Delete(ProveedorDto dto)
        {
            return DeleteAsync(dto).Result;
        }

        public new async Task<bool> DeleteAsync(ProveedorDto dto)
        {
            ProveedorModel proveedorEntity = _mapper.Map<ProveedorDto, ProveedorModel>(dto);
            _repository.Delete(proveedorEntity);

            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            _enteRepository.Delete(enteEntity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Disable(long id)
        {
            return DisableAsync(id).Result;
        }

        public new async Task<bool> DisableAsync(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Disable(id, audit);
            _enteRepository.Disable(id, audit);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Disable(ProveedorDto dto)
        {
            return DisableAsync(dto).Result;
        }

        public new async Task<bool> DisableAsync(ProveedorDto dto)
        {
            ProveedorModel proveedorEntity = _mapper.Map<ProveedorDto, ProveedorModel>(dto);
            SetUpdateAudit(proveedorEntity);
            _repository.Disable(proveedorEntity);

            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.Id = dto.Id;
            SetEnteUpdateAudit(enteEntity);
            _enteRepository.Disable(enteEntity);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Enable(long id)
        {
            return EnableAsync(id).Result;
        }

        public new async Task<bool> EnableAsync(long id)
        {
            RecordAudit audit = new RecordAudit();
            audit.FechaModificacion = DateTime.Now;
            audit.UsuarioModificacion = _currentContext.User.Email;

            _repository.Enable(id, audit);
            _enteRepository.Enable(id, audit);

            return await _unitOfWork.CommitAsync() > 0;
        }

        public new bool Enable(ProveedorDto dto)
        {
            return EnableAsync(dto).Result;
        }

        public new async Task<bool> EnableAsync(ProveedorDto dto)
        {
            ProveedorModel proveedorEntity = _mapper.Map<ProveedorDto, ProveedorModel>(dto);
            SetUpdateAudit(proveedorEntity);
            _repository.Enable(proveedorEntity);

            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.Id = dto.Id;
            SetEnteUpdateAudit(enteEntity);
            _enteRepository.Enable(enteEntity);

            return await _unitOfWork.CommitAsync() > 0;
        }
        #endregion

        #region Protected Helpers
        private void SetEnteCreationAudit(EnteModel entity)
        {
            if (entity.Auditoria == null)
                entity.Auditoria = new RecordAudit();
            entity.Auditoria.FechaCreacion = DateTime.Now;
            entity.Auditoria.UsuarioCreacion = _currentContext.User.Email;
        }
        private void SetEnteUpdateAudit(EnteModel entity)
        {
            if (entity.Auditoria == null)
                entity.Auditoria = new RecordAudit();
            entity.Auditoria.FechaModificacion = DateTime.Now;
            entity.Auditoria.UsuarioModificacion = _currentContext.User.Email;
        }
        #endregion
    }
}
