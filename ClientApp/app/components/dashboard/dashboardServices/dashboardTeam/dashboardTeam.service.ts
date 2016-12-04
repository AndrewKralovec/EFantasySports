import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 

@Injectable()
export class DashboardTeamService {
    constructor(private http:Http) {
    }
    getTeamInfo() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Team/GetTeam')
        .map(response  => response.json())
    }
}