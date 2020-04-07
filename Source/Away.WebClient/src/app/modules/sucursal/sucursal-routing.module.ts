import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { SucursalListComponent } from "./list/sucursal-list.component";
import { SucursalFormComponent } from "./form/sucursal-form.component";

const routes: Routes = [
  { path: '', component: SucursalListComponent, canActivate: [AuthGuard], data: { appState: 'sucursal' } },
  { path: 'form', component: SucursalFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'sucursalform' } },
  { path: 'form/:id', component: SucursalFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'sucursalform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SucursalRoutingModule { }
