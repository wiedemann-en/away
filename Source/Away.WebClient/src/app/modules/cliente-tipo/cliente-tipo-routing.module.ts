import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ClienteTipoListComponent } from "./list/cliente-tipo-list.component";
import { ClienteTipoFormComponent } from "./form/cliente-tipo-form.component";

const routes: Routes = [
  { path: '', component: ClienteTipoListComponent, canActivate: [AuthGuard], data: { appState: 'clientetipo' } },
  { path: 'form', component: ClienteTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientetipoform' } },
  { path: 'form/:id', component: ClienteTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientetipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ClienteTipoRoutingModule { }
