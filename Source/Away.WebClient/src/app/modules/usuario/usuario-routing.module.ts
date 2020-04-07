import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { UsuarioListComponent } from "./list/usuario-list.component";
import { UsuarioFormComponent } from "./form/usuario-form.component";

const routes: Routes = [
  { path: '', component: UsuarioListComponent, canActivate: [AuthGuard], data: { appState: 'usuario' } },
  { path: 'form', component: UsuarioFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'usuarioform' } },
  { path: 'form/:id', component: UsuarioFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'usuarioform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class UsuarioRoutingModule { }
