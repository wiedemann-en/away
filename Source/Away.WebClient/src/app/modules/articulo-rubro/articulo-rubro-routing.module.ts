import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloRubroListComponent } from "./list/articulo-rubro-list.component";
import { ArticuloRubroFormComponent } from "./form/articulo-rubro-form.component";

const routes: Routes = [
  { path: '', component: ArticuloRubroListComponent, canActivate: [AuthGuard], data: { appState: 'articulorubro' } },
  { path: 'form', component: ArticuloRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulorubroform' } },
  { path: 'form/:id', component: ArticuloRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulorubroform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloRubroRoutingModule { }
