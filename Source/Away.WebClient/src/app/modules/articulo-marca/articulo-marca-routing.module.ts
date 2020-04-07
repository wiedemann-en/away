import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ArticuloMarcaListComponent } from "./list/articulo-marca-list.component";
import { ArticuloMarcaFormComponent } from "./form/articulo-marca-form.component";

const routes: Routes = [
  { path: '', component: ArticuloMarcaListComponent, canActivate: [AuthGuard], data: { appState: 'articulomarca' } },
  { path: 'form', component: ArticuloMarcaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulomarcaform' } },
  { path: 'form/:id', component: ArticuloMarcaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'articulomarcaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ArticuloMarcaRoutingModule { }
