import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Team } from '../models/team';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})

export class TeamService {
  private createTeamPath = environment.apiUrl + 'team/'

  constructor(private http: HttpClient, private authService: AuthService) { }

  create(data): Observable<Team> {
    let authHeaders = new HttpHeaders(
      { 'Authorization': `Bearer ${this.authService.getToken()}` }
    );

    return this.http.post<Team>(this.createTeamPath + 'create', data, { headers: authHeaders })
  }
}
