import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { EnteTelefonoTipoRoutingModule } from './ente-telefono-tipo-routing.module';
import { EnteTelefonoTipoListComponent } from "./list/ente-telefono-tipo-list.component";
import { EnteTelefonoTipoFormComponent } from "./form/ente-telefono-tipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    EnteTelefonoTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    EnteTelefonoTipoListComponent,
    EnteTelefonoTipoFormComponent
  ]
})

export class EnteTelefonoTipoModule { }