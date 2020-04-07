import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ClienteCategoriaListComponent } from "./list/cliente-categoria-list.component";
import { ClienteCategoriaFormComponent } from "./form/cliente-categoria-form.component";

const routes: Routes = [
  { path: '', component: ClienteCategoriaListComponent, canActivate: [AuthGuard], data: { appState: 'clientecategoria' } },
  { path: 'form', component: ClienteCategoriaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientecategoriaform' } },
  { path: 'form/:id', component: ClienteCategoriaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientecategoriaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ClienteCategoriaRoutingModule { }
