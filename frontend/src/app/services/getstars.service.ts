import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StarrepoModel } from '../models/starrepo.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetstarService {
  repo: StarrepoModel;
  constructor(private http: HttpClient) { }

  getstars(): Observable<StarrepoModel[]> {
    var r = this.http.get<StarrepoModel[]>("https://localhost:44357/api/starredrepos");
    return r;

  }
}

