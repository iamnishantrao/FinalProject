import { Component, OnInit } from '@angular/core';
import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import { GetstarService } from '../../services/getstars.service';
import { StarrepoModel } from '../../models/starrepo.model';

@Component({
  selector: 'app-starredrepos',
  templateUrl: './starredrepos.component.html',
  styleUrls: ['./starredrepos.component.css',
  '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css'
]
})

export class StarredreposComponent implements OnInit {

  ListOfRepos: StarrepoModel[] ; 
  constructor(private reposervice: GetstarService) { }

  ngOnInit() {
    this.reposervice.getstars().subscribe(data=> {
      this.ListOfRepos = data;
    })
  }
  newPage(url: string)
  {
      window.open(url);
  }

}
