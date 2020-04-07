import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { CompaniaRoutingModule } from './compania-routing.module';
import { CompaniaListComponent } from "./list/compania-list.component";
import { CompaniaFormComponent } from "./form/compania-form.component";

@NgModule({
  imports: [
    CommonModule,
    CompaniaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    CompaniaListComponent,
    CompaniaFormComponent
  ]
})

export class CompaniaModule { }