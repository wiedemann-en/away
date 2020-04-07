import { Injectable } from '@angular/core';

@Injectable()
export class CommonHelpers  {
  constructor() {
  }

  public isEmpty(value: string): boolean {
    return ((value === undefined) || 
      (value === null) ||
      (value === 'undefined') ||
      (value === 'null') ||
      (value === ''));
  }

  public isString(value: any): boolean {
    return ((value !== undefined) &&
      (value !== null) &&
      (typeof value === 'string'));
  }

  public toNumber(value: any): number {
    return parseInt(value);
  }

  public toUpper(value: any): string {
    if (this.isString(value))
      return value.toUpperCase();
    return '';
  }

  public toLower(value: any): string {
    if (this.isString(value))
      return value.toLowerCase();
    return '';
  }
}