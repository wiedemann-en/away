using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Logic.Security
{
    public class AwayAuthorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var approved = AwayAuthorize.Authorize(context);
            if (!approved)
                context.Result = new ForbidResult();
        }
    }
}
