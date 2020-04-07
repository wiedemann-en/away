import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-articulo-form',
  templateUrl: './articulo-form.component.html',
  styleUrls: ['./articulo-form.component.scss']
})

export class ArticuloFormComponent implements OnInit {
  
  isCollapsed: boolean = false;
  iconCollapse: string = 'icon-arrow-up';

  constructor() { 
  }

  ngOnInit() {
  }


  collapsed(event: any): void {
    // console.log(event);
  }

  expanded(event: any): void {
    // console.log(event);
  }

  toggleCollapse(): void {
    this.isCollapsed = !this.isCollapsed;
    this.iconCollapse = this.isCollapsed ? 'icon-arrow-down' : 'icon-arrow-up';
  }

}
