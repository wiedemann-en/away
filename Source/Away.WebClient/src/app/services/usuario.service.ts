import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { BroadcastService } from './broadcast.service';
import { AuthHelpers } from '../auth/auth-helpers';
import { CommonConfig } from '../common/common-config';

import { ApiService } from './api.service';
import { Usuario } from '../models/usuario';

@Injectable()
export class UsuarioService extends ApiService<Usuario> {
  constructor(http: HttpClient, 
    broadcastService: BroadcastService,
    authHelpers: AuthHelpers,
    config: CommonConfig) { 
      super(http, broadcastService, authHelpers, config, 'usuarios'); 
  }

}

// export class UsuarioService extends ApiService<Usuario> {
  
//   constructor(
//       http: HttpClient,
//       broadcastService: BroadcastService,
//       authHelpers: AuthHelpers,
//       config: CommonConfig      
//       ){
//         super(http, broadcastService, authHelpers, config, 'usuarios'); 
//   }
  

// }

