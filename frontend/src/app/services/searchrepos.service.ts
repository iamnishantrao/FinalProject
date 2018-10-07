import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RepoModel } from '../models/repo.model';

@Injectable({
  providedIn: 'root'
})
export class SearchreposService {

  constructor(private http: HttpClient) { }

  searchRepos(keyword: string): Observable<RepoModel[]> {
    
    var searchUrl = "https://localhost:44357/api/searchrepos/" + keyword;
    var data = this.http.get<RepoModel[]>(searchUrl);
    
    return data;
  }
}
