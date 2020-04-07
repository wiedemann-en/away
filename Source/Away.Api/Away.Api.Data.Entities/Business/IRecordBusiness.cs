using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Business
{
    public interface IRecordBusiness
    {
        long? IdCompania { get; set; }
        long? IdEmpresa { get; set; }
        long? IdSucursal { get; set; }
    }
}
