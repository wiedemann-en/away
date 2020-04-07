import { Injectable } from '@angular/core';

@Injectable()
export class CommonConfig {
  private _config: { [key: string]: string };

  constructor() {
    this._config = { 
      PathApi: 'http://localhost:1306/'
    };
  }

  get setting(): { [key: string]: string } {
    return this._config;
  }

  get(key: string) {
    return this._config[key];
  }
}