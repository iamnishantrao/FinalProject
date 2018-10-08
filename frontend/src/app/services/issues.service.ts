import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IssueModel } from '../models/issue.model';


@Injectable({
  providedIn: 'root'
})
export class IssuesService{

  constructor(private http : HttpClient) { }
  user_name = localStorage.getItem('user_name');

  getIssues(name: string): Observable<IssueModel[]>
  {
    var keyword = this.user_name + " " + name;

    var profileUrl = "https://localhost:44357/api/issue/"+keyword ;
    var data = this.http.get<IssueModel[]>(profileUrl);

    return data;
  }

}
