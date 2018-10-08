import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PullsModel } from '../models/pulls.model';

@Injectable({
  providedIn: 'root'
})
export class PullsService {

  constructor(private http: HttpClient) { }

  user_name = localStorage.getItem('user_name');
  getPulls(name: string): Observable<PullsModel[]> {

    var keyword = this.user_name + " " + name;

    var profileUrl = "https://localhost:44357/api/pull/"+keyword ;
    var data = this.http.get<PullsModel[]>(profileUrl);

    return data;
  }
}
