import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloMarcaRoutingModule } from './articulo-marca-routing.module';
import { ArticuloMarcaListComponent } from "./list/articulo-marca-list.component";
import { ArticuloMarcaFormComponent } from "./form/articulo-marca-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloMarcaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloMarcaListComponent,
    ArticuloMarcaFormComponent
  ]
})

export class ArticuloMarcaModule { }