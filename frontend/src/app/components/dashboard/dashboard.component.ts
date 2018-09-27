import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
import '../../../../node_modules/font-awesome/css/font-awesome.min.css' 
import {MatCardModule } from '@angular/material/card';
import { Router } from '../../../../node_modules/@angular/router';

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

  constructor(private router: Router) { }

  ngOnInit() {
  }
  openProfile()
  {
    //this.router.navigate(['/profile']);
  }
}