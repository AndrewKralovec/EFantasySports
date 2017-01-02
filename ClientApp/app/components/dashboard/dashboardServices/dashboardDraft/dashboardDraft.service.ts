import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 
import { Players } from '../../../../mocks/players.mock';
const mock = Players; 

@Injectable()
export class DashboardDraftService {
    constructor(private http:Http) {
    }
    getPlayers() {
        return Observable.create((observer: any) => {
            setTimeout(() => {
                observer.next(mock);
                observer.complete();
            }, 500);
        });
    }
    /*
    getPlayers() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Game/GetPlayers')
        .map(response  => response.json())
    }
    */ 
}