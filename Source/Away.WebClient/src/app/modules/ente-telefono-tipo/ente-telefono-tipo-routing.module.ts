import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { EnteTelefonoTipoListComponent } from "./list/ente-telefono-tipo-list.component";
import { EnteTelefonoTipoFormComponent } from "./form/ente-telefono-tipo-form.component";

const routes: Routes = [
  { path: '', component: EnteTelefonoTipoListComponent, canActivate: [AuthGuard], data: { appState: 'entetelefonotipo' } },
  { path: 'form', component: EnteTelefonoTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entetelefonotipoform' } },
  { path: 'form/:id', component: EnteTelefonoTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entetelefonotipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class EnteTelefonoTipoRoutingModule { }
