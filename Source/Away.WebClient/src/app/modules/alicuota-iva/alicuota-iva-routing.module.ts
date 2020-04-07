import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from '../../auth/auth-guard';
import { AlicuotaIvaListComponent } from "./list/alicuota-iva-list.component";
import { AlicuotaIvaFormComponent } from "./form/alicuota-iva-form.component";

const routes: Routes = [
  { path: '', component: AlicuotaIvaListComponent, canActivate: [AuthGuard], data: { appState: 'alicuotaiva' } },
  { path: 'form', component: AlicuotaIvaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'alicuotaivaform' } },
  { path: 'form/:id', component: AlicuotaIvaFormComponent, pathMatch: 'full', canActivate: [AuthGuard], data: { appState: 'alicuotaivaform' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class AlicuotaIvaRoutingModule { }
