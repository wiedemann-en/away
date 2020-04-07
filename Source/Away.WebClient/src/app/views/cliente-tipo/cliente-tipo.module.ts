import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ClienteTipoRoutingModule } from './cliente-tipo-routing.module';
import { ClienteTipoListComponent } from "./list/cliente-tipo-list.component";
import { ClienteTipoFormComponent } from "./form/cliente-tipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    ClienteTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ClienteTipoListComponent,
    ClienteTipoFormComponent
  ]
})

export class ClienteTipoModule { }