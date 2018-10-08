import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginModel } from '../models/login.model';
import { Observable, throwError } from 'rxjs';
import { LoginCallbackModel } from '../models/logincallback.model';
import { map, filter, catchError, mergeMap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  loginCallback: LoginCallbackModel;
  constructor(private http: HttpClient) { }

  doLogin(loginData: LoginModel): Observable<string> {
    var url = "https://localhost:44357/api/authentication/login";
    return this.http.post<LoginCallbackModel>(url, loginData).pipe(
      map(response => {
        localStorage.setItem('access_token', response.auth_token);
        return "true";
      }),
      catchError(error => {
        return throwError('Failed')
      })
    )
  }
}
