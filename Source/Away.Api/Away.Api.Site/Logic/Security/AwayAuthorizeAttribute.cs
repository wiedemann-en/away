using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Away.Api.Site.Logic.Security
{
    public class AwayAuthorizeAttribute : TypeFilterAttribute
    {
        #region Constructors
        public AwayAuthorizeAttribute()
            : base(typeof(AwayAuthorizeFilter)) { }
        #endregion
    }
}
