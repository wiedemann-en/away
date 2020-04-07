using Away.Api.Contracts;
using Away.Api.Contracts.SystemSecurity;
using Away.Api.Core.Services.Base;
using Away.Api.Services.Base;
using Away.Api.Site.Logic.Security;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Logic.Context
{
    public static class CurrentContextResolver
    {
        #region Private Attributes
        private static IHttpContextAccessor _httpContextAccessor;
        #endregion

        #region Public Attributes
        public static HttpContext Current => _httpContextAccessor.HttpContext;
        #endregion

        #region Public Helpers
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public static ICurrentContext GetCurrentContext()
        {
            ICurrentContext currentContext = null;

            var claimData = GetClaimData();
            if ((claimData != null) && (claimData.UserId > 0))
            {
                var userDto = new UsuarioDto() { Id = claimData.UserId, Email = claimData.UserEmail };
                currentContext = new CurrentContext(userDto);
            }
            else
            {
                var userDto = new UsuarioDto() { Id = -1, Email = "anonymous" };
                currentContext = new CurrentContext(userDto);
            }

            return currentContext;
        }
        #endregion

        #region Private Helpers
        private static AwayClaimData GetClaimData()
        {
            AwayClaimData claimData = null;
            try
            {
                var hasAuthHeader = Current.Request.Headers.TryGetValue("Authorization", out var headers);
                if (!hasAuthHeader)
                    return claimData;

                if (!headers[0].StartsWith("Bearer "))
                    return claimData;

                var jwt = headers[0].Split(' ')[1];
                if (string.IsNullOrEmpty(jwt))
                    return claimData;

                var handler = new JwtSecurityTokenHandler();
                if (!(handler.ReadToken(jwt) is JwtSecurityToken token))
                    return claimData;

                var userId = long.Parse(token.Claims.First(claim => claim.Type == AwayClaimTypes.UserId).Value);
                var userEmail = token.Claims.First(claim => claim.Type == AwayClaimTypes.UserEmail).Value;

                claimData = new AwayClaimData()
                {
                    UserId = userId,
                    UserEmail = userEmail
                };
            }
            catch (Exception)
            {
                claimData = null;
            }
            return claimData;
        }
        #endregion
    }
}
