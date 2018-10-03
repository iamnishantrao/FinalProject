import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IssueModel } from '../models/issue.model';


@Injectable({
  providedIn: 'root'
})
export class IssuesService{

  constructor(private http : HttpClient) { }

  getIssues(): Observable<IssueModel[]>
  {
    var profileUrl = "https://localhost:44357/api/issue";
    var data = this.http.get<IssueModel[]>(profileUrl);

    return data;
  }
}
