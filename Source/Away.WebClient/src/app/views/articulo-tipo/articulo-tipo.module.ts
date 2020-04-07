import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloTipoRoutingModule } from './articulo-tipo-routing.module';
import { ArticuloTipoListComponent } from "./list/articulo-tipo-list.component";
import { ArticuloTipoFormComponent } from "./form/articulo-tipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    ////AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloTipoListComponent,
    ArticuloTipoFormComponent
  ]
})

export class ArticuloTipoModule { }