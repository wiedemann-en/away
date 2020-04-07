import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ProveedorListComponent } from "./list/proveedor-list.component";
import { ProveedorFormComponent } from "./form/proveedor-form.component";

const routes: Routes = [
  { path: '', component: ProveedorListComponent, canActivate: [AuthGuard], data: { appState: 'proveedor' } },
  { path: 'form', component: ProveedorFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'proveedorform' } },
  { path: 'form/:id', component: ProveedorFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'proveedorform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ProveedorRoutingModule { }
