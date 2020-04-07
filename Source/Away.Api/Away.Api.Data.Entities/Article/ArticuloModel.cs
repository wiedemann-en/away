using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Away.Api.Data.Entities.Article
{
    public class ArticuloModel : ModelBaseCode, IRecordBusiness, IRecordAudit
    {
        #region Constructors
        public ArticuloModel()
        {
            OrdenesDetalle = new List<OrdenDetalleModel>();
        }
        #endregion

        #region Attributes
        /// <summary>
        /// Identificación de Artículo
        /// </summary>
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }

        /// <summary>
        /// Segmentación
        /// </summary>
        public string Familia { get; set; }
        public string Grupo { get; set; }
        public long IdTipo { get; set; }
        public long IdSubTipo { get; set; }
        public long IdRubro { get; set; }
        public long IdCategoria { get; set; }
        public long IdLinea { get; set; }
        public long IdMarca { get; set; }

        public string Presentacion { get; set; }
        public string Color { get; set; }

        public string CodigoEANBulto { get; set; }
        public string CodigoEANUnidad { get; set; }
        public string CodigoEANFraccion { get; set; }

        /// <summary>
        /// Stock
        /// </summary>
        public bool GestionaStock { get; set; }
        public int UnidadesXBulto { get; set; }
        public int? BultosXPallet { get; set; }
        public long IdUnidadMedida { get; set; }

        /// <summary>
        /// Facturación
        /// </summary>
        public long IdAlicuotaIva { get; set; }
        public long IdAlicuotaIvaDiferencial { get; set; }
        public decimal? ImpuestosInternosPorc { get; set; }
        public decimal? ImpuestosInternosFijos { get; set; }
        public decimal? PercepcionIIBB { get; set; }

        /// <summary>
        /// Comportamiento
        /// </summary>
        public bool EsCompuesto { get; set; }
        public bool EsLibreDescripcion { get; set; }
        public bool EsDeOferta { get; set; }

        /// <summary>
        /// Segmentación Negocio
        /// </summary>
        public long? IdCompania { get; set; }
        public long? IdEmpresa { get; set; }
        public long? IdSucursal { get; set; }

        /// <summary>
        /// Auditoria
        /// </summary>
        public RecordAudit Auditoria { get; set; }
        #endregion

        #region References
        public virtual ArticuloTipoModel Tipo { get; set; }
        public virtual ArticuloSubTipoModel SubTipo { get; set; }
        public virtual ArticuloRubroModel Rubro { get; set; }
        public virtual ArticuloCategoriaModel Categoria { get; set; }
        public virtual ArticuloLineaModel Linea { get; set; }
        public virtual ArticuloMarcaModel Marca { get; set; }
        public virtual ArticuloUnidadMedidaModel UnidadMedida { get; set; }
        public virtual AlicuotaIvaModel AlicuotaIva { get; set; }
        public virtual AlicuotaIvaModel AlicuotaIvaDiferencial { get; set; }
        public virtual CompaniaModel Compania { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public virtual SucursalModel Sucursal { get; set; }
        public virtual List<OrdenDetalleModel> OrdenesDetalle { get; set; }
        #endregion
    }
}