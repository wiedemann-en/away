import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { EnteDomicilioTipoRoutingModule } from './ente-domicilio-tipo-routing.module';
import { EnteDomicilioTipoListComponent } from "./list/ente-domicilio-tipo-list.component";
import { EnteDomicilioTipoFormComponent } from "./form/ente-domicilio-tipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    EnteDomicilioTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    EnteDomicilioTipoListComponent,
    EnteDomicilioTipoFormComponent
  ]
})

export class EnteDomicilioTipoModule { }