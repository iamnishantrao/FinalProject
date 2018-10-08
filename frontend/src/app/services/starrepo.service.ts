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
