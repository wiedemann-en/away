import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloLineaListComponent } from "./list/articulo-linea-list.component";
import { ArticuloLineaFormComponent } from "./form/articulo-linea-form.component";

const routes: Routes = [
  { path: '', component: ArticuloLineaListComponent, canActivate: [AuthGuard], data: { appState: 'articulolinea' } },
  { path: 'form', component: ArticuloLineaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulolineaform' } },
  { path: 'form/:id', component: ArticuloLineaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulolineaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloLineaRoutingModule { }
