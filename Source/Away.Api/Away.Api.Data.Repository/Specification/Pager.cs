using Away.Api.Core.Repository.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Repository.Specification
{
    public class Pager : IPager
    {
        #region IPager
        public short? PageSize { get; set; }
        public short? PageNumber { get; set; }
        #endregion
    }
}
