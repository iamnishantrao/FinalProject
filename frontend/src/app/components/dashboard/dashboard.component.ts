import { Component, OnInit } from '@angular/core';
import {tokenGetter} from '../../app.module';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
import '../../../../node_modules/font-awesome/css/font-awesome.min.css' 
import {MatCardModule } from '@angular/material/card';
import { Router } from '@angular/router';
import {Observable} from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [
    './dashboard.component.css',
    '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css',
    '../../../../node_modules/font-awesome/css/font-awesome.min.css'
  ]
})
export class DashboardComponent implements OnInit {
  auth_token: string;
  constructor(private router: Router) { }
 
  ngOnInit() {
    //  this.auth_token = tokenGetter();
  }
  openProfile()
  {
    //this.router.navigate(['/profile']);
  }
}
