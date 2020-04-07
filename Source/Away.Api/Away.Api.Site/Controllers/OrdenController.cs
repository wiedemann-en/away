using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Away.Api.Contracts;
using Away.Api.Core.Logger;
using Away.Api.Core.Services;
using Away.Api.Site.Logic.Security;
using Away.Api.Site.Models.Common;
using Away.Api.Contracts.Transaction;
using Away.Api.Core.Exceptions;

namespace Away.Api.Site.Controllers
{
    [AwayAuthorize]
    [Route("ordenes")]
    [ApiController]
    public class OrdenController : AwayController
    {
        #region Private Attributes
        private readonly IOrdenService _ordenService;
        #endregion

        #region Constructors
        public OrdenController(ILogger logger, IOrdenService ordenService)
            : base(logger)
        {
            _ordenService = ordenService;
        }
        #endregion

        #region WebApi Methods
        [HttpGet]
        public async Task<IActionResult> GetActives()
        {
            var result = new ResultDto<List<OrdenCabeceraDto>>();
            try
            {
                var listDataDto = await _ordenService.GetActivesAsync();
                result.Data = listDataDto.Items;
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener el listado de ordenes.");
            }
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = new ResultDto<List<OrdenCabeceraDto>>();
            try
            {
                var listDataDto = await _ordenService.GetAsync();
                result.Data = listDataDto.Items;
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener el listado de ordenes.");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var result = new ResultDto<OrdenCabeceraDto>();
            try
            {
                result.Data = await _ordenService.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener los datos del registro.");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrdenCabeceraDto valueDto)
        {
            var result = new ResultDto<OrdenCabeceraDto>();
            try
            {
                result.Data = await _ordenService.CreateAsync(valueDto);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar agregar el registro.");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody]OrdenCabeceraDto valueDto)
        {
            var result = new ResultDto<bool>();
            try
            {
                var modelExists = await _ordenService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea editar.");

                valueDto.Id = modelExists.Id;
                result.Data = await _ordenService.UpdateAsync(valueDto);
            }
            catch (AwayException ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar editar los datos del registro.");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = new ResultDto<bool>();
            try
            {
                var modelExists = await _ordenService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea eliminar.");

                result.Data = await _ordenService.DeleteAsync(id);
            }
            catch (AwayException ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar eliminar el registro.");
            }
            return Ok(result);
        }

        [HttpPatch("disable/{id}")]
        public async Task<IActionResult> Disable(long id)
        {
            var result = new ResultDto<bool>();
            try
            {
                var modelExists = await _ordenService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea desactivar.");

                result.Data = await _ordenService.DisableAsync(id);
            }
            catch (AwayException ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar desactivar el registro.");
            }
            return Ok(result);
        }

        [HttpPatch("enable/{id}")]
        public async Task<IActionResult> Enable(long id)
        {
            var result = new ResultDto<bool>();
            try
            {
                var modelExists = await _ordenService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea activar.");

                result.Data = await _ordenService.EnableAsync(id);
            }
            catch (AwayException ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar activar el registro.");
            }
            return Ok(result);
        }
        #endregion
    }
}