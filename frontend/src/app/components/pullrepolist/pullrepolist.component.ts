import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';

@Component({
  selector: 'app-pullrepolist',
  templateUrl: './pullrepolist.component.html',
  styleUrls: ['./pullrepolist.component.css','../../../../node_modules/bootstrap/dist/css/bootstrap.min.css']
})
export class PullrepolistComponent implements OnInit {

  pullrepolist;
  constructor() { }

  ngOnInit() {
    this.pullrepolist = [
      {
        name: "Pull list 1",
        description: "Hello This is Pull list 1"
      },
      {
        name: "Pull list 2",
        description: "Hello This is Pull list 2"
      },
      {
        name: "Pull list 3",
        description: "Hello This is Pull list 3"
      },
      {
        name: "Pull list 4",
        description: "Hello This is Pull list 4"
      },
      {
        name: "Pull list 5",
        description: "Hello This is Pull list 5"
      },
      
    ];
  }

}
