import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloUnidadMedidaRoutingModule } from './articulo-unidad-medida-routing.module';
import { ArticuloUnidadMedidaListComponent } from "./list/articulo-unidad-medida-list.component";
import { ArticuloUnidadMedidaFormComponent } from "./form/articulo-unidad-medida-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloUnidadMedidaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloUnidadMedidaListComponent,
    ArticuloUnidadMedidaFormComponent
  ]
})

export class ArticuloUnidadMedidaModule { }