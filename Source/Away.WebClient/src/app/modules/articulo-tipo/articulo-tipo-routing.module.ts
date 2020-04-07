import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloTipoListComponent } from "./list/articulo-tipo-list.component";
import { ArticuloTipoFormComponent } from "./form/articulo-tipo-form.component";

const routes: Routes = [
  { path: '', component: ArticuloTipoListComponent, canActivate: [AuthGuard], data: { appState: 'articulotipo' } },
  { path: 'form', component: ArticuloTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulotipoform' } },
  { path: 'form/:id', component: ArticuloTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulotipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloTipoRoutingModule { }
