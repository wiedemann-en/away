using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Query
{
    public class ResponseQueryDto<T>
    {
        public ResponseQueryDto()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }
        public int Total { get; set; }
    }
}
