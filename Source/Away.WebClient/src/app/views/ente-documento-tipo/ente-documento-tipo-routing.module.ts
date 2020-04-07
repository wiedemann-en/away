import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { EnteDocumentoTipoListComponent } from "./list/ente-documento-tipo-list.component";
import { EnteDocumentoTipoFormComponent } from "./form/ente-documento-tipo-form.component";

const routes: Routes = [
  { path: '', component: EnteDocumentoTipoListComponent, canActivate: [AuthGuard], data: { appState: 'entedocumentotipo' } },
  { path: 'form', component: EnteDocumentoTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entedocumentotipoform' } },
  { path: 'form/:id', component: EnteDocumentoTipoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'entedocumentotipoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class EnteDocumentoTipoRoutingModule { }
