import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloCategoriaListComponent } from "./list/articulo-categoria-list.component";
import { ArticuloCategoriaFormComponent } from "./form/articulo-categoria-form.component";

const routes: Routes = [
  { path: '', component: ArticuloCategoriaListComponent, canActivate: [AuthGuard], data: { appState: 'articulocategoria' } },
  { path: 'form', component: ArticuloCategoriaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulocategoriaform' } },
  { path: 'form/:id', component: ArticuloCategoriaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulocategoriaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloCategoriaRoutingModule { }
