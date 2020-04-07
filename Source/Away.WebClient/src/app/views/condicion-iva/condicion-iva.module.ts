import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { CondicionIvaRoutingModule } from './condicion-iva-routing.module';
import { CondicionIvaListComponent } from "./list/condicion-iva-list.component";
import { CondicionIvaFormComponent } from "./form/condicion-iva-form.component";

@NgModule({
  imports: [
    CommonModule,
    CondicionIvaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    CondicionIvaListComponent,
    CondicionIvaFormComponent
  ]
})

export class CondicionIvaModule { }