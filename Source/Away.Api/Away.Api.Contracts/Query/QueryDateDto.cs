using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class QueryDateDto : QuerySimpleDto
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
