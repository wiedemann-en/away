using Away.Api.Core.Repository.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Repository.Specification
{
    public class Sorter : ISorter
    {
        #region ISorter
        public string Name { get; set; }
        public bool IsAscending { get; set; }
        #endregion
    }
}
