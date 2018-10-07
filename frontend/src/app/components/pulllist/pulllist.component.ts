import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PullsService } from '../../services/pulls.service';

@Component({
  selector: 'app-pulllist',
  templateUrl: './pulllist.component.html',
  styleUrls: ['./pulllist.component.css']
})
export class PulllistComponent implements OnInit {
  pulllist;
  name:string;
  constructor(private route:ActivatedRoute,private pull:PullsService) { }

  ngOnInit() {
    this.pull.getPulls().subscribe(data => this.pulllist = data);
       this.name=this.route.snapshot.paramMap.get("name");
  }
}