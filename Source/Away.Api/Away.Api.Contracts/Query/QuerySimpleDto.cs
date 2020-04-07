using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class QuerySimpleDto
    {
        public QuerySimpleDto()
        {
            Filters = new List<QueryFilterPropertyDto>();
            Sort = new QuerySortPropertyDto();
            Pager = new QueryPagerDto();
        }

        public List<QueryFilterPropertyDto> Filters { get; set; }
        public QuerySortPropertyDto Sort { get; set; }
        public QueryPagerDto Pager { get; set; }
    }
}
