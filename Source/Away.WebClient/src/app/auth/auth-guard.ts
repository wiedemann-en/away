import { CanActivate, Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthHelpers } from './auth-helpers';

@Injectable()
export class AuthGuard implements CanActivate {
  constructor(private authHelpers: AuthHelpers, private router: Router) {
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | boolean {
return true;
    
    if (!this.authHelpers.isAuthenticated()) {      
      this.router.navigate(['login'], { queryParams: { returnUrl: state.url }});
      return false;
    }
    if (!this.authHelpers.hasPermission(route.data.appState)) {
      this.router.navigate(['unauthorized']); 
      return false;
    }
    return true;
  }
}