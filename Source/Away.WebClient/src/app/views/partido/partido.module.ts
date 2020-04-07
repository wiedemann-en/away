import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { PartidoRoutingModule } from './partido-routing.module';
import { PartidoListComponent } from "./list/partido-list.component";
import { PartidoFormComponent } from "./form/partido-form.component";

@NgModule({
  imports: [
    CommonModule,
    PartidoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    PartidoListComponent,
    PartidoFormComponent
  ]
})

export class PartidoModule { }