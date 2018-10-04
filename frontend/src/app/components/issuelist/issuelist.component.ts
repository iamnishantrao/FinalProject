import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-issuelist',
  templateUrl: './issuelist.component.html',
  styleUrls: ['./issuelist.component.css']
})
export class IssuelistComponent implements OnInit {
issuelist;
  constructor() { }

  ngOnInit() {
this.issuelist=[
{
  name:"Issue 1"
},
{
  name:"Issue 2"
},
{
  name:"Issue 3"
},
{
  name:"Issue 4"
},
{
  name:"Issue 5"
},
{
  name:"Issue 6"
},

];


  }

}
