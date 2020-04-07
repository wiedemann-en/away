import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { RolListComponent } from "./list/rol-list.component";
import { RolFormComponent } from "./form/rol-form.component";

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Core'
    },
children: [
  { path: '', component: RolListComponent, canActivate: [AuthGuard], data: { appState: 'rol', title: 'Roles' } },
  { path: 'form', component: RolFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'rolform' } },
  { path: 'form/:id', component: RolFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'rolform' } }
]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class RolRoutingModule { }
