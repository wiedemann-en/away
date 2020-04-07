import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloRubroListComponent } from "./list/articulo-rubro-list.component";
import { ArticuloRubroFormComponent } from "./form/articulo-rubro-form.component";

const routes: Routes = [
  { path: '', data: {title: 'Artículos'}, children: [
    { path: '', component: ArticuloRubroListComponent, canActivate: [AuthGuard], data: { appState: 'articulorubro', title: 'Rubros' } },
    { path: 'form', component: ArticuloRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulorubroform' } },
    { path: 'form/:id', component: ArticuloRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulorubroform' } }

  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloRubroRoutingModule { }
