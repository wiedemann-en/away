import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';

import { UsuarioListComponent } from './list/usuario-list.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Core'
    },
    children: [
      { path: '', component: UsuarioListComponent, canActivate: [AuthGuard],  data: { appState: 'usuario', title: 'Usuarios' }  },
    ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsuarioRoutingModule { }
