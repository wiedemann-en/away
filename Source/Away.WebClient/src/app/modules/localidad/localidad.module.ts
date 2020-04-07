import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { LocalidadRoutingModule } from './localidad-routing.module';
import { LocalidadListComponent } from "./list/localidad-list.component";
import { LocalidadFormComponent } from "./form/localidad-form.component";

@NgModule({
  imports: [
    CommonModule,
    LocalidadRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    LocalidadListComponent,
    LocalidadFormComponent
  ]
})

export class LocalidadModule { }