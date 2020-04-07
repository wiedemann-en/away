/// TODO: Por documentación revisar:
/// https://juristr.com/blog/2018/02/angular-permission-directive/
///

import { Directive, Input, TemplateRef, ViewContainerRef, ElementRef, OnInit } from '@angular/core';

import { AuthHelpers } from '../auth/auth-helpers';
import { CommonHelpers } from '../common/common-helpers';

@Directive({
  selector: '[permission]'
})

export class PermissionDirective implements OnInit {
  private permissions: string[] = [];
  private logicalOperator: string = 'AND';
  private isHidden: boolean = true;

  constructor(
    private element: ElementRef,
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef,
    private authHelpers: AuthHelpers,
    private commonHelpers: CommonHelpers) { }

  ngOnInit() {
    this.updateView();
  }

  @Input()
  set permission(value: string[]) {
    this.permissions = value;
    this.updateView();
  }

  @Input()
  set permissionOperator(permOperator: string) {
    this.logicalOperator = this.commonHelpers.toUpper(permOperator);
    this.updateView();
  }

  private updateView(): void {
    if (this.hasPermission()) {
      if (this.isHidden) {
        this.viewContainer.createEmbeddedView(this.templateRef);
        this.isHidden = false;
      }
    } else {
      this.isHidden = true;
      this.viewContainer.clear();
    }
  }

  private hasPermission(): boolean {
    let hasPermission: boolean = false;
    for (const checkPermission of this.permissions) {
      let permissionFound: boolean = false;
      if (checkPermission.split(':').length == 2) {
        const appState: string = checkPermission.split(':')[0];
        const permiso: string = checkPermission.split(':')[1];
        permissionFound = this.authHelpers.hasPermission(appState, permiso);
      } else {
        permissionFound = this.authHelpers.hasPermission(checkPermission);
      }
      if (permissionFound) {
        hasPermission = true;
        if (this.logicalOperator === 'OR') {
          break;
        }
      }
      else {
        hasPermission = false;
        if (this.logicalOperator === 'AND') {
          break;
        }
      }
    }
    return hasPermission;
  }
}
