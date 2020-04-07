using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public class ModelBase : IModelBase
    {
        public long Id { get; set; }
        public bool Activo { get; set; }
    }
}
