import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { SucursalRoutingModule } from './sucursal-routing.module';
import { SucursalListComponent } from "./list/sucursal-list.component";
import { SucursalFormComponent } from "./form/sucursal-form.component";

@NgModule({
  imports: [
    CommonModule,
    SucursalRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    SucursalListComponent,
    SucursalFormComponent
  ]
})

export class SucursalModule { }