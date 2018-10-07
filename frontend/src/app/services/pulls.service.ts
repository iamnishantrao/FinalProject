import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PullsModel } from '../models/pulls.model';

@Injectable({
  providedIn: 'root'
})
export class PullsService {

  constructor(private http : HttpClient) { }

  getPulls(): Observable<PullsModel[]>
  {
    var profileUrl = "https://localhost:44357/api/pull";
    var data = this.http.get<PullsModel[]>(profileUrl);

    return data;
  }
}
