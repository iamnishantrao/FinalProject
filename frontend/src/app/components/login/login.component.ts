import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  @Input() flagLogin: boolean;
  @Output() flagValueChanged = new EventEmitter<boolean>();
  constructor() { }
  username:string;
  password:string;

  ngOnInit() {
  }
  login():void{
    if (this.username=='admin'&& this.password=='admin'){
      this.flagLogin = !this.flagLogin;
      this.flagValueChanged.emit(this.flagLogin);
    }else{
      alert ("Invalid Credential");
    }
  }
  about():void{
    alert("About Information")
  }
  contact():void{
    alert("Contact Information")
  }

}
