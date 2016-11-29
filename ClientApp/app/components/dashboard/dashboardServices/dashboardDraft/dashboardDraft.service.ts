import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 

@Injectable()
export class DashboardDraftService {
    constructor(private http:Http) {
    }
    getPlayers() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Game/getPlayers')
        .map(response  => response.json())
    }
}