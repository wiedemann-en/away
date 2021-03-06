﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Away.Api.Contracts.Common;
using Away.Api.Core.Exceptions;
using Away.Api.Core.Logger;
using Away.Api.Core.Services;
using Away.Api.Site.Logic.Security;
using Away.Api.Site.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Away.Api.Site.Controllers
{
    [AwayAuthorize]
    [Route("alicuotasiva")]
    [ApiController]
    public class AlicuotaIvaController : AwayController
    {
        #region Private Attributes
        private readonly IAlicuotaIvaService _alicuotaIvaService;
        #endregion

        #region Constructors
        public AlicuotaIvaController(ILogger logger, IAlicuotaIvaService alicuotaIvaService)
            : base(logger)
        {
            _alicuotaIvaService = alicuotaIvaService;
        }
        #endregion

        #region WebApi Methods
        [HttpGet]
        public async Task<IActionResult> GetActives()
        {
            var result = new ResultDto<List<AlicuotaIvaDto>>();
            try
            {
                var listDataDto = await _alicuotaIvaService.GetActivesAsync();
                result.Data = listDataDto.Items;
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener el listado de alicuotas de iva.");
            }
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = new ResultDto<List<AlicuotaIvaDto>>();
            try
            {
                var listDataDto = await _alicuotaIvaService.GetAsync();
                result.Data = listDataDto.Items;
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener el listado de alicuotas de iva.");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var result = new ResultDto<AlicuotaIvaDto>();
            try
            {
                result.Data = await _alicuotaIvaService.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener los datos del registro.");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AlicuotaIvaDto valueDto)
        {
            var result = new ResultDto<AlicuotaIvaDto>();
            try
            {
                result.Data = await _alicuotaIvaService.CreateAsync(valueDto);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar agregar el registro.");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody]AlicuotaIvaDto valueDto)
        {
            var result = new ResultDto<bool>();
            try
            {
                var modelExists = await _alicuotaIvaService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea editar.");

                valueDto.Id = modelExists.Id;
                result.Data = await _alicuotaIvaService.UpdateAsync(valueDto);
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
                var modelExists = await _alicuotaIvaService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea eliminar.");

                result.Data = await _alicuotaIvaService.DeleteAsync(id);
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
                var modelExists = await _alicuotaIvaService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea desactivar.");

                result.Data = await _alicuotaIvaService.DisableAsync(id);
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
                var modelExists = await _alicuotaIvaService.GetByIdAsync(id);
                if (modelExists == null)
                    throw new AwayException("No existe el registro que desea activar.");

                result.Data = await _alicuotaIvaService.EnableAsync(id);
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