import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { Login } from '../models/login';
import { UsuarioAutenticado } from '../models/usuario-autenticado';
import { CommonConfig } from '../common/common-config';
import { BaseService } from './base.service';
import { BroadcastService } from './broadcast.service';
import { AuthHelpers } from '../auth/auth-helpers';

@Injectable()
export class LoginService extends BaseService {

  private urlApi: string;

  constructor(http: HttpClient, 
    broadcastService: BroadcastService,
    authHelpers: AuthHelpers,
    config: CommonConfig) {
      super(http, broadcastService, authHelpers, config); 
      this.urlApi = this.config.setting['PathApi'] + 'login';
  }

  public auth(data: Login): Observable<UsuarioAutenticado> {
    let body = JSON.stringify(data);
    return this.http
      .post<any>(this.urlApi + '/auth', data, super.header())
      .pipe(map(val => super.transformData<UsuarioAutenticado>(val)));
  }  
}