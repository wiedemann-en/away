import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ProveedorRoutingModule } from './proveedor-routing.module';
import { ProveedorListComponent } from "./list/proveedor-list.component";
import { ProveedorFormComponent } from "./form/proveedor-form.component";

@NgModule({
  imports: [
    CommonModule,
    ProveedorRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ProveedorListComponent,
    ProveedorFormComponent
  ]
})

export class ProveedorModule { }