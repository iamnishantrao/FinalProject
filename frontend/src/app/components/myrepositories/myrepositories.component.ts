import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import { RepoModel } from '../../models/repo.model';
import { ReposService } from '../../services/repos.service';

@Component({
  selector: 'app-myrepositories',
  templateUrl: './myrepositories.component.html',
  styleUrls: [
    './myrepositories.component.css',
    '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
  ]
})
export class MyrepositoriesComponent implements OnInit {

  ListOfRepos: RepoModel[] ; 
  constructor(private reposervice: ReposService) { }

  ngOnInit() {
    this.reposervice.getRepos("bla").subscribe(data=> {
      this.ListOfRepos = data;
    })
  }
  newPage(url: string)
  {
      window.open(url);
  }

}
