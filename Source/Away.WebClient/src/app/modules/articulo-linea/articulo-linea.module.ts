import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloLineaRoutingModule } from './articulo-linea-routing.module';
import { ArticuloLineaListComponent } from "./list/articulo-linea-list.component";
import { ArticuloLineaFormComponent } from "./form/articulo-linea-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloLineaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloLineaListComponent,
    ArticuloLineaFormComponent
  ]
})

export class ArticuloLineaModule { }