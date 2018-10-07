import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-pull',
  templateUrl: './pull.component.html',
  styleUrls: ['./pull.component.css']
})
export class PullComponent implements OnInit {
  id;
  number;
  title;
  html_url;
  user_login;
  state;
  assigne;
  created_at;
  cloased_at;
  body;


  constructor(private route: ActivatedRoute, ) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.number = this.route.snapshot.paramMap.get('number');
    this.html_url = this.route.snapshot.paramMap.get('html_url');

    // this.user_login = this.route.snapshot.paramMap.get('user_login');

    if (this.route.snapshot.paramMap.get('user_login') == "undefined") {
      this.user_login = "Value not availabe";
    }
    else {
      this.user_login = this.route.snapshot.paramMap.get('user login');
    }

    // this.state = this.route.snapshot.paramMap.get('state');

    if (this.route.snapshot.paramMap.get('state') == "undefined") {
      this.state = "Value not availabe";
    }
    else {
      this.state = this.route.snapshot.paramMap.get('state');
    }


    // this.assigne = this.route.snapshot.paramMap.get('assigne');
    if (this.route.snapshot.paramMap.get('assigne') == "undefined") {
      this.assigne = "Value not availabe";
    }
    else {
      this.assigne = this.route.snapshot.paramMap.get('assigne');
    }
    console.log(this.route.snapshot.paramMap.get('cloased_at'));



    this.created_at = this.route.snapshot.paramMap.get('created_at');

    // this.cloased_at = this.route.snapshot.paramMap.get('cloased_at');
    if (this.route.snapshot.paramMap.get('cloased_at') == "undefined") {
      this.cloased_at = "Value not availabe";
    } else {
      this.cloased_at = this.route.snapshot.paramMap.get('cloased_at');
    }

    this.title = this.route.snapshot.paramMap.get("title")
    this.body = this.route.snapshot.paramMap.get('body');


  }
}
