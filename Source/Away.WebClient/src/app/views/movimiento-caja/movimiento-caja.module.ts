import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { MovimientoCajaRoutingModule } from './movimiento-caja-routing.module';
import { MovimientoCajaListComponent } from "./list/movimiento-caja-list.component";
import { MovimientoCajaFormComponent } from "./form/movimiento-caja-form.component";

@NgModule({
  imports: [
    CommonModule,
    MovimientoCajaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    MovimientoCajaListComponent,
    MovimientoCajaFormComponent
  ]
})

export class MovimientoCajaModule { }