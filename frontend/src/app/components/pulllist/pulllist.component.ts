import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-pulllist',
  templateUrl: './pulllist.component.html',
  styleUrls: ['./pulllist.component.css']
})
export class PulllistComponent implements OnInit {
  name : string;

  constructor(private route:ActivatedRoute,private router:Router) { 
    
  }

  ngOnInit() {
  this.name = this.route.snapshot.paramMap.get("name");
  console.log(name);
    
  }
}
