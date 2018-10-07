import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import { ActivatedRoute } from '@angular/router';
import {PullsService} from '../../services/pulls.service';
import { ReposService } from '../../services/repos.service';

@Component({
  selector: 'app-pullrepolist',
  templateUrl: './pullrepolist.component.html',
  styleUrls: ['./pullrepolist.component.css','../../../../node_modules/bootstrap/dist/css/bootstrap.min.css']
})
export class PullrepolistComponent implements OnInit {

  projectlist
  constructor(private repo: ReposService) { }

  ngOnInit() {
    this.repo.getRepos("dhruv5026").subscribe(data => this.projectlist = data);
  }

}
