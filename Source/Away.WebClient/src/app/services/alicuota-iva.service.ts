import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ApiService } from './api.service';
import { BroadcastService } from './broadcast.service';
import { AuthHelpers } from '../auth/auth-helpers';
import { CommonConfig } from '../common/common-config';
import { AlicuotaIva } from '../models/alicuota-iva';

@Injectable()
export class AlicuotaIvaService extends ApiService<AlicuotaIva> {
  constructor(http: HttpClient, 
    broadcastService: BroadcastService,
    authHelpers: AuthHelpers,
    config: CommonConfig) { 
      super(http, broadcastService, authHelpers, config, 'alicuotasiva'); 
  }
}