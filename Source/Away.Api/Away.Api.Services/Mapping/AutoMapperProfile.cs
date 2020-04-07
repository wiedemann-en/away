using AutoMapper;
using Away.Api.Contracts;
using Away.Api.Contracts.Article;
using Away.Api.Contracts.Business;
using Away.Api.Contracts.Client;
using Away.Api.Contracts.Common;
using Away.Api.Contracts.Provider;
using Away.Api.Contracts.Query;
using Away.Api.Contracts.Segmentation;
using Away.Api.Contracts.System;
using Away.Api.Contracts.SystemSecurity;
using Away.Api.Contracts.Transaction;
using Away.Api.Data.Entities;
using Away.Api.Data.Entities.Article;
using Away.Api.Data.Entities.Business;
using Away.Api.Data.Entities.Client;
using Away.Api.Data.Entities.Common;
using Away.Api.Data.Entities.Provider;
using Away.Api.Data.Entities.SystemSecurity;
using Away.Api.Data.Entities.Transaction;
using Away.Api.Data.Repository.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Away.Api.Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AlicuotaIvaDto, AlicuotaIvaModel>();
            CreateMap<ArticuloCategoriaDto, ArticuloCategoriaModel>();
            CreateMap<ArticuloDto, ArticuloModel>()
                .ForMember(x => x.Familia, op => op.MapFrom(dto => dto.Segmentacion.Familia))
                .ForMember(x => x.Grupo, op => op.MapFrom(dto => dto.Segmentacion.Grupo))
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => dto.Segmentacion.Tipo.Id))
                .ForMember(x => x.IdSubTipo, op => op.MapFrom(dto => dto.Segmentacion.SubTipo.Id))
                .ForMember(x => x.IdRubro, op => op.MapFrom(dto => dto.Segmentacion.Rubro.Id))
                .ForMember(x => x.IdCategoria, op => op.MapFrom(dto => dto.Segmentacion.Categoria.Id))
                .ForMember(x => x.IdLinea, op => op.MapFrom(dto => dto.Segmentacion.Linea.Id))
                .ForMember(x => x.IdMarca, op => op.MapFrom(dto => dto.Segmentacion.Marca.Id))
                .ForMember(x => x.GestionaStock, op => op.MapFrom(dto => dto.Stock.GestionaStock))
                .ForMember(x => x.UnidadesXBulto, op => op.MapFrom(dto => dto.Stock.UnidadesXBulto))
                .ForMember(x => x.BultosXPallet, op => op.MapFrom(dto => dto.Stock.BultosXPallet))
                .ForMember(x => x.IdUnidadMedida, op => op.MapFrom(dto => dto.Stock.UnidadMedida.Id))
                .ForMember(x => x.IdAlicuotaIva, op => op.MapFrom(dto => dto.Facturacion.AlicuotaIva.Id))
                .ForMember(x => x.IdAlicuotaIvaDiferencial, op => op.MapFrom(dto => dto.Facturacion.AlicuotaIvaDiferencial.Id))
                .ForMember(x => x.ImpuestosInternosPorc, op => op.MapFrom(dto => dto.Facturacion.ImpuestosInternosPorc))
                .ForMember(x => x.ImpuestosInternosFijos, op => op.MapFrom(dto => dto.Facturacion.ImpuestosInternosFijos))
                .ForMember(x => x.PercepcionIIBB, op => op.MapFrom(dto => dto.Facturacion.PercepcionIIBB))
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Compania.Id > 0)) ? dto.Negocio.Compania.Id : default(long?)))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Empresa.Id > 0)) ? dto.Negocio.Empresa.Id : default(long?)))
                .ForMember(x => x.IdSucursal, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Sucursal.Id > 0)) ? dto.Negocio.Sucursal.Id : default(long?)))
                .ForMember(x => x.Tipo, op => op.Ignore())
                .ForMember(x => x.SubTipo, op => op.Ignore())
                .ForMember(x => x.Rubro, op => op.Ignore())
                .ForMember(x => x.Categoria, op => op.Ignore())
                .ForMember(x => x.Linea, op => op.Ignore())
                .ForMember(x => x.Marca, op => op.Ignore())
                .ForMember(x => x.UnidadMedida, op => op.Ignore())
                .ForMember(x => x.AlicuotaIva, op => op.Ignore())
                .ForMember(x => x.AlicuotaIvaDiferencial, op => op.Ignore())
                .ForMember(x => x.Compania, op => op.Ignore())
                .ForMember(x => x.Empresa, op => op.Ignore())
                .ForMember(x => x.Sucursal, op => op.Ignore());
            CreateMap<ArticuloLineaDto, ArticuloLineaModel>();
            CreateMap<ArticuloMarcaDto, ArticuloMarcaModel>();
            CreateMap<ArticuloRubroDto, ArticuloRubroModel>();
            CreateMap<ArticuloSubTipoDto, ArticuloSubTipoModel>()
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => dto.Tipo.Id))
                .ForMember(x => x.Tipo, op => op.Ignore());
            CreateMap<ArticuloTipoDto, ArticuloTipoModel>();
            CreateMap<ArticuloUnidadMedidaDto, ArticuloUnidadMedidaModel>();
            CreateMap<ClienteCategoriaDto, ClienteCategoriaModel>();
            CreateMap<ClienteDto, ClienteModel>()
                .ForMember(x => x.IdCondicionIva, op => op.MapFrom(dto => dto.Facturacion.CondicionIva.Id))
                .ForMember(x => x.IdCondicionPago, op => op.MapFrom(dto => (dto.Facturacion.CondicionPago.Id > 0) ? dto.Facturacion.CondicionPago.Id : default(long?)))
                .ForMember(x => x.PercibirIB, op => op.MapFrom(dto => dto.Facturacion.PercibirIB))
                .ForMember(x => x.AlicuotaIB, op => op.MapFrom(dto => dto.Facturacion.AlicuotaIB))
                .ForMember(x => x.IvaDiferencial, op => op.MapFrom(dto => dto.Facturacion.IvaDiferencial))
                .ForMember(x => x.Grupo, op => op.MapFrom(dto => dto.Segmentacion.Grupo))
                .ForMember(x => x.Zona, op => op.MapFrom(dto => dto.Segmentacion.Zona))
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => (dto.Segmentacion.Tipo.Id > 0) ? dto.Segmentacion.Tipo.Id : default(long?)))
                .ForMember(x => x.IdSubTipo, op => op.MapFrom(dto => (dto.Segmentacion.SubTipo.Id > 0) ? dto.Segmentacion.SubTipo.Id : default(long?)))
                .ForMember(x => x.IdRubro, op => op.MapFrom(dto => (dto.Segmentacion.Rubro.Id > 0) ? dto.Segmentacion.Rubro.Id : default(long?)))
                .ForMember(x => x.IdCategoria, op => op.MapFrom(dto => (dto.Segmentacion.Categoria.Id > 0) ? dto.Segmentacion.Categoria.Id : default(long?)))
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Compania.Id > 0)) ? dto.Negocio.Compania.Id : default(long?)))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Empresa.Id > 0)) ? dto.Negocio.Empresa.Id : default(long?)))
                .ForMember(x => x.IdSucursal, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Sucursal.Id > 0)) ? dto.Negocio.Sucursal.Id : default(long?)))
                .ForMember(x => x.Ente, op => op.Ignore())
                .ForMember(x => x.CondicionIva, op => op.Ignore())
                .ForMember(x => x.CondicionPago, op => op.Ignore())
                .ForMember(x => x.Tipo, op => op.Ignore())
                .ForMember(x => x.SubTipo, op => op.Ignore())
                .ForMember(x => x.Rubro, op => op.Ignore())
                .ForMember(x => x.Categoria, op => op.Ignore())
                .ForMember(x => x.Compania, op => op.Ignore())
                .ForMember(x => x.Empresa, op => op.Ignore())
                .ForMember(x => x.Sucursal, op => op.Ignore());
            CreateMap<ClienteRubroDto, ClienteRubroModel>();
            CreateMap<ClienteSubTipoDto, ClienteSubTipoModel>()
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => dto.Tipo.Id))
                .ForMember(x => x.Tipo, op => op.Ignore());
            CreateMap<ClienteTipoDto, ClienteTipoModel>();
            CreateMap<CompaniaDto, CompaniaModel>();
            CreateMap<CondicionIvaDto, CondicionIvaModel>();
            CreateMap<CondicionPagoDto, CondicionPagoModel>();
            CreateMap<ContactoDto, ContactoModel>()
                .ForMember(x => x.IdEnteRelacion, op => op.MapFrom(dto => dto.EnteRelacion.Id))
                .ForMember(x => x.EnteRelacion, op => op.Ignore());
            CreateMap<EnteDto, EnteModel>()
                .ForMember(x => x.IdTipoDocumento, op => op.MapFrom(dto => dto.TipoDocumento.Id))
                .ForMember(x => x.TipoDocumento, op => op.Ignore());
            CreateMap<EnteDocumentoTipoDto, EnteDocumentoTipoModel>();
            CreateMap<EnteDomicilioDto, EnteDomicilioModel>()
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => dto.Tipo.Id))
                .ForMember(x => x.IdPais, op => op.MapFrom(dto => dto.Localidad.Partido.Provincia.Pais.Id))
                .ForMember(x => x.IdProvincia, op => op.MapFrom(dto => dto.Localidad.Partido.Provincia.Id))
                .ForMember(x => x.IdPartido, op => op.MapFrom(dto => dto.Localidad.Partido.Id))
                .ForMember(x => x.IdLocalidad, op => op.MapFrom(dto => dto.Localidad.Id))
                .ForMember(x => x.Tipo, op => op.Ignore())
                .ForMember(x => x.Localidad, op => op.Ignore());
            CreateMap<EnteDomicilioTipoDto, EnteDomicilioTipoModel>();
            CreateMap<EnteTelefonoDto, EnteTelefonoModel>()
                .ForMember(x => x.IdTipo, op => op.MapFrom(dto => dto.Tipo.Id))
                .ForMember(x => x.Tipo, op => op.Ignore());
            CreateMap<EnteTelefonoTipoDto, EnteTelefonoTipoModel>();
            CreateMap<EmpresaDto, EmpresaModel>()
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => dto.Compania.Id))
                .ForMember(x => x.Compania, op => op.Ignore());
            CreateMap<LocalidadDto, LocalidadModel>()
                .ForMember(x => x.IdPais, op => op.MapFrom(dto => dto.Partido.Provincia.Pais.Id))
                .ForMember(x => x.IdProvincia, op => op.MapFrom(dto => dto.Partido.Provincia.Id))
                .ForMember(x => x.IdPartido, op => op.MapFrom(dto => dto.Partido.Id))
                .ForMember(x => x.Partido, op => op.Ignore());
            CreateMap<LogDto, LogModel>();
            CreateMap<MovimientoCajaDto, MovimientoCajaModel>()
                .ForMember(x => x.IdEnte, op => op.MapFrom(dto => dto.Ente.Id))
                .ForMember(x => x.Ente, op => op.Ignore());
            CreateMap<OrdenCabeceraDto, OrdenCabeceraModel>()
                .ForMember(x => x.IdCliente, op => op.MapFrom(dto => dto.Cliente.Id))
                .ForMember(x => x.IdContacto, op => op.MapFrom(dto => dto.Contacto.Id))
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Compania.Id > 0)) ? dto.Negocio.Compania.Id : default(long?)))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Empresa.Id > 0)) ? dto.Negocio.Empresa.Id : default(long?)))
                .ForMember(x => x.IdSucursal, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Sucursal.Id > 0)) ? dto.Negocio.Sucursal.Id : default(long?)))
                .ForMember(x => x.Cliente, op => op.Ignore())
                .ForMember(x => x.Contacto, op => op.Ignore())
                .ForMember(x => x.Compania, op => op.Ignore())
                .ForMember(x => x.Empresa, op => op.Ignore())
                .ForMember(x => x.Sucursal, op => op.Ignore());
            CreateMap<OrdenDetalleDto, OrdenDetalleModel>()
                .ForMember(x => x.IdArticulo, op => op.MapFrom(dto => dto.Articulo.Id))
                .ForMember(x => x.Articulo, op => op.Ignore());
            CreateMap<PaisDto, PaisModel>();
            CreateMap<PartidoDto, PartidoModel>()
                .ForMember(x => x.IdPais, op => op.MapFrom(dto => dto.Provincia.Pais.Id))
                .ForMember(x => x.IdProvincia, op => op.MapFrom(dto => dto.Provincia.Id))
                .ForMember(x => x.Provincia, op => op.Ignore());
            CreateMap<ProveedorDto, ProveedorModel>()
                .ForMember(x => x.IdCondicionIva, op => op.MapFrom(dto => dto.Facturacion.CondicionIva.Id))
                .ForMember(x => x.IdCondicionPago, op => op.MapFrom(dto => (dto.Facturacion.CondicionPago.Id > 0) ? dto.Facturacion.CondicionPago.Id : default(long?)))
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Compania.Id > 0)) ? dto.Negocio.Compania.Id : default(long?)))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Empresa.Id > 0)) ? dto.Negocio.Empresa.Id : default(long?)))
                .ForMember(x => x.IdSucursal, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Sucursal.Id > 0)) ? dto.Negocio.Sucursal.Id : default(long?)))
                .ForMember(x => x.Ente, op => op.Ignore())
                .ForMember(x => x.CondicionIva, op => op.Ignore())
                .ForMember(x => x.CondicionPago, op => op.Ignore())
                .ForMember(x => x.Compania, op => op.Ignore())
                .ForMember(x => x.Empresa, op => op.Ignore())
                .ForMember(x => x.Sucursal, op => op.Ignore());
            CreateMap<ProvinciaDto, ProvinciaModel>()
                .ForMember(x => x.IdPais, op => op.MapFrom(dto => dto.Pais.Id))
                .ForMember(x => x.Pais, op => op.Ignore());
            CreateMap<RecursoSistemaDto, RecursoSistemaModel>();
            CreateMap<RolDto, RolModel>()
                .ForMember(x => x.Recursos, op => op.MapFrom(dto => dto.Recursos.Select(x => new RolRecursoModel() { IdRol = dto.Id, IdRecurso = x.Id }).ToList()));
            CreateMap<SucursalDto, SucursalModel>()
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => dto.Empresa.Compania.Id))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => dto.Empresa.Id))
                .ForMember(x => x.Compania, op => op.Ignore())
                .ForMember(x => x.Empresa, op => op.Ignore());
            CreateMap<UsuarioDto, UsuarioModel>()
                .ForMember(x => x.IdRol, op => op.MapFrom(dto => dto.Rol.Id))
                .ForMember(x => x.Rol, op => op.Ignore())
                .ForMember(x => x.IdCompania, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Compania.Id > 0)) ? dto.Negocio.Compania.Id : default(long?)))
                .ForMember(x => x.IdEmpresa, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Empresa.Id > 0)) ? dto.Negocio.Empresa.Id : default(long?)))
                .ForMember(x => x.IdSucursal, op => op.MapFrom(dto => ((dto.Negocio != null) && (dto.Negocio.Sucursal.Id > 0)) ? dto.Negocio.Sucursal.Id : default(long?)));
            CreateMap<QuerySortPropertyDto, Sorter>();
            CreateMap<QueryPagerDto, Pager>();


            CreateMap<AlicuotaIvaModel, AlicuotaIvaDto>();
            CreateMap<ArticuloCategoriaModel, ArticuloCategoriaDto>();
            CreateMap<ArticuloLineaModel, ArticuloLineaDto>();
            CreateMap<ArticuloMarcaModel, ArticuloMarcaDto>();
            CreateMap<ArticuloModel, ArticuloSegmentacionDto>();
            CreateMap<ArticuloModel, ArticuloStockDto>();
            CreateMap<ArticuloModel, ArticuloFacturacionDto>();
            CreateMap<ArticuloModel, SegmentacionNegocioDto>();
            CreateMap<ArticuloModel, ArticuloDto>()
                .ForMember(x => x.Segmentacion, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Stock, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Facturacion, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Negocio, op => op.MapFrom(entity => entity));
            CreateMap<ArticuloRubroModel, ArticuloRubroDto>();
            CreateMap<ArticuloSubTipoModel, ArticuloSubTipoDto>();
            CreateMap<ArticuloTipoModel, ArticuloTipoDto>();
            CreateMap<ArticuloUnidadMedidaModel, ArticuloUnidadMedidaDto>();
            CreateMap<ClienteCategoriaModel, ClienteCategoriaDto>();
            CreateMap<ClienteModel, ClienteFacturacionDto>();
            CreateMap<ClienteModel, ClienteSegmentacionDto>();
            CreateMap<ClienteModel, SegmentacionNegocioDto>();
            CreateMap<ClienteModel, ClienteDto>()
                .ForMember(x => x.Facturacion, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Segmentacion, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Negocio, op => op.MapFrom(entity => entity));
            CreateMap<ClienteRubroModel, ClienteRubroDto>();
            CreateMap<ClienteSubTipoModel, ClienteSubTipoDto>();
            CreateMap<ClienteTipoModel, ClienteTipoDto>();
            CreateMap<CompaniaModel, CompaniaDto>();
            CreateMap<CondicionIvaModel, CondicionIvaDto>();
            CreateMap<CondicionPagoModel, CondicionPagoDto>();
            CreateMap<ContactoModel, ContactoDto>();
            CreateMap<EnteModel, EnteDto>();
            CreateMap<EnteDocumentoTipoModel, EnteDocumentoTipoDto>();
            CreateMap<EnteDomicilioModel, EnteDomicilioDto>();
            CreateMap<EnteDomicilioTipoModel, EnteDomicilioTipoDto>();
            CreateMap<EnteTelefonoModel, EnteTelefonoDto>();
            CreateMap<EnteTelefonoTipoModel, EnteTelefonoTipoDto>();
            CreateMap<EmpresaModel, EmpresaDto>();
            CreateMap<LocalidadModel, LocalidadDto>();
            CreateMap<LogModel, LogDto>();
            CreateMap<MovimientoCajaModel, MovimientoCajaDto>();
            CreateMap<OrdenCabeceraModel, OrdenCabeceraDto>();
            CreateMap<OrdenDetalleModel, OrdenDetalleDto>();
            CreateMap<PaisModel, PaisDto>();
            CreateMap<PartidoModel, PartidoDto>();
            CreateMap<ProveedorModel, ProveedorDto>()
                .ForMember(x => x.Facturacion, op => op.MapFrom(entity => entity))
                .ForMember(x => x.Negocio, op => op.MapFrom(entity => entity));
            CreateMap<ProvinciaModel, ProvinciaDto>();
            CreateMap<RecursoSistemaModel, RecursoSistemaDto>();
            CreateMap<RolModel, RolDto>()
                .ForMember(x => x.Recursos, op => op.MapFrom(entity => entity.Recursos.Select(x => x.Recurso)));
            CreateMap<SucursalModel, SucursalDto>();
            CreateMap<UsuarioModel, SegmentacionNegocioDto>();
            CreateMap<UsuarioModel, UsuarioDto>()
                .ForMember(x => x.Negocio, op => op.MapFrom(entity => entity));
        }
    }
}
