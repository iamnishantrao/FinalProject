import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {SignupModel} from '../models/signup.model';


@Injectable({
  providedIn: 'root'
})
export class SignupService {

  constructor(private http: HttpClient) { }
  
  doSignup(signupModel:SignupModel): Observable<object>
  {
    var url = "https://localhost:44357/api/signup";
    var x = this.http.post(url, signupModel);
    
    return x;
  }
}
