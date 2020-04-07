import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { PartidoListComponent } from "./list/partido-list.component";
import { PartidoFormComponent } from "./form/partido-form.component";

const routes: Routes = [
  { path: '', component: PartidoListComponent, canActivate: [AuthGuard], data: { appState: 'partido' } },
  { path: 'form', component: PartidoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'partidoform' } },
  { path: 'form/:id', component: PartidoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'partidoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class PartidoRoutingModule { }
