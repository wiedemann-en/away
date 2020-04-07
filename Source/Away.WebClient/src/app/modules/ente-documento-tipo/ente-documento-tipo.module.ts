import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { EnteDocumentoTipoRoutingModule } from './ente-documento-tipo-routing.module';
import { EnteDocumentoTipoListComponent } from "./list/ente-documento-tipo-list.component";
import { EnteDocumentoTipoFormComponent } from "./form/ente-documento-tipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    EnteDocumentoTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    EnteDocumentoTipoListComponent,
    EnteDocumentoTipoFormComponent
  ]
})

export class EnteDocumentoTipoModule { }