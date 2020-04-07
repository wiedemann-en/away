using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public interface IModelBaseName : IModelBase
    {
        string Nombre { get; set; }
    }
}
