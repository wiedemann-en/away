import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { PaisRoutingModule } from './pais-routing.module';
import { PaisListComponent } from "./list/pais-list.component";
import { PaisFormComponent } from "./form/pais-form.component";

@NgModule({
  imports: [
    CommonModule,
    PaisRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    PaisListComponent,
    PaisFormComponent
  ]
})

export class PaisModule { }