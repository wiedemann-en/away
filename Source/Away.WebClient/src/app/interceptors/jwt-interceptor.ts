import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

import { AuthHelpers } from '../auth/auth-helpers';
import { CommonHelpers } from '../common/common-helpers';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
  constructor(private authHelpers: AuthHelpers, private commonHelpers: CommonHelpers) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    // add authorization header with jwt token if available
    let token = this.authHelpers.getToken();
    if (!this.commonHelpers.isEmpty(token)) {
      request = request.clone({
        setHeaders: { 
          Authorization: `Bearer ${token}`
        }
      });
    }
    return next.handle(request);
  }
}