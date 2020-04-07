import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloSubTipoRoutingModule } from './articulo-subtipo-routing.module';
import { ArticuloSubTipoListComponent } from "./list/articulo-subtipo-list.component";
import { ArticuloSubTipoFormComponent } from "./form/articulo-subtipo-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloSubTipoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloSubTipoListComponent,
    ArticuloSubTipoFormComponent
  ]
})

export class ArticuloSubTipoModule { }