using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Query
{
    public class ResponseQuery<T>
    {
        public List<T> Items { get; set; }
        public int Total { get; set; }
    }
}
