import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private identityPath = 'Identity';
  private loginPath = environment.apiUrl + this.identityPath +'/login'
  private registerPath = environment.apiUrl + this.identityPath +'/register'

  constructor(private http: HttpClient) { }

  login(data: any): Observable<any> {
    return this.http.post(this.loginPath
      ,data
      ,{responseType: 'text'})
  }
  
  register(data: any): Observable<any>{
    return this.http.post(this.registerPath,data)
  }

  saveToken(token: string){
    localStorage.setItem('token', token)
  }

  getToken(){
    return localStorage.getItem('token')
  }

  isAuthenticated(){
    if(this.getToken()){
      return true;
    }

    return false;
  }
}
