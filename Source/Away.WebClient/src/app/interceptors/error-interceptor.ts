import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { EMPTY, of } from "rxjs";

import { BroadcastService } from '../services/broadcast.service';
import { AuthHelpers } from '../auth/auth-helpers';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router: Router,
    private broadcastService: BroadcastService,
    private authHelpers: AuthHelpers) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request)
      .pipe(catchError(err => {
        switch (err.status) {
          case 401:
            this.authHelpers.logout();
            this.router.navigate(['login']); 
            break;
          case 403:
            this.router.navigate(['unauthorized']); 
            break;
          default:
            if (err.error.hasOwnProperty('errors') && err.error.hasOwnProperty('data')) {
              this.broadcastService.showErrors(err.error.errors);
            }            
            else {
              let msgError = err.error.message || `${err.status} - ${err.statusText || ''}`;
              this.broadcastService.showError(msgError);
            }
            break;
        }
        return EMPTY;
      })
    )
  }
}