import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ClienteRubroRoutingModule } from './cliente-rubro-routing.module';
import { ClienteRubroListComponent } from "./list/cliente-rubro-list.component";
import { ClienteRubroFormComponent } from "./form/cliente-rubro-form.component";

@NgModule({
  imports: [
    CommonModule,
    ClienteRubroRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    ////AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ClienteRubroListComponent,
    ClienteRubroFormComponent
  ]
})

export class ClienteRubroModule { }