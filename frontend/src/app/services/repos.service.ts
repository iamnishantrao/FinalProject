import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {RepoModel} from '../models/repo.model'

@Injectable({
  providedIn: 'root'
})
export class ReposService {
  

  constructor(private http: HttpClient) { }
  user_name = localStorage.getItem('user_name');

  getRepos(name: string): Observable<RepoModel[]>
  {
    var profileUrl = "https://localhost:44357/api/repo/"+this.user_name;
    var data = this.http.get<RepoModel[]>(profileUrl);
    return data;
  }
}
