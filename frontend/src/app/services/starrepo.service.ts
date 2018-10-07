import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RepoModel } from '../models/repo.model';
import { StarrepoModel } from '../models/starrepo.model';

@Injectable({
  providedIn: 'root'
})
export class StarrepoService {
  repo: StarrepoModel;
  
  constructor(private http: HttpClient) { }

  starRepo(repoModel: RepoModel, id: number) {
    this.repo = {
      starredRepositories: repoModel,
      userId: id
    }
    console.log(this.repo);
    return this.http.post("https://localhost:44357/api/starredrepos", this.repo);
  }
}
