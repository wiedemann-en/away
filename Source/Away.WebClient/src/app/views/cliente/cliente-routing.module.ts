import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ClienteListComponent } from "./list/cliente-list.component";
import { ClienteFormComponent } from "./form/cliente-form.component";

const routes: Routes = [
  { path: '', data: {title: 'Clientes'}, children: [
    { path: '', component: ClienteListComponent, canActivate: [AuthGuard], data: { appState: 'cliente', titles: 'Clientes' } },
    { path: 'form', component: ClienteFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clienteform' } },
    { path: 'form/:id', component: ClienteFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clienteform' } }
  ]}

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ClienteRoutingModule { }
