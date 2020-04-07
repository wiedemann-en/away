import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { MovimientoCajaListComponent } from "./list/movimiento-caja-list.component";
import { MovimientoCajaFormComponent } from "./form/movimiento-caja-form.component";

const routes: Routes = [
  { path: '', component: MovimientoCajaListComponent, canActivate: [AuthGuard], data: { appState: 'movimientocaja' } },
  { path: 'form', component: MovimientoCajaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'movimientocajaform' } },
  { path: 'form/:id', component: MovimientoCajaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'movimientocajaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class MovimientoCajaRoutingModule { }
