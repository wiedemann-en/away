import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UnauthorizedComponent } from './unauthorized.component';
import { UnauthorizedRoutingModule } from './unauthorized-routing.module';

@NgModule({
  imports: [
    CommonModule,
    UnauthorizedRoutingModule
  ],
  exports: [
    UnauthorizedComponent
  ],
  declarations: [
    UnauthorizedComponent
  ]
})

export class UnauthorizedModule { }
