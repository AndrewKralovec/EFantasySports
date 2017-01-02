import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 
import { MockTeam } from '../../../../mocks/team.mock';
const mock = MockTeam;

@Injectable()
export class DashboardTeamService {
    constructor(private http:Http) {
    }
    getTeamInfo() {
        return Observable.create((observer: any) => {
            setTimeout(() => {
                observer.next(mock);
                observer.complete();
            }, 500);
        });
    }
    /* 
    getTeamInfo() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Team/GetTeam')
        .map(response  => response.json())
    }
    */
}

