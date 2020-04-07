import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloListComponent } from "./list/articulo-list.component";
import { ArticuloFormComponent } from "./form/articulo-form.component";

const routes: Routes = [
  { path: '', data: {title: 'Articulos' },
  children: [
    { path: '', component: ArticuloListComponent, canActivate: [AuthGuard], data: { appState: 'articulo', title: 'Articulos' } },
    { path: 'form', component: ArticuloFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articuloform', title: 'Nuevo' } },
    { path: 'form/:id', component: ArticuloFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articuloform' } }
  ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloRoutingModule { }
