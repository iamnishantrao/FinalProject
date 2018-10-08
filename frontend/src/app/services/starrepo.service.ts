import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RepoModel } from '../models/repo.model';
import { StarrepoModel } from '../models/starrepo.model';

@Injectable({
  providedIn: 'root'
})
export class StarrepoService {
  repo: StarrepoModel;

  // starredRepositories = {
  //   clone_url: "https://github.com/kibub2/final-kibeob.git",
  //   created_at: "2016-08-25T08:14:32Z",
  //   description: "finalproject",
  //   html_url: "https://github.com/kibub2/final-kibeob",
  //   id: 66538794,
  //   name: "final-kibeob",
  //   user_html_url: "https://github.com/kibub2",
  //   user_login: "kibub2",
  //   pushed_at: "2016-08-30T17:54:36Z",
  //   updated_at: "2016-08-25T08:15:00Z",
  //   User_Id: 1
  // }

  constructor(private http: HttpClient) { }

  starRepo(repoModel: RepoModel, id: number) {
    this.repo = {
      repo_id: repoModel.repo_id,
      name: repoModel.name,
      html_url: repoModel.html_url,
      description: repoModel.description,
      created_at: repoModel.created_at,
      updated_at: repoModel.updated_at,
      pushed_at: repoModel.pushed_at,
      clone_url: repoModel.clone_url,
      user_login: repoModel.user_login,
      user_html_url: repoModel.user_html_url,
      userId: id
    }
   
    var r = this.http.post("https://localhost:44357/api/starredrepos", this.repo);
    return r;
  }
}
