using Away.Api.Contracts;
using Away.Api.Contracts.SystemSecurity;
using Away.Api.Site.Models.Infraestructure;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Site.Logic.Security
{
    internal static class AwayTokenGenerator
    {
        #region Public Methods
        public static string GenerateTokenJwt(IOptions<AppSettings> appSettings, IOptions<JwtIssuerOptions> jwtIssuerOptions, UsuarioDto user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(appSettings.Value.Secret));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            //Create Claims
            var claimUserId = new Claim(AwayClaimTypes.UserId, user.Id.ToString());
            var claimUserEmail = new Claim(AwayClaimTypes.UserEmail, user.Email);

            //Create token to the user
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = tokenHandler.CreateJwtSecurityToken(
                audience: jwtIssuerOptions.Value.Audience,
                issuer: jwtIssuerOptions.Value.Issuer,
                subject: new ClaimsIdentity(new[] { claimUserId, claimUserEmail }),
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(jwtIssuerOptions.Value.ExpireMinutes)),
                signingCredentials: signingCredentials);

            var jwtTokenString = tokenHandler.WriteToken(jwtSecurityToken);

            return jwtTokenString;
        }
        #endregion
    }
}
