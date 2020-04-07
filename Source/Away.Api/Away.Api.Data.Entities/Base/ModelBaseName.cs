using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public class ModelBaseName : ModelBase, IModelBaseName
    {
        public string Nombre { get; set; }
    }
}
