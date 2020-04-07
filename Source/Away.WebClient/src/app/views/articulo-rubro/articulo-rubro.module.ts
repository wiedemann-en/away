import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ArticuloRubroRoutingModule } from './articulo-rubro-routing.module';
import { ArticuloRubroListComponent } from "./list/articulo-rubro-list.component";
import { ArticuloRubroFormComponent } from "./form/articulo-rubro-form.component";

@NgModule({
  imports: [
    CommonModule,
    ArticuloRubroRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    ////AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ArticuloRubroListComponent,
    ArticuloRubroFormComponent
  ]
})

export class ArticuloRubroModule { }