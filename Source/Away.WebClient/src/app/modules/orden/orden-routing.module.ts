import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { OrdenListComponent } from "./list/orden-list.component";
import { OrdenFormComponent } from "./form/orden-form.component";

const routes: Routes = [
  { path: '', component: OrdenListComponent, canActivate: [AuthGuard], data: { appState: 'orden' } },
  { path: 'form', component: OrdenFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'ordenform' } },
  { path: 'form/:id', component: OrdenFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'ordenform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class OrdenRoutingModule { }
