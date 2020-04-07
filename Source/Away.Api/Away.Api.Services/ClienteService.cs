using AutoMapper;
using Away.Api.Contracts.Client;
using Away.Api.Contracts.Common;
using Away.Api.Core.Repository;
using Away.Api.Core.Repository.Base;
using Away.Api.Core.Services;
using Away.Api.Core.Services.Base;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Repository;
using Away.Api.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Services
{
    public class ClienteService : ServiceBase<ClienteDto, ClienteModel>, IClienteService
    {
        #region Private Attributes
        private readonly IEnteRepository _enteRepository;
        private readonly IContactoRepository _contactoRepository;
        #endregion

        #region Constructors
        public ClienteService(IUnitOfWork unitOfWork, ICurrentContext currentContext, IMapper mapper)
            : base(unitOfWork, currentContext, mapper)
        {
            _repository = unitOfWork.RegisterRepository<ClienteRepository>();
            _enteRepository = unitOfWork.RegisterRepository<EnteRepository>();
            _contactoRepository = unitOfWork.RegisterRepository<ContactoRepository>();
        }
        #endregion

        #region IClienteService
        public new ClienteDto Create(ClienteDto dto)
        {
            return CreateAsync(dto).Result;
        }

        public new async Task<ClienteDto> CreateAsync(ClienteDto dto)
        {
            //Mapeamos y creamos el ente
            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.TipoEnte = "CLIENTE";
            SetEnteCreationAudit(enteEntity);
            _enteRepository.Add(enteEntity);

            //Mapeamos y creamos el cliente
            ClienteModel clienteEntity = _mapper.Map<ClienteDto, ClienteModel>(dto);
            clienteEntity.Id = enteEntity.Id;
            SetCreationAudit(clienteEntity);
            _repository.Add(clienteEntity);

            await _unitOfWork.CommitAsync();
            dto.Id = clienteEntity.Id;

            return dto;
        }

        public new bool Update(ClienteDto dto)
        {
            return UpdateAsync(dto).Result;
        }

        public new async Task<bool> UpdateAsync(ClienteDto dto)
        {
            //Mapeamos y modificamos los datos del ente
            EnteModel enteEntity = _mapper.Map<EnteDto, EnteModel>(dto.Ente);
            enteEntity.Id = dto.Id;
            enteEntity.TipoEnte = "CLIENTE";
            SetEnteUpdateAudit(enteEntity);
            _enteRepository.Update(enteEntity);

            //Mapeamos y actualizamos los datos del cliente
            ClienteModel clienteEntity = _mapper.Map<ClienteDto, ClienteModel>(dto);
            SetUpdateAudit(clienteEntity);
            _repository.Update(clienteEntity);

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

        public new bool Delete(ClienteDto dto)
        {
            return DeleteAsync(dto).Result;
        }

        public new async Task<bool> DeleteAsync(ClienteDto dto)
        {
            ClienteModel clienteEntity = _mapper.Map<ClienteDto, ClienteModel>(dto);
            _repository.Delete(clienteEntity);

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

        public new bool Disable(ClienteDto dto)
        {
            return DisableAsync(dto).Result;
        }

        public new async Task<bool> DisableAsync(ClienteDto dto)
        {
            ClienteModel clienteEntity = _mapper.Map<ClienteDto, ClienteModel>(dto);
            SetUpdateAudit(clienteEntity);
            _repository.Disable(clienteEntity);

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

        public new bool Enable(ClienteDto dto)
        {
            return EnableAsync(dto).Result;
        }

        public new async Task<bool> EnableAsync(ClienteDto dto)
        {
            ClienteModel clienteEntity = _mapper.Map<ClienteDto, ClienteModel>(dto);
            SetUpdateAudit(clienteEntity);
            _repository.Enable(clienteEntity);

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
