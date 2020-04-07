using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class QueryPagerDto
    {
        public short? PageSize { get; set; }
        public short? PageNumber { get; set; }
    }
}
