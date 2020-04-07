import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { UsuarioRoutingModule } from './usuario-routing.module';
import { UsuarioListComponent } from './list/usuario-list.component';
//import { CommonDialog } from '../../common/common-dialog';
//import { UsuarioService } from '../../services/usuario.service';


@NgModule({
  declarations: [
    UsuarioListComponent,
    
  ],
  imports: [
    CommonModule,
    UsuarioRoutingModule,
    FormsModule,
    DataTablesModule,
    //AngularFontAwesomeModule,    
    DirectivesModule
  ],
  providers: [
    //CommonDialog,
    //UsuarioService,
    
  ]
})
export class UsuarioModule { }
