import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { PaisListComponent } from "./list/pais-list.component";
import { PaisFormComponent } from "./form/pais-form.component";

const routes: Routes = [
  { path: '', component: PaisListComponent, canActivate: [AuthGuard], data: { appState: 'pais' } },
  { path: 'form', component: PaisFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'paisform' } },
  { path: 'form/:id', component: PaisFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'paisform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class PaisRoutingModule { }
