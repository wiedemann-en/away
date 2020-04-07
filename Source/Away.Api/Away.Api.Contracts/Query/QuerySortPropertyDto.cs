using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class QuerySortPropertyDto
    {
        public string Name { get; set; }
        public bool IsAscending { get; set; }
    }
}
