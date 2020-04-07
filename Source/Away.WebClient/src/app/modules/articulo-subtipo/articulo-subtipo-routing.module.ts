import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloSubTipoListComponent } from "./list/articulo-subtipo-list.component";
import { ArticuloSubTipoFormComponent } from "./form/articulo-subtipo-form.component";

const routes: Routes = [
  { path: '', component: ArticuloSubTipoListComponent, canActivate: [AuthGuard], data: { appState: 'articulosubtipo' } },
  { path: 'form', component: ArticuloSubTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulosubtipoform' } },
  { path: 'form/:id', component: ArticuloSubTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulosubtipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloSubTipoRoutingModule { }
