import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
// revisar import { NgHttpLoaderModule } from 'ng-http-loader';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


/* Shared Component */
import { ConfirmationDialogComponent } from '../../shared/confirmation-dialog/confirmation-dialog.component';


/* Authentication Helpers */
import { AuthHelpers } from '../../auth/auth-helpers';
import { AuthGuard } from '../../auth/auth-guard';

/* Common Helpers */
import { CommonConfig } from '../../common/common-config';
import { CommonHelpers } from '../../common/common-helpers';
import { CommonDialog } from '../../common/common-dialog';

/* Interceptors */
import { ErrorInterceptor } from '../../interceptors/error-interceptor';
import { JwtInterceptor } from '../../interceptors/jwt-interceptor';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

/* Logic Services */
import { ServicesModule } from '../../services/services.module';

/* Layout Routing */
import { CoreRoutingModule } from './core-routing.module';

/* Business Logic Modules */
//TODO: Ver de unificar todos los módulos de negocio
import { AlicuotaIvaModule } from '../../views/alicuota-iva/alicuota-iva.module';
import { ArticuloModule } from '../../views/articulo/articulo.module';
import { ArticuloCategoriaModule } from '../../views/articulo-categoria/articulo-categoria.module';
import { ArticuloLineaModule } from '../../views/articulo-linea/articulo-linea.module';
import { ArticuloMarcaModule } from '../../views/articulo-marca/articulo-marca.module';
import { ArticuloRubroModule } from '../../views/articulo-rubro/articulo-rubro.module';
import { ArticuloSubTipoModule } from '../../views/articulo-subtipo/articulo-subtipo.module';
import { ArticuloTipoModule } from '../../views/articulo-tipo/articulo-tipo.module';
import { ArticuloUnidadMedidaModule } from '../../views/articulo-unidad-medida/articulo-unidad-medida.module';
import { ClienteModule } from '../../views/cliente/cliente.module';
import { ClienteCategoriaModule } from '../../views/cliente-categoria/cliente-categoria.module';
import { ClienteRubroModule } from '../../views/cliente-rubro/cliente-rubro.module';
import { ClienteSubTipoModule } from '../../views/cliente-subtipo/cliente-subtipo.module';
import { ClienteTipoModule } from '../../views/cliente-tipo/cliente-tipo.module';
import { CompaniaModule } from '../../views/compania/compania.module';
import { CondicionIvaModule } from '../../views/condicion-iva/condicion-iva.module';
import { CondicionPagoModule } from '../../views/condicion-pago/condicion-pago.module';
import { ContactoModule } from '../../views/contacto/contacto.module';
import { EmpresaModule } from '../../views/empresa/empresa.module';
import { EnteDocumentoTipoModule } from '../../views/ente-documento-tipo/ente-documento-tipo.module';
import { EnteDomicilioTipoModule } from '../../views/ente-domicilio-tipo/ente-domicilio-tipo.module';
import { EnteTelefonoTipoModule } from '../../views/ente-telefono-tipo/ente-telefono-tipo.module';
import { LocalidadModule } from '../../views/localidad/localidad.module';
import { LoginModule } from '../../views/login/login.module';
import { MovimientoCajaModule } from '../../views/movimiento-caja/movimiento-caja.module';
import { OrdenModule } from '../../views/orden/orden.module';
import { PaisModule } from '../../views/pais/pais.module';
import { PartidoModule } from '../../views/partido/partido.module';
import { ProveedorModule } from '../../views/proveedor/proveedor.module';
import { ProvinciaModule } from '../../views/provincia/provincia.module';
import { RolModule } from '../../views/rol/rol.module';
import { SucursalModule } from '../../views/sucursal/sucursal.module';
import { UnauthorizedModule } from '../../views/unauthorized/unauthorized.module';
import { UsuarioModule } from '../../views/usuario/usuario.module';
import { AngularFontAwesomeModule } from 'angular-font-awesome';



@NgModule({
  imports: [
    CommonModule,        
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    //NgHttpLoaderModule.forRoot(),
    NgbModule,

    CoreRoutingModule,
    DirectivesModule,
    ServicesModule,
    
    
    //revisar//AngularFontAwesomeModule,
    
    AlicuotaIvaModule, //TODO: Ver de unificar todos los módulos de negocio
    ArticuloModule,
    ArticuloCategoriaModule,
    ArticuloLineaModule,
    ArticuloMarcaModule,
    ArticuloRubroModule,
    ArticuloSubTipoModule,
    ArticuloTipoModule,
    ArticuloUnidadMedidaModule,
    ClienteModule,
    ClienteCategoriaModule,
    ClienteRubroModule,
    ClienteSubTipoModule,
    ClienteTipoModule,
    CompaniaModule,
    CondicionIvaModule,
    CondicionPagoModule,
    ContactoModule,
    EmpresaModule,
    EnteDocumentoTipoModule,
    EnteDomicilioTipoModule,
    EnteTelefonoTipoModule,
    LocalidadModule,
    LoginModule,
    MovimientoCajaModule,
    OrdenModule,
    PaisModule,
    PartidoModule,
    ProveedorModule,
    ProvinciaModule,
    RolModule,
    SucursalModule,
    UnauthorizedModule,
    UsuarioModule
  ],
  exports: [
    ConfirmationDialogComponent,
    // AlertComponent,
    // AppComponent,
    // HeaderComponent,
    // FooterComponent,
    // MainComponent,
    
  ], 
  providers: [
    AuthHelpers,
    AuthGuard,
    CommonConfig,
    CommonHelpers,
    CommonDialog,    
    // { 
    //   provide: HTTP_INTERCEPTORS, 
    //   useClass: JwtInterceptor, 
    //   multi: true 
    // },    
    { 
      provide: HTTP_INTERCEPTORS, 
      useClass: ErrorInterceptor, 
      multi: true 
    }    
  ], 
  declarations: [
    ConfirmationDialogComponent,
    // AlertComponent,
    // AppComponent,
    // HeaderComponent,
    // FooterComponent,
    // MainComponent,
    
    // UsuarioListComponent

  ],
  entryComponents: [
    ConfirmationDialogComponent,
    
  ]  
})

export class CoreModule { }
