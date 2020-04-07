import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthHelpers } from '../../auth/auth-helpers';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})

export class HeaderComponent { 
  constructor(private router: Router, 
    private authHelpers: AuthHelpers) {
  }

  logout(): void {
    this.authHelpers.logout();
    this.router.navigate(['login']);
  }  
}