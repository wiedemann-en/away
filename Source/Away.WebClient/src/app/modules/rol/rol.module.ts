import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { RolRoutingModule } from './rol-routing.module';
import { RolListComponent } from "./list/rol-list.component";
import { RolFormComponent } from "./form/rol-form.component";

@NgModule({
  imports: [
    CommonModule,
    RolRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    RolListComponent,
    RolFormComponent
  ]
})

export class RolModule { }