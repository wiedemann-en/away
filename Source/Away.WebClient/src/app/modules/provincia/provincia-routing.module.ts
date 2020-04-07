import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ProvinciaListComponent } from "./list/provincia-list.component";
import { ProvinciaFormComponent } from "./form/provincia-form.component";

const routes: Routes = [
  { path: '', component: ProvinciaListComponent, canActivate: [AuthGuard], data: { appState: 'provincia' } },
  { path: 'form', component: ProvinciaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'provinciaform' } },
  { path: 'form/:id', component: ProvinciaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'provinciaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ProvinciaRoutingModule { }
