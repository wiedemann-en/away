import { NgModule } from '@angular/core';
import { AlertService } from './alert.service';
import { AlicuotaIvaService } from './alicuota-iva.service';
import { ApiService } from './api.service';
import { ArticuloCategoriaService } from './articulo-categoria.service';
import { ArticuloLineaService } from './articulo-linea.service';
import { ArticuloMarcaService } from './articulo-marca.service';
import { ArticuloRubroService } from './articulo-rubro.service';
import { ArticuloSubTipoService } from './articulo-subtipo.service';
import { ArticuloTipoService } from './articulo-tipo.service';
import { ArticuloUnidadMedidaService } from './articulo-unidad-medida.service';
import { ArticuloService } from './articulo.service';
import { BaseService } from './base.service';
import { BroadcastService } from './broadcast.service';
import { ClienteCategoriaService } from './cliente-categoria.service';
import { ClienteRubroService } from './cliente-rubro.service';
import { ClienteSubTipoService } from './cliente-subtipo.service';
import { ClienteTipoService } from './cliente-tipo.service';
import { ClienteService } from './cliente.service';
import { CompaniaService } from './compania.service';
import { CondicionIvaService } from './condicion-iva.service';
import { CondicionPagoService } from './condicion-pago.service';
import { ContactoService } from './contacto.service';
import { EmpresaService } from './empresa.service';
import { EnteDocumentoTipoService } from './ente-documento-tipo.service';
import { EnteDomicilioTipoService } from './ente-domicilio-tipo.service';
import { EnteTelefonoTipoService } from './ente-telefono-tipo.service';
import { LocalidadService } from './localidad.service';
import { LoginService } from './login.service';
import { MovimientoCajaService } from './movimiento-caja.service';
import { OrdenService } from './orden.service';
import { PaisService } from './pais.service';
import { PartidoService } from './partido.service';
import { ProveedorService } from './proveedor.service';
import { ProvinciaService } from './provincia.service';
import { RolService } from './rol.service';
import { SucursalService } from './sucursal.service';
import { UsuarioService } from './usuario.service';


@NgModule({
  imports:[
    
  ],
  providers: [
       
    AlertService,
    AlicuotaIvaService,
    ApiService,
    ArticuloCategoriaService,
    ArticuloLineaService,
    ArticuloMarcaService,
    ArticuloRubroService,
    ArticuloSubTipoService,
    ArticuloTipoService,
    ArticuloUnidadMedidaService,
    ArticuloService,
    BaseService,
    BroadcastService,
    ClienteCategoriaService,
    ClienteRubroService,
    ClienteSubTipoService,
    ClienteTipoService,
    ClienteService,
    CompaniaService,
    CondicionIvaService,
    CondicionPagoService,
    ContactoService,
    EmpresaService,
    EnteDocumentoTipoService,
    EnteDomicilioTipoService,
    EnteTelefonoTipoService,
    LocalidadService,
    LoginService,
    MovimientoCajaService,
    OrdenService,
    PaisService,
    PartidoService,
    ProveedorService,
    ProvinciaService,
    RolService,
    SucursalService,
    UsuarioService

  ]
})

export class ServicesModule { }