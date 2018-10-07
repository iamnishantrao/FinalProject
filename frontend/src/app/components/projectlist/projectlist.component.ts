import { Component, OnInit } from '@angular/core';
import {ReposService } from '../../services/repos.service'

@Component({
  selector: 'app-projectlist',
  templateUrl: './projectlist.component.html',
  styleUrls: ['./projectlist.component.css']
})
export class ProjectlistComponent implements OnInit {
projectlist
  constructor(private repo: ReposService) { }

  ngOnInit() {
    this.repo.getRepos("dhruv5026").subscribe(data => this.projectlist = data);
  }

}
