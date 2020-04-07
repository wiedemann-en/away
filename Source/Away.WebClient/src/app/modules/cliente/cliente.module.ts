import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ClienteRoutingModule } from './cliente-routing.module';
import { ClienteListComponent } from "./list/cliente-list.component";
import { ClienteFormComponent } from "./form/cliente-form.component";

@NgModule({
  imports: [
    CommonModule,
    ClienteRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ClienteListComponent,
    ClienteFormComponent
  ]
})

export class ClienteModule { }