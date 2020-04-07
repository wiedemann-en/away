import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { CompaniaListComponent } from "./list/compania-list.component";
import { CompaniaFormComponent } from "./form/compania-form.component";

const routes: Routes = [
  { path: '', component: CompaniaListComponent, canActivate: [AuthGuard], data: { appState: 'compania' } },
  { path: 'form', component: CompaniaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'companiaform' } },
  { path: 'form/:id', component: CompaniaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'companiaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class CompaniaRoutingModule { }
