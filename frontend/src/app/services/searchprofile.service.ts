import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ProfileModel } from '../models/profile.model';

@Injectable({
  providedIn: 'root'
})
export class SearchprofileService {

  constructor(private http: HttpClient) { }

  searchProfiles(keyword: string): Observable<ProfileModel[]> {

    var searchUrl = "https://localhost:44357/api/searchprofiles/" + keyword;
    var data = this.http.get<ProfileModel[]>(searchUrl);
    
    return data;
  }
}
