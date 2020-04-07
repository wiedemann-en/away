using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Common
{
    public class CondicionPagoModel : ModelBaseCodeName
    {
        #region Constructors
        public CondicionPagoModel()
        {
            Clientes = new List<ClienteModel>();
            Proveedores = new List<ProveedorModel>();
        }
        #endregion

        #region Attributes
        public int Dias { get; set; }
        #endregion

        #region References
        public virtual List<ClienteModel> Clientes { get; set; }
        public virtual List<ProveedorModel> Proveedores { get; set; }
        #endregion
    }
}
