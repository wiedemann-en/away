import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { CoreModule } from './core.module';
import { UsuarioModule } from '../../views/usuario/usuario.module';
import { UsuarioListComponent } from '../../views/usuario/list/usuario-list.component';
import { UsuarioFormComponent } from '../../views/usuario/form/usuario-form.component';


const routes: Routes = [
  { 

    path: '', children: [
       { path: '', redirectTo: '/usuarios', pathMatch: 'full' },
       // { path: 'usuarios', component: UsuarioListComponent},

       // seguridad
      {path: 'usuarios', loadChildren: () => import('../../views/usuario/usuario.module')
        .then(m => m.UsuarioModule)},
      {path: 'roles', loadChildren: () => import('../../views/rol/rol.module')
        .then(m => m.RolModule)},

        // datos generales
      {path: 'alicuotasiva', loadChildren: () => import('../../views/alicuota-iva/alicuota-iva.module')
        .then(m => m.AlicuotaIvaModule)},
      {path: 'condicionesiva', loadChildren: () => import('../../views/condicion-iva/condicion-iva.module')
        .then(m => m.CondicionIvaModule)},
      {path: 'condicionespago', loadChildren: () => import('../../views/condicion-pago/condicion-pago.module')
        .then(m => m.CondicionPagoModule)},
      {path: 'documento-tipos', loadChildren: () => import('../../views/ente-documento-tipo/ente-documento-tipo.module')
        .then(m => m.EnteDocumentoTipoModule)},
      {path: 'domicilio-tipos', loadChildren: () => import('../../views/ente-domicilio-tipo/ente-domicilio-tipo.module')
        .then(m => m.EnteDomicilioTipoModule)},
      {path: 'paises', loadChildren: () => import('../../views/pais/pais.module')
        .then(m => m.PaisModule)},
      {path: 'provincias', loadChildren: () => import('../../views/provincia/provincia.module')
        .then(m => m.ProvinciaModule)},
      {path: 'partidos', loadChildren: () => import('../../views/partido/partido.module')
        .then(m => m.PartidoModule)},
      {path: 'localidades', loadChildren: () => import('../../views/localidad/localidad.module')
        .then(m => m.LocalidadModule)},

        // articulos
      {path: 'articulos', loadChildren: () => import('../../views/articulo/articulo.module')
        .then(m => m.ArticuloModule)},
      {path: 'articulo-categorias', loadChildren: () => import('../../views/articulo-categoria/articulo-categoria.module')
        .then(m => m.ArticuloCategoriaModule)},
      {path: 'articulo-rubros', loadChildren: () => import('../../views/articulo-rubro/articulo-rubro.module')
        .then(m => m.ArticuloRubroModule)},
      {path: 'articulo-tipos', loadChildren: () => import('../../views/articulo-tipo/articulo-tipo.module')
        .then(m => m.ArticuloTipoModule)},
      {path: 'articulo-subtipos', loadChildren: () => import('../../views/articulo-subtipo/articulo-subtipo.module')
        .then(m => m.ArticuloSubTipoModule)},
      {path: 'articulo-lineas', loadChildren: () => import('../../views/articulo-linea/articulo-linea.module')
        .then(m => m.ArticuloLineaModule)},
      {path: 'articulo-marcas', loadChildren: () => import('../../views/articulo-marca/articulo-marca.module')
        .then(m => m.ArticuloMarcaModule)},
      {path: 'articulo-unidad-medida', loadChildren: () => import('../../views/articulo-unidad-medida/articulo-unidad-medida.module')
        .then(m => m.ArticuloUnidadMedidaModule)},

        // articulos
      {path: 'clientes', loadChildren: () => import('../../views/cliente/cliente.module')
        .then(m => m.ClienteModule)},
      {path: 'cliente-categorias', loadChildren: () => import('../../views/cliente-categoria/cliente-categoria.module')
        .then(m => m.ClienteCategoriaModule)},
      {path: 'cliente-rubros', loadChildren: () => import('../../views/cliente-rubro/cliente-rubro.module')
        .then(m => m.ClienteRubroModule)},
      {path: 'cliente-tipos', loadChildren: () => import('../../views/cliente-tipo/cliente-tipo.module')
        .then(m => m.ClienteTipoModule)},
      {path: 'cliente-subtipos', loadChildren: () => import('../../views/cliente-subtipo/cliente-subtipo.module')
        .then(m => m.ClienteSubTipoModule)},

    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})

 export class CoreRoutingModule { }
