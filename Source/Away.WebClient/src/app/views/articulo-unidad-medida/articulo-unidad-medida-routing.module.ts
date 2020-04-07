import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloUnidadMedidaListComponent } from "./list/articulo-unidad-medida-list.component";
import { ArticuloUnidadMedidaFormComponent } from "./form/articulo-unidad-medida-form.component";

const routes: Routes = [
  { path: '', data: {title: 'Articulos'}, children: [
    { path: '', component: ArticuloUnidadMedidaListComponent, canActivate: [AuthGuard], data: { appState: 'articulounidadmedida', title: 'Unidades de Medida' } },
    { path: 'form', component: ArticuloUnidadMedidaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulounidadmedidaform' } },
    { path: 'form/:id', component: ArticuloUnidadMedidaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulounidadmedidaform' } }
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloUnidadMedidaRoutingModule { }
