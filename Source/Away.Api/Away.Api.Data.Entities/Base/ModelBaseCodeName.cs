using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Base
{
    public class ModelBaseCodeName : ModelBase, IModelBaseCodeName
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
