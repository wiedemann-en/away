import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { Login } from '../../models/login';
import { LoginService } from '../../services/login.service';
import { AuthHelpers } from '../../auth/auth-helpers';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: [ './login.component.scss' ]
})

export class LoginComponent implements OnInit {
  public formGroup: FormGroup;
  public submitted: boolean = false;
  public message: string;

  constructor(private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router, 
    private loginService: LoginService, 
    private authHelpers: AuthHelpers) { 
  }

  ngOnInit() {
    this.initializeForm();
    //this.authenticationHelpers.logout(); //TODO: Revisar, se pierde la sesión sino
  }

  private initializeForm() {
    this.formGroup = this.formBuilder.group({
      user: ['', Validators.required],
      pass: ['', Validators.required]
    });
  }

  get formData() { 
    return this.formGroup.controls; 
  }

  login(): void {
    this.submitted = true;
    if (this.formGroup.invalid) {
      return;
    }
    let authValues: Login = this.formGroup.value;
    this.loginService.auth(authValues).subscribe(response => {
      if (response != null) {
        let returnUrl: string = this.route.snapshot.queryParams['returnUrl'] || '/'; 
        this.authHelpers.setUserAuth(response);
        this.router.navigate([returnUrl]);
      }
    });
  }
}