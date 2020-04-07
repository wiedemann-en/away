using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Contracts.Client
{
    public class ClienteSegmentacionDto
    {
        #region Constructors
        public ClienteSegmentacionDto()
        {
            Tipo = new ClienteTipoDto();
            SubTipo = new ClienteSubTipoDto();
            Rubro = new ClienteRubroDto();
            Categoria = new ClienteCategoriaDto();
        }
        #endregion

        #region Attributes
        public string Grupo { get; set; }
        public string Zona { get; set; }
        public ClienteTipoDto Tipo { get; set; }
        public ClienteSubTipoDto SubTipo { get; set; }
        public ClienteRubroDto Rubro { get; set; }
        public ClienteCategoriaDto Categoria { get; set; }
        #endregion
    }
}
