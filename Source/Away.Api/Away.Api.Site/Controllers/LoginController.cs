using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Away.Api.Core.Logger;
using Away.Api.Core.Services;
using Away.Api.Site.Models.Common;
using Away.Api.Site.Models.Infraestructure;
using Microsoft.AspNetCore.Authorization;
using Away.Api.Site.Models.Login;
using Away.Api.Site.Logic.Security;
using Microsoft.Extensions.Options;
using Away.Api.Core.Exceptions;

namespace Away.Api.Site.Controllers
{
    [AllowAnonymous]
    [Route("login")]
    [ApiController]
    public class LoginController : AwayController
    {
        #region Private Attributes
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IOptions<JwtIssuerOptions> _jwtIssuerOptions;
        private readonly IUsuarioService _usuarioService;
        #endregion

        #region Constructors
        public LoginController(ILogger logger, 
            IOptions<AppSettings> appSettings,
            IOptions<JwtIssuerOptions> jwtIssuerOptions, 
            IUsuarioService usuarioService) : base(logger)
        {
            _appSettings = appSettings;
            _jwtIssuerOptions = jwtIssuerOptions;
            _usuarioService = usuarioService;
        }
        #endregion

        #region WebApi Methods
        [HttpPost]
        [Route("auth")]
        public async Task<IActionResult> Authenticate([FromBody] LoginDto loginDto)
        {
            var result = new ResultDto<UsuarioAutenticadoDto>();
            try
            {
                if (loginDto == null)
                    throw new AwayException("Datos inválidos.");

                var usuarioDto = await _usuarioService.GetByCredentialsAsync(loginDto.User, loginDto.Pass);
                if ((usuarioDto == null) || (usuarioDto.Id <= 0))
                    throw new AwayException("Usuario/Password inválidos.");

                result.Data = new UsuarioAutenticadoDto()
                {
                    Id = usuarioDto.Id,
                    Nombre = usuarioDto.Nombre,
                    Apellido = usuarioDto.Apellido,
                    Rol = usuarioDto.Rol,
                    Token = AwayTokenGenerator.GenerateTokenJwt(_appSettings, _jwtIssuerOptions, usuarioDto)
                };
            }
            catch (AwayException ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(KOriginApp, ex.Message, ex);
                result.AddError("Ocurrió un error al intentar logearse en el sistema.");
            }
            return Ok(result);
        }
        #endregion
    }
}