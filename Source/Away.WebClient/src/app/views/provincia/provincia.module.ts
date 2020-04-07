import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ProvinciaRoutingModule } from './provincia-routing.module';
import { ProvinciaListComponent } from "./list/provincia-list.component";
import { ProvinciaFormComponent } from "./form/provincia-form.component";

@NgModule({
  imports: [
    CommonModule,
    ProvinciaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ProvinciaListComponent,
    ProvinciaFormComponent
  ]
})

export class ProvinciaModule { }