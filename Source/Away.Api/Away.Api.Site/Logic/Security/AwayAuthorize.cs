using Away.Api.Core.Services;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Logic.Security
{
    public class AwayAuthorize
    {
        public static bool Authorize(AuthorizationFilterContext context)
        {
            var hasAuthHeader = context.HttpContext.Request.Headers.TryGetValue("Authorization", out var headers);
            if (!hasAuthHeader)
                return false;

            if (!headers[0].StartsWith("Bearer "))
                return false;

            var jwt = headers[0].Split(' ')[1];
            if (string.IsNullOrEmpty(jwt))
                return false;

            var handler = new JwtSecurityTokenHandler();
            try
            {
                if (!(handler.ReadToken(jwt) is JwtSecurityToken token))
                    return false;

                var userId = long.Parse(token.Claims.First(claim => claim.Type == AwayClaimTypes.UserId).Value);
                var userEmail = token.Claims.First(claim => claim.Type == AwayClaimTypes.UserEmail).Value;

                var usuarioService = (IUsuarioService)context.HttpContext.RequestServices.GetService(typeof(IUsuarioService));
                var rolService = (IRolService)context.HttpContext.RequestServices.GetService(typeof(IRolService));

                //Validamos existencia de usuario
                var usuarioDto = usuarioService.GetById(userId);
                if ((usuarioDto == null) || (!usuarioDto.Activo))
                    return false;

                //Validamos existencia de rol
                var rolDto = rolService.GetById(usuarioDto.Rol.Id);
                if ((rolDto == null) || (!rolDto.Activo))
                    return false;

                var controllerActionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
                var controllerName = controllerActionDescriptor?.ControllerName.ToUpper();
                var actionName = controllerActionDescriptor?.ActionName.ToUpper();
                var httpMethod = controllerActionDescriptor?.MethodInfo.Name.ToUpper();

                var apiResources = rolDto.Recursos.Where(r => r.ApiName == controllerName).ToList();
                if (actionName == "GET")
                    return apiResources.Any(r => r.Permiso == "READ" || r.Permiso == "WRITE");

                return apiResources.Any(r => r.Permiso == "WRITE");
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
