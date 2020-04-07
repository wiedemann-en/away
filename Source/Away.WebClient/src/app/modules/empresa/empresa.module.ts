import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { EmpresaRoutingModule } from './empresa-routing.module';
import { EmpresaListComponent } from "./list/empresa-list.component";
import { EmpresaFormComponent } from "./form/empresa-form.component";

@NgModule({
  imports: [
    CommonModule,
    EmpresaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    EmpresaListComponent,
    EmpresaFormComponent
  ]
})

export class EmpresaModule { }