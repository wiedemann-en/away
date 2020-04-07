import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { CondicionIvaListComponent } from "./list/condicion-iva-list.component";
import { CondicionIvaFormComponent } from "./form/condicion-iva-form.component";

const routes: Routes = [
  { path: '', component: CondicionIvaListComponent, canActivate: [AuthGuard], data: { appState: 'condicioniva' } },
  { path: 'form', component: CondicionIvaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'condicionivaform' } },
  { path: 'form/:id', component: CondicionIvaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'condicionivaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class CondicionIvaRoutingModule { }
