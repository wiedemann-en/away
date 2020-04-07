import { Component, AfterViewInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { startWith, delay } from 'rxjs/operators';
import { AuthHelpers } from '../auth/auth-helpers';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements AfterViewInit, OnDestroy {
  subscription: Subscription;
  authentication: boolean;

  constructor(private router: Router, 
    private authHelpers: AuthHelpers) {
  }

  ngAfterViewInit() {
    this.subscription = this.authHelpers.isAuthenticationChanged()
      .pipe(startWith(this.authHelpers.isAuthenticated()), delay(0))
      .subscribe((value) =>
        this.authentication = value
      );
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}
