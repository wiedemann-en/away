import { Component } from '@angular/core';
import { navItems } from '../../_nav';

@Component({
  templateUrl: '404.component.html'
})
export class P404Component {
  public sidebarMinimized = false;
  public navItems = navItems;

  toggleMinimize(e) {
    this.sidebarMinimized = e;
  }

  constructor() { }

}
