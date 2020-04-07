import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloCategoriaRoutingModule } from './articulo-categoria-routing.module';
import { ArticuloCategoriaListComponent } from "./list/articulo-categoria-list.component";
import { ArticuloCategoriaFormComponent } from "./form/articulo-categoria-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloCategoriaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    ////AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloCategoriaListComponent,
    ArticuloCategoriaFormComponent
  ]
})

export class ArticuloCategoriaModule { }