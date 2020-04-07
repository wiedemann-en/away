import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { OrdenRoutingModule } from './orden-routing.module';
import { OrdenListComponent } from "./list/orden-list.component";
import { OrdenFormComponent } from "./form/orden-form.component";

@NgModule({
  imports: [
    CommonModule,
    OrdenRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    OrdenListComponent,
    OrdenFormComponent
  ]
})

export class OrdenModule { }