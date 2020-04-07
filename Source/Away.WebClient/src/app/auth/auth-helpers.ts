import { Injectable } from '@angular/core';
import { Subject, Observable } from 'rxjs';

import { CommonHelpers } from '../common/common-helpers';
import { RecursoSistema } from '../models/recurso-sistema';
import { UsuarioAutenticado } from '../models/usuario-autenticado';

@Injectable()
export class AuthHelpers  {
  private authChanged = new Subject<boolean>();

  constructor(private commonHelpers: CommonHelpers) {
  }

  public isAuthenticated(): boolean {
    return (!this.commonHelpers.isEmpty(window.localStorage['user-auth']));
  }

  public isAuthenticationChanged(): Observable<boolean> {
    return this.authChanged.asObservable();
  }

  public getUser(): UsuarioAutenticado {
    if (this.commonHelpers.isEmpty(window.localStorage['user-auth']))
      return null;
    let user: UsuarioAutenticado = JSON.parse(window.localStorage['user-auth']) as UsuarioAutenticado;
    return user;
  }

  public getToken(): string {
    let user: UsuarioAutenticado = this.getUser();
    return user ? user.token : '';
  }

  public setUserAuth(data: UsuarioAutenticado): void {
    this.setStorageUser(JSON.stringify(data));
  }

  public hasPermission(appState: string, permiso?: string): boolean {
    let hasPermission: boolean = false;
    let user: UsuarioAutenticado = this.getUser();
    if ((user) && (user.rol)) {
      let resourceFound: RecursoSistema;
      appState = this.commonHelpers.toUpper(appState);
      if (permiso) {
        permiso = this.commonHelpers.toUpper(permiso);
        resourceFound = user.rol.recursos.find(x => (this.commonHelpers.toUpper(x.appState) === appState) && (this.commonHelpers.toUpper(x.permiso) === permiso));
      }
      else {
        resourceFound = user.rol.recursos.find(x => this.commonHelpers.toUpper(x.appState) === appState);
      }
      if (resourceFound) {
        hasPermission = true;
      }
  }
    return hasPermission;
  }

  public logout(): void {
    this.setStorageUser(undefined);
  }

  private setStorageUser(value: string): void {
    window.localStorage['user-auth'] = value;
    let isAuthenticated: boolean = this.isAuthenticated();
    this.authChanged.next(isAuthenticated);
  }
}