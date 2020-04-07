import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { CondicionPagoRoutingModule } from './condicion-pago-routing.module';
import { CondicionPagoListComponent } from "./list/condicion-pago-list.component";
import { CondicionPagoFormComponent } from "./form/condicion-pago-form.component";

@NgModule({
  imports: [
    CommonModule,
    CondicionPagoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    CondicionPagoListComponent,
    CondicionPagoFormComponent
  ]
})

export class CondicionPagoModule { }