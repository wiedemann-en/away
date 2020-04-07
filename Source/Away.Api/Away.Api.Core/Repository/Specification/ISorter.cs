using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Core.Repository.Specification
{
    public interface ISorter
    {
        string Name { get; set; }
        bool IsAscending { get; set; }
    }
}
