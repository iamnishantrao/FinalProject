import { Component, OnInit } from '@angular/core';
import {ActivatedRoute } from '@angular/router'
import {IssuesService } from '../../services/issues.service'

@Component({
  selector: 'app-issuelist',
  templateUrl: './issuelist.component.html',
  styleUrls: ['./issuelist.component.css']
})
export class IssuelistComponent implements OnInit {
issuelist;
name:string;
  constructor(private route:ActivatedRoute,private issu:IssuesService) { }

  ngOnInit() {
    this.issu.getIssues().subscribe(data => this.issuelist = data);
       this.name=this.route.snapshot.paramMap.get("name");

  }

}
