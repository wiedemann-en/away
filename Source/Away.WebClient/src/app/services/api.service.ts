import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from './base.service';
import { BroadcastService } from './broadcast.service';
import { Base } from '../models/base/base';
import { AuthHelpers } from '../auth/auth-helpers';
import { CommonConfig } from '../common/common-config';

@Injectable()
export class ApiService<TModel extends Base> extends BaseService {
  private urlApi: string;

  constructor(http: HttpClient, 
    broadcastService: BroadcastService,
    authHelpers: AuthHelpers,
    config: CommonConfig,
    apiName: string) { 
      super(http, broadcastService, authHelpers, config); 
      this.urlApi = this.config.setting['PathApi'] + apiName;
  }

  public getActives(): Observable<TModel[]> {
    return this.http      
      .get<any>(this.urlApi, super.header())
      //.pipe(catchError(super.handleError))      
      .pipe(map(val => super.transformData<TModel[]>(val)));
  }

  public getAll(): Observable<TModel[]> {
    return this.http
      .get<any>(this.urlApi + '/all', super.header())
      .pipe(map(val => super.transformData<TModel[]>(val)));
  }

  public getById(id: number): Observable<TModel> {
    return this.http
      .get<any>(this.urlApi + '/' + id, super.header())
      .pipe(map(val => super.transformData<TModel>(val)));
  }

  public create(obj: TModel): Observable<TModel> {
    return this.http
      .post<any>(this.urlApi, obj, super.header())
      .pipe(map(val => super.transformData<TModel>(val)));
  }

  public update(obj: TModel): Observable<TModel> {
    return this.http
      .put<any>(this.urlApi + '/' + obj.id, obj, super.header())
      .pipe(map(val => super.transformData<TModel>(val)));
  }

  public delete(id: number): Observable<boolean> {
    return this.http
      .delete<any>(this.urlApi + '/' + id, super.header())
      .pipe(map(val => super.transformData<boolean>(val)));
  }

  public disable(id: number): Observable<boolean> {
    return this.http
      .patch<any>(this.urlApi + '/disable/' + id, super.header())
      .pipe(map(val => super.transformData<boolean>(val)));
  }

  public enable(id: number): Observable<boolean> {
    return this.http
      .patch<any>(this.urlApi + '/enable/' + id, super.header())
      .pipe(map(val => super.transformData<boolean>(val)));
  }
}