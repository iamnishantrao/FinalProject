import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { SearchprofileService } from '../../services/searchprofile.service';
import { SearchreposService } from '../../services/searchrepos.service';
import { StarrepoService } from '../../services/starrepo.service';
import { RepoModel } from '../../models/repo.model';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  repo: RepoModel;
  searchList;
  flag;
  keyword: string;

  constructor(private route: ActivatedRoute, private searchprofileService: SearchprofileService, private searchreposService: SearchreposService, private starrepoService: StarrepoService) { }

  ngOnInit() {
    this.flag = this.route.snapshot.paramMap.get("flag");
    this.keyword = this.route.snapshot.paramMap.get("keyword"); 
    
    if (this.flag == "0") {
      this.searchprofileService.searchProfiles(this.keyword).subscribe(data => this.searchList = data);
    }  
    if (this.flag == "1") {
      this.searchreposService.searchRepos(this.keyword).subscribe(data => this.searchList = data);
    }
  }

  starThisRepo(ndx: number) {
    console.log("Inside starthisrepo", ndx);
    this.repo = this.searchList[ndx];
    //console.log(this.repo);
    this.starrepoService.starRepo(this.repo, 1).subscribe(data => {console.log(data)});
  }
}
