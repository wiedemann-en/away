import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

import { BroadcastService } from './broadcast.service';
import { AuthHelpers } from '../auth/auth-helpers';
import { CommonConfig } from '../common/common-config';

@Injectable()
export class BaseService {

  protected http: HttpClient;
  protected broadcastService: BroadcastService;
  protected authHelpers: AuthHelpers;
  protected config: CommonConfig;

  constructor(http: HttpClient, broadcastService: BroadcastService, authHelpers: AuthHelpers, config: CommonConfig) {
    this.http = http;
    this.broadcastService = broadcastService;
    this.authHelpers = authHelpers;
    this.config = config;
  }

  public extractData(res: Response) {
    let body = res.json();
    return body || {};
  }

  protected header() {
    let header = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
    if (this.authHelpers.isAuthenticated()) {
      header = header.append('Authorization', 'Bearer ' + this.authHelpers.getToken()); 
    }
    return { headers: header };
  }

  protected transformData<TResult>(result: any): TResult {
    if (result.success)
      return result.data as TResult;
    this.broadcastService.showErrors(result.errors);
    return null;
  }
}