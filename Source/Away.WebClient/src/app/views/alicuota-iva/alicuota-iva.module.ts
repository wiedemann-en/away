import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { AngularFontAwesomeModule } from 'angular-font-awesome';

/* Directives */
import { DirectivesModule } from '../../directives/directives.module';

import { AlicuotaIvaRoutingModule } from './alicuota-iva-routing.module';
import { AlicuotaIvaListComponent } from "./list/alicuota-iva-list.component";
import { AlicuotaIvaFormComponent } from "./form/alicuota-iva-form.component";

@NgModule({
  imports: [
    CommonModule,
    AlicuotaIvaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    DataTablesModule,
    ////AngularFontAwesomeModule,
    DirectivesModule
  ],
  declarations: [
    AlicuotaIvaListComponent,
    AlicuotaIvaFormComponent
  ]
})

export class AlicuotaIvaModule { }