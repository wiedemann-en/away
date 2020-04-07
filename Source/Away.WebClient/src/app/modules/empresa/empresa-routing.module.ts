import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { EmpresaListComponent } from "./list/empresa-list.component";
import { EmpresaFormComponent } from "./form/empresa-form.component";

const routes: Routes = [
  { path: '', component: EmpresaListComponent, canActivate: [AuthGuard], data: { appState: 'empresa' } },
  { path: 'form', component: EmpresaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'empresaform' } },
  { path: 'form/:id', component: EmpresaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'empresaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class EmpresaRoutingModule { }
