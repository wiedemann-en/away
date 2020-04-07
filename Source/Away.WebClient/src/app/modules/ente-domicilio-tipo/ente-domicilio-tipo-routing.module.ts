import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { EnteDomicilioTipoListComponent } from "./list/ente-domicilio-tipo-list.component";
import { EnteDomicilioTipoFormComponent } from "./form/ente-domicilio-tipo-form.component";

const routes: Routes = [
  { path: '', component: EnteDomicilioTipoListComponent, canActivate: [AuthGuard], data: { appState: 'entedomiciliotipo' } },
  { path: 'form', component: EnteDomicilioTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entedomiciliotipoform' } },
  { path: 'form/:id', component: EnteDomicilioTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entedomiciliotipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class EnteDomicilioTipoRoutingModule { }
