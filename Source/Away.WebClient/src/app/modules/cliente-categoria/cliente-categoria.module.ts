import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ClienteCategoriaRoutingModule } from './cliente-categoria-routing.module';
import { ClienteCategoriaListComponent } from "./list/cliente-categoria-list.component";
import { ClienteCategoriaFormComponent } from "./form/cliente-categoria-form.component";

@NgModule({
  imports: [
    CommonModule,
    ClienteCategoriaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ClienteCategoriaListComponent,
    ClienteCategoriaFormComponent
  ]
})

export class ClienteCategoriaModule { }