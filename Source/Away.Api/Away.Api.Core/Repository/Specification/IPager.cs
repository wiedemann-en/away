using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Repository.Specification
{
    public interface IPager
    {
        short? PageSize { get; set; }
        short? PageNumber { get; set; }
    }
}
