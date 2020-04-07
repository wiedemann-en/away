using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public interface IModelBase
    {
        long Id { get; set; }
        bool Activo { get; set; }
    }
}
