using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Away.Api.Core.Logger;
using Away.Api.Site.Models.Common;
using Away.Api.Site.Models.Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Away.Api.Site.Controllers
{
    public abstract class AwayController : ControllerBase
    {
        #region Constants
        protected const string KOriginApp = "Away.Api";
        #endregion

        #region Protected Attributes
        protected readonly ILogger _logger;
        #endregion

        #region Constructors
        public AwayController(ILogger logger)
        {
            _logger = logger;
        }
        #endregion

        #region Protected Helpers
        protected ResultDto BuildResultError(params string[] errors)
        {
            var result = new ResultDto();
            result.Data = null;
            result.AddErrors(errors.ToList());
            return result;
        }
        #endregion
    }
}