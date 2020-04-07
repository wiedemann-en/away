import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ClienteSubTipoRoutingModule } from './cliente-subtipo-routing.module';
import { ClienteSubTipoListComponent } from "./list/cliente-subtipo-list.component";
import { ClienteSubTipoFormComponent } from "./form/cliente-subtipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    ClienteSubTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ClienteSubTipoListComponent,
    ClienteSubTipoFormComponent
  ]
})

export class ClienteSubTipoModule { }