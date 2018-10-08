import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginService } from '../../services/login.service';
import { LoginModel } from '../../models/login.model';
import { tokenGetter } from '../../app.module';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  @Input() flagLogin: boolean;
  @Output() flagValueChanged = new EventEmitter<boolean>();
  constructor(private loginService: LoginService) { }
  username: string;
  password: string;
  loginModel: LoginModel;
  loginCallback: any;
  auth_token: string;
  signupFlag: boolean;

  ngOnInit() {
    this.signupFlag = true;
  }
  login(): void {
    this.loginModel =
      {
        username: this.username,
        password: this.password
      };
    this.loginService.doLogin(this.loginModel).subscribe(data => {
      if (data == "true") {
        this.flagLogin = !this.flagLogin;
        this.flagValueChanged.emit(this.flagLogin);
      }

    }, error => { alert("Invalid Credentials") });
  }
  signup()
  {
    this.signupFlag = !this.signupFlag;
  }
  signupflagValueChanged(e)
  {
    this.signupFlag = e;
  }
  

}
