import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { CondicionPagoListComponent } from "./list/condicion-pago-list.component";
import { CondicionPagoFormComponent } from "./form/condicion-pago-form.component";

const routes: Routes = [
  { path: '', component: CondicionPagoListComponent, canActivate: [AuthGuard], data: { appState: 'condicionpago' } },
  { path: 'form', component: CondicionPagoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'condicionpagoform' } },
  { path: 'form/:id', component: CondicionPagoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'condicionpagoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class CondicionPagoRoutingModule { }
