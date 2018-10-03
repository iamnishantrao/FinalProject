import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ProfileModel } from '../models/profile.model';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {

  constructor(private http: HttpClient) { }

  getProfile(): Observable<ProfileModel> {
    var profileUrl = "https://localhost:44357/api/profile";
    // var profileUrl = "https://api.github.com/users/iamnishantrao";
    
    var data = this.http.get<ProfileModel>(profileUrl);

    return data;
  }
}
