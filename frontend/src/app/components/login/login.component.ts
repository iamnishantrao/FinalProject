import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }
  username:string;
  password:string;

  ngOnInit() {
  }
  login():void{
    if (this.username=='admin'&& this.password=='admin'){
      alert("Welcome Admin")
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
