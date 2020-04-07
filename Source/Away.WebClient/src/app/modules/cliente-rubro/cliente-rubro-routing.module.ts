import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ClienteRubroListComponent } from "./list/cliente-rubro-list.component";
import { ClienteRubroFormComponent } from "./form/cliente-rubro-form.component";

const routes: Routes = [
  { path: '', component: ClienteRubroListComponent, canActivate: [AuthGuard], data: { appState: 'clienterubro' } },
  { path: 'form', component: ClienteRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clienterubroform' } },
  { path: 'form/:id', component: ClienteRubroFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'clienterubroform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ClienteRubroRoutingModule { }
