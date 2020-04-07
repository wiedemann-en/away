using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class QueryFilterPropertyDto
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
