import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { LocalidadListComponent } from "./list/localidad-list.component";
import { LocalidadFormComponent } from "./form/localidad-form.component";

const routes: Routes = [
  { path: '', component: LocalidadListComponent, canActivate: [AuthGuard], data: { appState: 'localidad' } },
  { path: 'form', component: LocalidadFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'localidadform' } },
  { path: 'form/:id', component: LocalidadFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'localidadform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class LocalidadRoutingModule { }
