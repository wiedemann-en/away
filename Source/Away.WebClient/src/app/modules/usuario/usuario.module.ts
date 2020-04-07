import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { UsuarioRoutingModule } from './usuario-routing.module';
import { UsuarioListComponent } from './list/usuario-list.component';
import { UsuarioFormComponent } from './form/usuario-form.component';

@NgModule({
  imports: [
    CommonModule,
    UsuarioRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    UsuarioListComponent,
    UsuarioFormComponent
  ]
})

export class UsuarioModule { }