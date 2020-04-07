import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloRoutingModule } from './articulo-routing.module';
import { ArticuloListComponent } from "./list/articulo-list.component";
import { ArticuloFormComponent } from "./form/articulo-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloListComponent,
    ArticuloFormComponent
  ]
})

export class ArticuloModule { }