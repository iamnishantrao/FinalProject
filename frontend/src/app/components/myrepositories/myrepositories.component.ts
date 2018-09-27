import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';

@Component({
  selector: 'app-myrepositories',
  templateUrl: './myrepositories.component.html',
  styleUrls: [
    './myrepositories.component.css',
    '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
  ]
})
export class MyrepositoriesComponent implements OnInit {

  ListOfRepos ; 
  constructor() { }

  ngOnInit() {
    this.ListOfRepos = [
      {
        name : "Project1",
        description : "Hello This is Project 1"
      },
      {
        name : "Project1",
        description : "Hello This is Project 1"
      },
      {
        name : "Project1",
        description : "Hello This is Project 1"
      },
      {
        name : "Project1",
        description : "Hello This is Project 1"
      },
      {
        name : "Project2",
        description : "Hello This is Project 2"
      },
      {
        name : "Project3",
        description : "Hello This is Project 3"
      },
      {
        name : "Project4",
        description : "Hello This is Project 4"
      },
    ];
  }

}
