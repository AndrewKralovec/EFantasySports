import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 
import { MockLeague } from '../../../../mocks/league.mock';
const mock = MockLeague;

@Injectable()
export class DashboardLeagueService {
    constructor(private http:Http) {
    }
    getLeagueInfo(){
        return Observable.create((observer: any) => {
            setTimeout(() => {
                observer.next(mock);
                observer.complete();
            }, 500);
        });
    }
    /*
    getLeagueInfo() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/League/GetLeague')
        .map(response  => response.json())
    }
    */
}