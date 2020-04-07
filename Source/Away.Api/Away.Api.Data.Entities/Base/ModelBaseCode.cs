using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public class ModelBaseCode : ModelBase, IModelBaseCode
    {
        public string Codigo { get; set; }
    }
}
