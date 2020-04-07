import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { ContactoListComponent } from "./list/contacto-list.component";
import { ContactoFormComponent } from "./form/contacto-form.component";

const routes: Routes = [
  { path: '', component: ContactoListComponent, canActivate: [AuthGuard], data: { appState: 'contacto' } },
  { path: 'form', component: ContactoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'contactoform' } },
  { path: 'form/:id', component: ContactoFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'contactoform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ContactoRoutingModule { }
