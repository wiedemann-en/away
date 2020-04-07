import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';


const routes: Routes = [
  { 
    path: '', children: [
      { path: '', redirectTo: '/usuarios', pathMatch: 'full', canActivate: [AuthGuard] },
      { path: 'login', loadChildren: '../login/login.module#LoginModule', pathMatch: 'full' },
      { path: 'alicuotasiva', loadChildren: '../alicuota-iva/alicuota-iva.module#AlicuotaIvaModule', canActivate: [AuthGuard], data: { appState: 'alicuotaiva' } },
      { path: 'articulos', loadChildren: '../articulo/articulo.module#ArticuloModule', canActivate: [AuthGuard], data: { appState: 'articulo' } },
      { path: 'articulocategorias', loadChildren: '../articulo-categoria/articulo-categoria.module#ArticuloCategoriaModule', canActivate: [AuthGuard], data: { appState: 'articulocategoria' } },
      { path: 'articulolineas', loadChildren: '../articulo-linea/articulo-linea.module#ArticuloLineaModule', canActivate: [AuthGuard], data: { appState: 'articulolinea' } },
      { path: 'articulomarcas', loadChildren: '../articulo-marca/articulo-marca.module#ArticuloMarcaModule', canActivate: [AuthGuard], data: { appState: 'articulomarca' } },
      { path: 'articulorubros', loadChildren: '../articulo-rubro/articulo-rubro.module#ArticuloRubroModule', canActivate: [AuthGuard], data: { appState: 'articulorubro' } },
      { path: 'articulosubtipos', loadChildren: '../articulo-subtipo/articulo-subtipo.module#ArticuloSubTipoModule', canActivate: [AuthGuard], data: { appState: 'articulosubtipo' } },
      { path: 'articulotipos', loadChildren: '../articulo-tipo/articulo-tipo.module#ArticuloTipoModule', canActivate: [AuthGuard], data: { appState: 'articulotipo' } },
      { path: 'articulounidadesmedida', loadChildren: '../articulo-unidad-medida/articulo-unidad-medida.module#ArticuloUnidadMedidaModule', canActivate: [AuthGuard], data: { appState: 'articulounidadmedida' } },
      { path: 'clientes', loadChildren: '../cliente/cliente.module#ClienteModule', canActivate: [AuthGuard], data: { appState: 'cliente' } },
      { path: 'clientecategorias', loadChildren: '../cliente-categoria/cliente-categoria.module#ClienteCategoriaModule', canActivate: [AuthGuard], data: { appState: 'clientecategoria' } },
      { path: 'clienterubros', loadChildren: '../cliente-rubro/cliente-rubro.module#ClienteRubroModule', canActivate: [AuthGuard], data: { appState: 'clienterubro' } },
      { path: 'clientesubtipos', loadChildren: '../cliente-subtipo/cliente-subtipo.module#ClienteSubTipoModule', canActivate: [AuthGuard], data: { appState: 'clientesubtipo' } },
      { path: 'clientetipos', loadChildren: '../cliente-tipo/cliente-tipo.module#ClienteTipoModule', canActivate: [AuthGuard], data: { appState: 'clientetipo' } },
      { path: 'companias', loadChildren: '../compania/compania.module#CompaniaModule', canActivate: [AuthGuard], data: { appState: 'compania' } },
      { path: 'condicionesiva', loadChildren: '../condicion-iva/condicion-iva.module#CondicionIvaModule', canActivate: [AuthGuard], data: { appState: 'condicioniva' } },
      { path: 'condicionespago', loadChildren: '../condicion-pago/condicion-pago.module#CondicionPagoModule', canActivate: [AuthGuard], data: { appState: 'condicionpago' } },
      { path: 'contactos', loadChildren: '../contacto/contacto.module#ContactoModule', canActivate: [AuthGuard], data: { appState: 'contacto' } },
      { path: 'empresas', loadChildren: '../empresa/empresa.module#EmpresaModule', canActivate: [AuthGuard], data: { appState: 'empresa' } },
      { path: 'entedocumentotipos', loadChildren: '../ente-documento-tipo/ente-documento-tipo.module#EnteDocumentoTipoModule', canActivate: [AuthGuard], data: { appState: 'entedocumentotipo' } },
      { path: 'entedomiciliotipos', loadChildren: '../ente-domicilio-tipo/ente-domicilio-tipo.module#EnteDomicilioTipoModule', canActivate: [AuthGuard], data: { appState: 'entedomiciliotipo' } },
      { path: 'entetelefonotipos', loadChildren: '../ente-telefono-tipo/ente-telefono-tipo.module#EnteTelefonoTipoModule', canActivate: [AuthGuard], data: { appState: 'entetelefonotipo' } },
      { path: 'localidades', loadChildren: '../localidad/localidad.module#LocalidadModule', canActivate: [AuthGuard], data: { appState: 'localidad' } },
      { path: 'movimientoscaja', loadChildren: '../movimiento-caja/movimiento-caja.module#MovimientoCajaModule', canActivate: [AuthGuard], data: { appState: 'movimientocaja' } },
      { path: 'ordenes', loadChildren: '../orden/orden.module#OrdenModule', canActivate: [AuthGuard], data: { appState: 'orden' } },
      { path: 'paises', loadChildren: '../pais/pais.module#PaisModule', canActivate: [AuthGuard], data: { appState: 'pais' } },
      { path: 'partidos', loadChildren: '../partido/partido.module#PartidoModule', canActivate: [AuthGuard], data: { appState: 'partido' } },
      { path: 'proveedores', loadChildren: '../proveedor/proveedor.module#ProveedorModule', canActivate: [AuthGuard], data: { appState: 'proveedor' } },
      { path: 'provincias', loadChildren: '../provincia/provincia.module#ProvinciaModule', canActivate: [AuthGuard], data: { appState: 'provincia' } },
      { path: 'roles', loadChildren: '../rol/rol.module#RolModule', canActivate: [AuthGuard], data: { appState: 'rol' } },
      { path: 'sucursales', loadChildren: '../sucursal/sucursal.module#SucursalModule', canActivate: [AuthGuard], data: { appState: 'sucursal' } },
      { path: 'usuarios', loadChildren: '../usuario/usuario.module#UsuarioModule', canActivate: [AuthGuard], data: { appState: 'usuario' } },
      { path: 'unauthorized', loadChildren: '../unauthorized/unauthorized.module#UnauthorizedModule', pathMatch: 'full' },      
      // { path: '**', component: PagenotfoundComponent }
    ]
  }
];

@NgModule({
  imports: [ 
    RouterModule.forRoot(routes) 
  ],
  exports: [
    RouterModule
  ]
})

export class CoreRoutingModule { }
