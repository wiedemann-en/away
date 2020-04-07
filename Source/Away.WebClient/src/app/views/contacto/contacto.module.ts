import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { ContactoRoutingModule } from './contacto-routing.module';
import { ContactoListComponent } from "./list/contacto-list.component";
import { ContactoFormComponent } from "./form/contacto-form.component";

@NgModule({
  imports: [
    CommonModule,
    ContactoRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    ContactoListComponent,
    ContactoFormComponent
  ]
})

export class ContactoModule { }