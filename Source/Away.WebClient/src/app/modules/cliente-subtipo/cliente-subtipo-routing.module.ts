import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ClienteSubTipoListComponent } from "./list/cliente-subtipo-list.component";
import { ClienteSubTipoFormComponent } from "./form/cliente-subtipo-form.component";

const routes: Routes = [
  { path: '', component: ClienteSubTipoListComponent, canActivate: [AuthGuard], data: { appState: 'clientesubtipo' } },
  { path: 'form', component: ClienteSubTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientesubtipoform' } },
  { path: 'form/:id', component: ClienteSubTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clientesubtipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ClienteSubTipoRoutingModule { }
