using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Away.Api.Contracts;
using Away.Api.Contracts.System;
using Away.Api.Core.Logger;
using Away.Api.Core.Services;
using Away.Api.Site.Logic.Security;
using Away.Api.Site.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Away.Api.Site.Controllers
{
    [AwayAuthorize]
    [Route("logs")]
    [ApiController]
    public class LogsController : AwayController
    {
        #region Private Attributes
        private readonly ILogService _logService;
        #endregion

        #region Constructors
        public LogsController(ILogger logger, ILogService logService)
            : base(logger)
        {
            _logService = logService;
        }
        #endregion

        #region WebApi Methods
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = new ResultDto<List<LogDto>>();
            try
            {
                var rolesDto = await _logService.GetAsync();
                result.Data = rolesDto.Items;
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener el listado de logs.");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var result = new ResultDto<LogDto>();
            try
            {
                result.Data = await _logService.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al obtener los datos del log.");
            }
            return Ok(result);
        }
        #endregion
    }
}