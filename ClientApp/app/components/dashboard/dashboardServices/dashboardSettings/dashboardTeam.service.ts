import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http'; 
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map'; 

@Injectable()
export class DashboardSettingsService {
    constructor(private http:Http) {
    }
    getUserInfo() {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        return this.http.get('/api/Settings/GetUser')
        .map(response  => response.json())
    }
}